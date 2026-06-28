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

    public class FocusMove
    {
        [XmlElement("Absolute", Namespace = "http://www.onvif.org/ver10/schema")]
        public AbsoluteFocus Absolute { get; set; }

        [XmlElement("Relative", Namespace = "http://www.onvif.org/ver10/schema")]
        public RelativeFocus Relative { get; set; }

        [XmlElement("Continuous", Namespace = "http://www.onvif.org/ver10/schema")]
        public ContinuousFocus Continuous { get; set; }
    }

    public class AbsoluteFocus
    {
        [XmlElement("Position", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Position { get; set; }

        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Speed { get; set; }
    }

    public class RelativeFocus
    {
        [XmlElement("Distance", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Distance { get; set; }

        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Speed { get; set; }
    }

    public class ContinuousFocus
    {
        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Speed { get; set; }
    }

    public class MoveOptions20
    {
        [XmlElement("Absolute", Namespace = "http://www.onvif.org/ver10/schema")]
        public AbsoluteFocusOptions Absolute { get; set; }

        [XmlElement("Relative", Namespace = "http://www.onvif.org/ver10/schema")]
        public RelativeFocusOptions20 Relative { get; set; }

        [XmlElement("Continuous", Namespace = "http://www.onvif.org/ver10/schema")]
        public ContinuousFocusOptions Continuous { get; set; }
    }

    public class AbsoluteFocusOptions
    {
        [XmlElement("Position", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Position { get; set; }

        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Speed { get; set; }
    }

    public class RelativeFocusOptions20
    {
        [XmlElement("Distance", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Distance { get; set; }

        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Speed { get; set; }
    }

    public class ContinuousFocusOptions
    {
        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Speed { get; set; }
    }

    public class ImagingStatus20
    {
        [XmlElement("FocusStatus20", Namespace = "http://www.onvif.org/ver10/schema")]
        public FocusStatus20 FocusStatus20 { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImagingStatus20Extension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ImagingStatus20Extension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class FocusStatus20
    {
        [XmlElement("Position", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Position { get; set; }

        [XmlElement("MoveStatus", Namespace = "http://www.onvif.org/ver10/schema")]
        public MoveStatus MoveStatus { get; set; }

        [XmlElement("Error", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Error { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public FocusStatus20Extension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class FocusStatus20Extension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class ImagingSettings20
    {
        [XmlElement("BacklightCompensation", Namespace = "http://www.onvif.org/ver10/schema")]
        public BacklightCompensation20 BacklightCompensation { get; set; }

        [XmlElement("Brightness", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Brightness { get; set; }

        [XmlElement("ColorSaturation", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? ColorSaturation { get; set; }

        [XmlElement("Contrast", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Contrast { get; set; }

        [XmlElement("Exposure", Namespace = "http://www.onvif.org/ver10/schema")]
        public Exposure20 Exposure { get; set; }

        [XmlElement("Focus", Namespace = "http://www.onvif.org/ver10/schema")]
        public FocusConfiguration20 Focus { get; set; }

        [XmlElement("IrCutFilter", Namespace = "http://www.onvif.org/ver10/schema")]
        public IrCutFilterMode? IrCutFilter { get; set; }

        [XmlElement("Sharpness", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Sharpness { get; set; }

        [XmlElement("WideDynamicRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public WideDynamicRange20 WideDynamicRange { get; set; }

        [XmlElement("WhiteBalance", Namespace = "http://www.onvif.org/ver10/schema")]
        public WhiteBalance20 WhiteBalance { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImagingSettingsExtension20 Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ImagingSettingsExtension20
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("ImageStabilization", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImageStabilization ImageStabilization { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImagingSettingsExtension202 Extension { get; set; }
    }

    public class ImagingSettingsExtension202
    {
        [XmlElement("IrCutFilterAutoAdjustment", Namespace = "http://www.onvif.org/ver10/schema")]
        public IrCutFilterAutoAdjustment[] IrCutFilterAutoAdjustment { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImagingSettingsExtension203 Extension { get; set; }
    }

    public class ImagingSettingsExtension203
    {
        [XmlElement("ToneCompensation", Namespace = "http://www.onvif.org/ver10/schema")]
        public ToneCompensation ToneCompensation { get; set; }

        [XmlElement("Defogging", Namespace = "http://www.onvif.org/ver10/schema")]
        public Defogging Defogging { get; set; }

        [XmlElement("NoiseReduction", Namespace = "http://www.onvif.org/ver10/schema")]
        public NoiseReduction NoiseReduction { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImagingSettingsExtension204 Extension { get; set; }
    }

    public class ImagingSettingsExtension204
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class ImagingOptions20
    {
        [XmlElement("BacklightCompensation", Namespace = "http://www.onvif.org/ver10/schema")]
        public BacklightCompensationOptions20 BacklightCompensation { get; set; }

        [XmlElement("Brightness", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Brightness { get; set; }

        [XmlElement("ColorSaturation", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange ColorSaturation { get; set; }

        [XmlElement("Contrast", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Contrast { get; set; }

        [XmlElement("Exposure", Namespace = "http://www.onvif.org/ver10/schema")]
        public ExposureOptions20 Exposure { get; set; }

        [XmlElement("Focus", Namespace = "http://www.onvif.org/ver10/schema")]
        public FocusOptions20 Focus { get; set; }

        [XmlElement("IrCutFilterModes", Namespace = "http://www.onvif.org/ver10/schema")]
        public IrCutFilterMode[] IrCutFilterModes { get; set; }

        [XmlElement("Sharpness", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Sharpness { get; set; }

        [XmlElement("WideDynamicRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public WideDynamicRangeOptions20 WideDynamicRange { get; set; }

        [XmlElement("WhiteBalance", Namespace = "http://www.onvif.org/ver10/schema")]
        public WhiteBalanceOptions20 WhiteBalance { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImagingOptions20Extension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ImagingOptions20Extension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("ImageStabilization", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImageStabilizationOptions ImageStabilization { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImagingOptions20Extension2 Extension { get; set; }
    }

    public class ImagingOptions20Extension2
    {
        [XmlElement("IrCutFilterAutoAdjustment", Namespace = "http://www.onvif.org/ver10/schema")]
        public IrCutFilterAutoAdjustmentOptions IrCutFilterAutoAdjustment { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImagingOptions20Extension3 Extension { get; set; }
    }

    public class ImagingOptions20Extension3
    {
        [XmlElement("ToneCompensationOptions", Namespace = "http://www.onvif.org/ver10/schema")]
        public ToneCompensationOptions ToneCompensationOptions { get; set; }

        [XmlElement("DefoggingOptions", Namespace = "http://www.onvif.org/ver10/schema")]
        public DefoggingOptions DefoggingOptions { get; set; }

        [XmlElement("NoiseReductionOptions", Namespace = "http://www.onvif.org/ver10/schema")]
        public NoiseReductionOptions NoiseReductionOptions { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImagingOptions20Extension4 Extension { get; set; }
    }

    public class ImagingOptions20Extension4
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class BacklightCompensation20
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public BacklightCompensationMode Mode { get; set; }

        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Level { get; set; }
    }

    public class Exposure20
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public ExposureMode Mode { get; set; }

        [XmlElement("Priority", Namespace = "http://www.onvif.org/ver10/schema")]
        public ExposurePriority? Priority { get; set; }

        [XmlElement("Window", Namespace = "http://www.onvif.org/ver10/schema")]
        public Rectangle Window { get; set; }

        [XmlElement("MinExposureTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? MinExposureTime { get; set; }

        [XmlElement("MaxExposureTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? MaxExposureTime { get; set; }

        [XmlElement("MinGain", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? MinGain { get; set; }

        [XmlElement("MaxGain", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? MaxGain { get; set; }

        [XmlElement("MinIris", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? MinIris { get; set; }

        [XmlElement("MaxIris", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? MaxIris { get; set; }

        [XmlElement("ExposureTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? ExposureTime { get; set; }

        [XmlElement("Gain", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Gain { get; set; }

        [XmlElement("Iris", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Iris { get; set; }
    }

    public class FocusConfiguration20
    {
        [XmlElement("AutoFocusMode", Namespace = "http://www.onvif.org/ver10/schema")]
        public AutoFocusMode AutoFocusMode { get; set; }

        [XmlElement("DefaultSpeed", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? DefaultSpeed { get; set; }

        [XmlElement("NearLimit", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? NearLimit { get; set; }

        [XmlElement("FarLimit", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? FarLimit { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public FocusConfiguration20Extension Extension { get; set; }

        [XmlAttribute("AFMode")]
        public string AFMode { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class FocusConfiguration20Extension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class WideDynamicRange20
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public WideDynamicMode Mode { get; set; }

        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Level { get; set; }
    }

    public class WhiteBalance20
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public WhiteBalanceMode Mode { get; set; }

        [XmlElement("CrGain", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? CrGain { get; set; }

        [XmlElement("CbGain", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? CbGain { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public WhiteBalance20Extension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class WhiteBalance20Extension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class ImageStabilization
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImageStabilizationMode Mode { get; set; }

        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Level { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImageStabilizationExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ImageStabilizationExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class IrCutFilterAutoAdjustment
    {
        [XmlElement("BoundaryType", Namespace = "http://www.onvif.org/ver10/schema")]
        public string BoundaryType { get; set; }

        [XmlElement("BoundaryOffset", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? BoundaryOffset { get; set; }

        [XmlElement("ResponseTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public string ResponseTime { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public IrCutFilterAutoAdjustmentExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class IrCutFilterAutoAdjustmentExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class ToneCompensation
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Mode { get; set; }

        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Level { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ToneCompensationExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ToneCompensationExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class Defogging
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Mode { get; set; }

        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public float? Level { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public DefoggingExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class DefoggingExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class NoiseReduction
    {
        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Level { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class BacklightCompensationOptions20
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public BacklightCompensationMode[] Mode { get; set; }

        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Level { get; set; }
    }

    public class ExposureOptions20
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public ExposureMode[] Mode { get; set; }

        [XmlElement("Priority", Namespace = "http://www.onvif.org/ver10/schema")]
        public ExposurePriority[] Priority { get; set; }

        [XmlElement("MinExposureTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange MinExposureTime { get; set; }

        [XmlElement("MaxExposureTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange MaxExposureTime { get; set; }

        [XmlElement("MinGain", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange MinGain { get; set; }

        [XmlElement("MaxGain", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange MaxGain { get; set; }

        [XmlElement("MinIris", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange MinIris { get; set; }

        [XmlElement("MaxIris", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange MaxIris { get; set; }

        [XmlElement("ExposureTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange ExposureTime { get; set; }

        [XmlElement("Gain", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Gain { get; set; }

        [XmlElement("Iris", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Iris { get; set; }
    }

    public class FocusOptions20
    {
        [XmlElement("AutoFocusModes", Namespace = "http://www.onvif.org/ver10/schema")]
        public AutoFocusMode[] AutoFocusModes { get; set; }

        [XmlElement("DefaultSpeed", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange DefaultSpeed { get; set; }

        [XmlElement("NearLimit", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange NearLimit { get; set; }

        [XmlElement("FarLimit", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange FarLimit { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public FocusOptions20Extension Extension { get; set; }
    }

    public class FocusOptions20Extension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("AFModes", Namespace = "http://www.onvif.org/ver10/schema")]
        public string AFModes { get; set; }
    }

    public class WideDynamicRangeOptions20
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public WideDynamicMode[] Mode { get; set; }

        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Level { get; set; }
    }

    public class WhiteBalanceOptions20
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public WhiteBalanceMode[] Mode { get; set; }

        [XmlElement("YrGain", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange YrGain { get; set; }

        [XmlElement("YbGain", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange YbGain { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public WhiteBalanceOptions20Extension Extension { get; set; }
    }

    public class WhiteBalanceOptions20Extension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class ImageStabilizationOptions
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImageStabilizationMode[] Mode { get; set; }

        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange Level { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImageStabilizationOptionsExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ImageStabilizationOptionsExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class IrCutFilterAutoAdjustmentOptions
    {
        [XmlElement("BoundaryType", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] BoundaryType { get; set; }

        [XmlElement("BoundaryOffset", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? BoundaryOffset { get; set; }

        [XmlElement("ResponseTimeRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public DurationRange ResponseTimeRange { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public IrCutFilterAutoAdjustmentOptionsExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class IrCutFilterAutoAdjustmentOptionsExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class ToneCompensationOptions
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] Mode { get; set; }

        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool Level { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class DefoggingOptions
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] Mode { get; set; }

        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool Level { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class NoiseReductionOptions
    {
        [XmlElement("Level", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool Level { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class FloatRange
    {
        [XmlElement("Min", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Min { get; set; }

        [XmlElement("Max", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Max { get; set; }
    }

    public class DurationRange
    {
        [XmlElement("Min", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Min { get; set; }

        [XmlElement("Max", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Max { get; set; }
    }

    public class Rectangle
    {
        [XmlElement("x", Namespace = "http://www.onvif.org/ver10/schema")]
        public float X { get; set; }

        [XmlElement("y", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Y { get; set; }

        [XmlElement("width", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Width { get; set; }

        [XmlElement("height", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Height { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum MoveStatus
    {
        IDLE,
        MOVING,
        UNKNOWN,
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum AutoFocusMode
    {
        AUTO,
        MANUAL,
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum ExposureMode
    {
        AUTO,
        MANUAL,
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum ExposurePriority
    {
        LowNoise,
        FrameRate,
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum WhiteBalanceMode
    {
        AUTO,
        MANUAL,
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum IrCutFilterMode
    {
        ON,
        OFF,
        AUTO,
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum WideDynamicMode
    {
        OFF,
        ON,
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum BacklightCompensationMode
    {
        OFF,
        ON,
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum ImageStabilizationMode
    {
        OFF,
        ON,
        AUTO,
        Extended,
    }
}
