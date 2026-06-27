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
                await httpResponseMessage.Content.ReadAsStringAsync();
            }

            if (typeof(TRes) == typeof(HttpResponseMessage))
            {
                return (TRes)(object)httpResponseMessage;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(SoapEnvelope));
            Stream result = await httpResponseMessage.Content.ReadAsStreamAsync();
            SoapEnvelope deserialize = (SoapEnvelope)serializer.Deserialize(result);

            TRes res = deserialize.GetFromEnvelope<TRes>(throwOnFault);
            return res;
        }

        protected SoapSecurityHeader getSecurityHeader() => SoapSecurityHeader.Create(User, Password);
    }
}