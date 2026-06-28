using System;
using System.Xml;
using System.Xml.Serialization;

using OnvifStandard.Common;

namespace OnvifStandard
{
    public static class Extensions
    {
        public static T GetFromEnvelope<T>(this SoapEnvelope source, bool throwOnFault = true)
        {
            XmlElement sourceBody = source.Body;
            if (sourceBody == null)
            {
                return default(T);
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (XmlNodeReader reader = new XmlNodeReader(sourceBody))
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                bool isFault = false;
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(SoapFault));
                    using (XmlNodeReader reader = new XmlNodeReader(sourceBody))
                    {
                        SoapFault deserialize = (SoapFault)serializer.Deserialize(reader);
                        isFault = true;
                        if (throwOnFault)
                        {
                            string faultMessage = deserialize?.Reason?.Text ?? "SOAP fault returned by device.";
                            string faultCode = deserialize?.Code?.Subcode?.Value ?? deserialize?.Code?.Value;
                            if (!string.IsNullOrWhiteSpace(faultCode))
                            {
                                throw new InvalidOperationException($"ONVIF SOAP Fault [{faultCode}]: {faultMessage}");
                            }

                            throw new InvalidOperationException($"ONVIF SOAP Fault: {faultMessage}");
                        }

                        return default(T);
                    }
                }
                catch (Exception exception)
                {
                    if (isFault)
                    {
                        throw;
                    }

                    throw new InvalidOperationException($"Failed to deserialize SOAP response into type {typeof(T).Name}. : content: {sourceBody.OuterXml}", exception);
                }
            }
        }

        public static bool TryGetFault(this SoapEnvelope source, out SoapFault fault)
        {
            fault = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SoapFault));
                using (XmlNodeReader reader = new XmlNodeReader(source.Body))
                {
                    SoapFault deserialize = (SoapFault)serializer.Deserialize(reader);
                    fault = deserialize;
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
