using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

using OnvifStandard.Common;

using SoapHttpClient;
using SoapHttpClient.Enums;

namespace OnvifStandard
{
    public abstract class OnvifSoapClientBase
    {
        private readonly XmlSerializer m_envelopeSerializer = new XmlSerializer(typeof(SoapEnvelope));
        public SoapClient SoapClient { get; set; }
        public Uri ServiceUri { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public SoapVersion SoapVersion { get; set; } = SoapVersion.Soap12;

        protected async Task<TRes> doRequestAwaitResponse<TReq, TRes>(Uri                uri,
                                                                      TReq               request,
                                                                      SoapSecurityHeader securityHeader,
                                                                      bool               throwOnFault = true)
        {
            
            HttpResponseMessage httpResponseMessage = await SoapClient.PostAsync(uri,
                                                                                 SoapVersion,
                                                                                 request,
                                                                                 securityHeader);

            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                string r = await httpResponseMessage.Content.ReadAsStringAsync();
                if (!r.Contains("Fault"))
                {
                    httpResponseMessage.EnsureSuccessStatusCode();
                }
            }

            if (typeof(TRes) == typeof(HttpResponseMessage))
            {
                return (TRes)(object)httpResponseMessage;
            }

            SoapEnvelope envelope = await getEnvelope(httpResponseMessage);
            TRes res = envelope.GetFromEnvelope<TRes>(throwOnFault);
            return res;
        }

        private async Task<SoapEnvelope> getEnvelope(HttpResponseMessage httpResponseMessage)
        {
            try
            {
                Stream result = await httpResponseMessage.Content.ReadAsStreamAsync();
                SoapEnvelope deserialize = (SoapEnvelope)m_envelopeSerializer.Deserialize(result);
                return deserialize;
            }
            catch (Exception e)
            {
                string contentBody = await httpResponseMessage.Content.ReadAsStringAsync();
                throw new InvalidOperationException($"Failed to deserialize SOAP response into type {typeof(SoapEnvelope).Name}. Response content: {contentBody}", e);
            }
        }

        protected SoapSecurityHeader getSecurityHeader() => SoapSecurityHeader.Create(User, Password);
    }
}
