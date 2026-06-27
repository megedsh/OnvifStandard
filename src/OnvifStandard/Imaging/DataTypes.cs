using System.Xml;
using System.Xml.Serialization;

namespace OnvifStandard.Imaging
{
    [XmlRoot("GetServiceCapabilities", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetServiceCapabilitiesRequest
    {
    }

    [XmlRoot("GetServiceCapabilitiesResponse", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetServiceCapabilitiesResponse
    {
        [XmlElement("Capabilities", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public ImagingServiceCapabilities Capabilities { get; set; }
    }

    public class ImagingServiceCapabilities
    {
        [XmlAttribute("ImageStabilization")]
        public string ImageStabilization { get; set; }

        [XmlAttribute("Presets")]
        public string Presets { get; set; }

        [XmlAttribute("AdaptablePreset")]
        public string AdaptablePreset { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetImagingSettings", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetImagingSettingsRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string VideoSourceToken { get; set; }
    }

    [XmlRoot("GetImagingSettingsResponse", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetImagingSettingsResponse
    {
        [XmlElement("ImagingSettings", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public ImagingSettings20 ImagingSettings { get; set; }
    }

    [XmlRoot("SetImagingSettings", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class SetImagingSettingsRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string VideoSourceToken { get; set; }

        [XmlElement("ImagingSettings", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public ImagingSettings20 ImagingSettings { get; set; }

        [XmlElement("ForcePersistence", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public bool? ForcePersistence { get; set; }
    }

    [XmlRoot("SetImagingSettingsResponse", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class SetImagingSettingsResponse
    {
    }

    [XmlRoot("GetOptions", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetOptionsRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string VideoSourceToken { get; set; }
    }

    [XmlRoot("GetOptionsResponse", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetOptionsResponse
    {
        [XmlElement("ImagingOptions", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public ImagingOptions20 ImagingOptions { get; set; }
    }

    [XmlRoot("Move", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class MoveRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string VideoSourceToken { get; set; }

        [XmlElement("Focus", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public FocusMove Focus { get; set; }
    }

    [XmlRoot("MoveResponse", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class MoveResponse
    {
    }

    [XmlRoot("GetMoveOptions", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetMoveOptionsRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string VideoSourceToken { get; set; }
    }

    [XmlRoot("GetMoveOptionsResponse", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetMoveOptionsResponse
    {
        [XmlElement("MoveOptions", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public MoveOptions20 MoveOptions { get; set; }
    }

    [XmlRoot("Stop", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class StopRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string VideoSourceToken { get; set; }
    }

    [XmlRoot("StopResponse", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class StopResponse
    {
    }

    [XmlRoot("GetStatus", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetStatusRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string VideoSourceToken { get; set; }
    }

    [XmlRoot("GetStatusResponse", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetStatusResponse
    {
        [XmlElement("Status", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public ImagingStatus20 Status { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public enum ImagingPresetType
    {
        Custom,
        ClearWeather,
        Cloudy,
        Fog,
        Rain,
        Snowing,
        Snow,
        WDR,
        Shade,
        Night,
        Indoor,
        Fluorescent,
        Incandescent,
        [XmlEnum("Sodium(Natrium)")]
        SodiumNatrium,
        [XmlEnum("Sunrise(Horizon)")]
        SunriseHorizon,
        [XmlEnum("Sunset(Rear)")]
        SunsetRear,
        ExtremeHot,
        ExtremeCold,
        Underwater,
        CloseUp,
        Motion,
        FlickerFree50,
        FlickerFree60,
    }

    public class ImagingPreset
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string Name { get; set; }

        [XmlAttribute("token")]
        public string Token { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetPresets", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetPresetsRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string VideoSourceToken { get; set; }
    }

    [XmlRoot("GetPresetsResponse", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetPresetsResponse
    {
        [XmlElement("Preset", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public ImagingPreset[] Preset { get; set; }
    }

    [XmlRoot("GetCurrentPreset", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetCurrentPresetRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string VideoSourceToken { get; set; }
    }

    [XmlRoot("GetCurrentPresetResponse", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class GetCurrentPresetResponse
    {
        [XmlElement("Preset", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public ImagingPreset Preset { get; set; }
    }

    [XmlRoot("SetCurrentPreset", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class SetCurrentPresetRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string VideoSourceToken { get; set; }

        [XmlElement("PresetToken", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public string PresetToken { get; set; }
    }

    [XmlRoot("SetCurrentPresetResponse", Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public class SetCurrentPresetResponse
    {
    }

    public class ImagingSettings20
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ImagingOptions20
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class FocusMove
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class MoveOptions20
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ImagingStatus20
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
}
