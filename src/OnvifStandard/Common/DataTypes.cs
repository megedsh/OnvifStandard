using System.Xml.Serialization;

using System.Xml;
using System.Xml.Serialization;

namespace OnvifStandard.Common
{
    public class ConfigurationEntity
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name { get; set; }

        [XmlElement("UseCount", Namespace = "http://www.onvif.org/ver10/schema")]
        public int UseCount { get; set; }

        [XmlAttribute("token")]
        public string Token { get; set; }
    }

    public class GeoLocation
    {
        [XmlAttribute("lon")]
        public double Lon { get; set; }

        [XmlIgnore]
        public bool LonSpecified { get; set; }

        [XmlAttribute("lat")]
        public double Lat { get; set; }

        [XmlIgnore]
        public bool LatSpecified { get; set; }

        [XmlAttribute("elevation")]
        public float Elevation { get; set; }

        [XmlIgnore]
        public bool ElevationSpecified { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
}
