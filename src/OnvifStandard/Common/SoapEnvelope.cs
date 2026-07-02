using System.Xml;
using System.Xml.Serialization;

namespace OnvifStandard.Common
{
    [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class SoapEnvelope
    {
        [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public XmlElement Body { get; set; }
    }
    
    [XmlRoot(ElementName = "Fault", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class SoapFault
    {
        [XmlElement(ElementName = "Code")]
        public SoapFaultCode Code { get; set; }

        [XmlElement(ElementName = "Reason")]
        public SoapFaultReason Reason { get; set; }

        [XmlElement(ElementName = "Detail")]
        public SoapFaultDetail Detail { get; set; }
    }

    public class SoapFaultCode
    {
        [XmlElement(ElementName = "Value")]
        public string Value { get; set; }

        [XmlElement(ElementName = "Subcode")]
        public SoapFaultSubcode Subcode { get; set; }
    }

    public class SoapFaultSubcode
    {
        [XmlElement(ElementName = "Value")]
        public string Value { get; set; }
    }

    public class SoapFaultReason
    {
        [XmlElement(ElementName = "Text")]
        public string Text { get; set; }
    }

    public class SoapFaultDetail
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
}