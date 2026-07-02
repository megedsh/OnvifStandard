using System.Xml;
using System.Xml.Serialization;

namespace OnvifStandard.Ptz
{
    [XmlRoot("GetServiceCapabilities", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetServiceCapabilitiesRequest { }

    [XmlRoot("GetServiceCapabilitiesResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetServiceCapabilitiesResponse
    {
        [XmlElement("Capabilities", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public Capabilities Capabilities { get; set; }
    }

    public class Capabilities
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAttribute("EFlip")]
        public string EFlip { get; set; }

        [XmlAttribute("Reverse")]
        public string Reverse { get; set; }

        [XmlAttribute("GetCompatibleConfigurations")]
        public string GetCompatibleConfigurations { get; set; }

        [XmlAttribute("MoveStatus")]
        public string MoveStatus { get; set; }

        [XmlAttribute("StatusPosition")]
        public string StatusPosition { get; set; }

        [XmlAttribute("MoveAndTrack")]
        public string MoveAndTrack { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetNodes", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetNodesRequest { }

    [XmlRoot("GetNodesResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetNodesResponse
    {
        [XmlElement("PTZNode", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZNode[] PTZNode { get; set; }
    }

    [XmlRoot("GetNode", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetNodeRequest
    {
        [XmlElement("NodeToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string NodeToken { get; set; }
    }

    [XmlRoot("GetNodeResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetNodeResponse
    {
        [XmlElement("PTZNode", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZNode PTZNode { get; set; }
    }

    [XmlRoot("GetConfigurations", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetConfigurationsRequest { }

    [XmlRoot("GetConfigurationsResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetConfigurationsResponse
    {
        [XmlElement("PTZConfiguration", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZConfiguration[] PTZConfiguration { get; set; }
    }

    [XmlRoot("GetConfiguration", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetConfigurationRequest
    {
        [XmlElement("PTZConfigurationToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string PTZConfigurationToken { get; set; }
    }

    [XmlRoot("GetConfigurationResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetConfigurationResponse
    {
        [XmlElement("PTZConfiguration", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZConfiguration PTZConfiguration { get; set; }
    }

    [XmlRoot("SetConfiguration", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class SetConfigurationRequest
    {
        [XmlElement("PTZConfiguration", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZConfiguration PTZConfiguration { get; set; }

        [XmlElement("ForcePersistence", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public bool ForcePersistence { get; set; }
    }

    [XmlRoot("SetConfigurationResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class SetConfigurationResponse { }

    [XmlRoot("GetConfigurationOptions", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetConfigurationOptionsRequest
    {
        [XmlElement("ConfigurationToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string ConfigurationToken { get; set; }
    }

    [XmlRoot("GetConfigurationOptionsResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetConfigurationOptionsResponse
    {
        [XmlElement("PTZConfigurationOptions", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZConfigurationOptions PTZConfigurationOptions { get; set; }
    }

    [XmlRoot("SendAuxiliaryCommand", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class SendAuxiliaryCommandRequest
    {
        [XmlElement("ProfileToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string ProfileToken { get; set; }

        [XmlElement("AuxiliaryData", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string AuxiliaryData { get; set; }
    }

    [XmlRoot("SendAuxiliaryCommandResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class SendAuxiliaryCommandResponse
    {
        [XmlElement("AuxiliaryResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string AuxiliaryResponse { get; set; }
    }

    [XmlRoot("GetPresets", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetPresetsRequest : ProfileTokenRequestBase { }

    [XmlRoot("GetPresetsResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetPresetsResponse
    {
        [XmlElement("Preset", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZPreset[] Preset { get; set; }
    }

    [XmlRoot("SetPreset", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class SetPresetRequest : ProfileTokenRequestBase
    {
        [XmlElement("PresetName", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string PresetName { get; set; }

        [XmlElement("PresetToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string PresetToken { get; set; }
    }

    [XmlRoot("SetPresetResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class SetPresetResponse
    {
        [XmlElement("PresetToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string PresetToken { get; set; }
    }

    [XmlRoot("RemovePreset", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class RemovePresetRequest : ProfilePresetTokenRequestBase { }

    [XmlRoot("RemovePresetResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class RemovePresetResponse { }

    [XmlRoot("GotoPreset", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GotoPresetRequest : ProfilePresetTokenRequestBase
    {
        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZSpeed Speed { get; set; }
    }

    [XmlRoot("GotoPresetResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GotoPresetResponse { }

    [XmlRoot("GetStatus", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetStatusRequest : ProfileTokenRequestBase { }

    [XmlRoot("GetStatusResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetStatusResponse
    {
        [XmlElement("PTZStatus", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZStatus PTZStatus { get; set; }
    }

    [XmlRoot("GotoHomePosition", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GotoHomePositionRequest : ProfileTokenRequestBase
    {
        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZSpeed Speed { get; set; }
    }

    [XmlRoot("GotoHomePositionResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GotoHomePositionResponse { }

    [XmlRoot("SetHomePosition", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class SetHomePositionRequest : ProfileTokenRequestBase { }

    [XmlRoot("SetHomePositionResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class SetHomePositionResponse { }

    [XmlRoot("ContinuousMove", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class ContinuousMoveRequest : ProfileTokenRequestBase
    {
        [XmlElement("Velocity", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZSpeed Velocity { get; set; }

        [XmlElement("Timeout", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string Timeout { get; set; }
    }

    [XmlRoot("ContinuousMoveResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class ContinuousMoveResponse { }

    [XmlRoot("RelativeMove", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class RelativeMoveRequest : ProfileTokenRequestBase
    {
        [XmlElement("Translation", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZVector Translation { get; set; }

        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZSpeed Speed { get; set; }
    }

    [XmlRoot("RelativeMoveResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class RelativeMoveResponse { }

    [XmlRoot("AbsoluteMove", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class AbsoluteMoveRequest : ProfileTokenRequestBase
    {
        [XmlElement("Position", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZVector Position { get; set; }

        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZSpeed Speed { get; set; }
    }

    [XmlRoot("AbsoluteMoveResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class AbsoluteMoveResponse { }

    [XmlRoot("GeoMove", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GeoMoveRequest : ProfileTokenRequestBase
    {
        [XmlElement("Target", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public GeoLocation Target { get; set; }

        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZSpeed Speed { get; set; }

        [XmlElement("AreaHeight", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public float? AreaHeight { get; set; }

        [XmlElement("AreaWidth", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public float? AreaWidth { get; set; }
    }

    [XmlRoot("GeoMoveResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GeoMoveResponse { }

    [XmlRoot("Stop", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class StopRequest : ProfileTokenRequestBase
    {
        [XmlElement("PanTilt", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public bool? PanTilt { get; set; }

        [XmlElement("Zoom", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public bool? Zoom { get; set; }
    }

    [XmlRoot("StopResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class StopResponse { }

    [XmlRoot("GetPresetTours", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetPresetToursRequest : ProfileTokenRequestBase { }

    [XmlRoot("GetPresetToursResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetPresetToursResponse
    {
        [XmlElement("PresetTour", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PresetTour[] PresetTour { get; set; }
    }

    [XmlRoot("GetPresetTour", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetPresetTourRequest : ProfilePresetTourTokenRequestBase { }

    [XmlRoot("GetPresetTourResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetPresetTourResponse
    {
        [XmlElement("PresetTour", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PresetTour PresetTour { get; set; }
    }

    [XmlRoot("GetPresetTourOptions", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetPresetTourOptionsRequest : ProfileTokenRequestBase
    {
        [XmlElement("PresetTourToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string PresetTourToken { get; set; }
    }

    [XmlRoot("GetPresetTourOptionsResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetPresetTourOptionsResponse
    {
        [XmlElement("Options", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZPresetTourOptions Options { get; set; }
    }

    [XmlRoot("CreatePresetTour", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class CreatePresetTourRequest : ProfileTokenRequestBase { }

    [XmlRoot("CreatePresetTourResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class CreatePresetTourResponse
    {
        [XmlElement("PresetTourToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string PresetTourToken { get; set; }
    }

    [XmlRoot("ModifyPresetTour", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class ModifyPresetTourRequest : ProfileTokenRequestBase
    {
        [XmlElement("PresetTour", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PresetTour PresetTour { get; set; }
    }

    [XmlRoot("ModifyPresetTourResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class ModifyPresetTourResponse { }

    [XmlRoot("OperatePresetTour", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class OperatePresetTourRequest : ProfilePresetTourTokenRequestBase
    {
        [XmlElement("Operation", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZPresetTourOperation Operation { get; set; }
    }

    [XmlRoot("OperatePresetTourResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class OperatePresetTourResponse { }

    [XmlRoot("RemovePresetTour", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class RemovePresetTourRequest : ProfilePresetTourTokenRequestBase { }

    [XmlRoot("RemovePresetTourResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class RemovePresetTourResponse { }

    [XmlRoot("GetCompatibleConfigurations", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetCompatibleConfigurationsRequest : ProfileTokenRequestBase { }

    [XmlRoot("GetCompatibleConfigurationsResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class GetCompatibleConfigurationsResponse
    {
        [XmlElement("PTZConfiguration", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZConfiguration[] PTZConfiguration { get; set; }
    }

    [XmlRoot("MoveAndStartTracking", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class MoveAndStartTrackingRequest : ProfileTokenRequestBase
    {
        [XmlElement("PresetToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string PresetToken { get; set; }

        [XmlElement("GeoLocation", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public GeoLocation GeoLocation { get; set; }

        [XmlElement("TargetPosition", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZVector TargetPosition { get; set; }

        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public PTZSpeed Speed { get; set; }

        [XmlElement("ObjectID", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public int? ObjectID { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("MoveAndStartTrackingResponse", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public class MoveAndStartTrackingResponse { }

    public class PTZNode : DeviceEntity
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name { get; set; }

        [XmlElement("SupportedPTZSpaces", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZSpaces SupportedPTZSpaces { get; set; }

        [XmlElement("MaximumNumberOfPresets", Namespace = "http://www.onvif.org/ver10/schema")]
        public int MaximumNumberOfPresets { get; set; }

        [XmlElement("HomeSupported", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool HomeSupported { get; set; }

        [XmlElement("AuxiliaryCommands", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] AuxiliaryCommands { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZNodeExtension Extension { get; set; }

        [XmlAttribute("FixedHomePosition")]
        public string FixedHomePosition { get; set; }

        [XmlAttribute("GeoMove")]
        public string GeoMove { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZNodeExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("SupportedPresetTour", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZPresetTourSupported SupportedPresetTour { get; set; }
    }

    public class PTZPresetTourSupported
    {
        [XmlElement("MaximumNumberOfPresetTours", Namespace = "http://www.onvif.org/ver10/schema")]
        public int MaximumNumberOfPresetTours { get; set; }

        [XmlElement("PTZPresetTourOperation", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZPresetTourOperation[] PTZPresetTourOperation { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZConfiguration : ConfigurationEntity
    {
        [XmlElement("NodeToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public string NodeToken { get; set; }

        [XmlElement("DefaultAbsolutePantTiltPositionSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public string DefaultAbsolutePantTiltPositionSpace { get; set; }

        [XmlElement("DefaultAbsoluteZoomPositionSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public string DefaultAbsoluteZoomPositionSpace { get; set; }

        [XmlElement("DefaultRelativePanTiltTranslationSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public string DefaultRelativePanTiltTranslationSpace { get; set; }

        [XmlElement("DefaultRelativeZoomTranslationSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public string DefaultRelativeZoomTranslationSpace { get; set; }

        [XmlElement("DefaultContinuousPanTiltVelocitySpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public string DefaultContinuousPanTiltVelocitySpace { get; set; }

        [XmlElement("DefaultContinuousZoomVelocitySpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public string DefaultContinuousZoomVelocitySpace { get; set; }

        [XmlElement("DefaultPTZSpeed", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZSpeed DefaultPTZSpeed { get; set; }

        [XmlElement("DefaultPTZTimeout", Namespace = "http://www.onvif.org/ver10/schema")]
        public string DefaultPTZTimeout { get; set; }

        [XmlElement("PanTiltLimits", Namespace = "http://www.onvif.org/ver10/schema")]
        public PanTiltLimits PanTiltLimits { get; set; }

        [XmlElement("ZoomLimits", Namespace = "http://www.onvif.org/ver10/schema")]
        public ZoomLimits ZoomLimits { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZConfigurationExtension Extension { get; set; }

        [XmlAttribute("MoveRamp")]
        public string MoveRamp { get; set; }

        [XmlAttribute("PresetRamp")]
        public string PresetRamp { get; set; }

        [XmlAttribute("PresetTourRamp")]
        public string PresetTourRamp { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZConfigurationExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("PTControlDirection", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTControlDirection PTControlDirection { get; set; }
    }

    public class PTControlDirection
    {
        [XmlElement("EFlip", Namespace = "http://www.onvif.org/ver10/schema")]
        public EFlip EFlip { get; set; }

        [XmlElement("Reverse", Namespace = "http://www.onvif.org/ver10/schema")]
        public Reverse Reverse { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class EFlip
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Mode { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class Reverse
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Mode { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZConfigurationOptions
    {
        [XmlElement("Spaces", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZSpaces Spaces { get; set; }

        [XmlElement("PTZTimeout", Namespace = "http://www.onvif.org/ver10/schema")]
        public DurationRange PTZTimeout { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("PTControlDirection", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTControlDirectionOptions PTControlDirection { get; set; }

        [XmlAttribute("PTZRamps")]
        public string PTZRamps { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTControlDirectionOptions
    {
        [XmlElement("EFlip", Namespace = "http://www.onvif.org/ver10/schema")]
        public EFlipOptions EFlip { get; set; }

        [XmlElement("Reverse", Namespace = "http://www.onvif.org/ver10/schema")]
        public ReverseOptions Reverse { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class EFlipOptions
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] Mode { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ReverseOptions
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] Mode { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZSpaces
    {
        [XmlElement("AbsolutePanTiltPositionSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space2DDescription[] AbsolutePanTiltPositionSpace { get; set; }

        [XmlElement("AbsoluteZoomPositionSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space1DDescription[] AbsoluteZoomPositionSpace { get; set; }

        [XmlElement("RelativePanTiltTranslationSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space2DDescription[] RelativePanTiltTranslationSpace { get; set; }

        [XmlElement("RelativeZoomTranslationSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space1DDescription[] RelativeZoomTranslationSpace { get; set; }

        [XmlElement("ContinuousPanTiltVelocitySpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space2DDescription[] ContinuousPanTiltVelocitySpace { get; set; }

        [XmlElement("ContinuousZoomVelocitySpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space1DDescription[] ContinuousZoomVelocitySpace { get; set; }

        [XmlElement("PanTiltSpeedSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space1DDescription[] PanTiltSpeedSpace { get; set; }

        [XmlElement("ZoomSpeedSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space1DDescription[] ZoomSpeedSpace { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class Space2DDescription
    {
        [XmlElement("URI", Namespace = "http://www.onvif.org/ver10/schema")]
        public string URI { get; set; }

        [XmlElement("XRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange XRange { get; set; }

        [XmlElement("YRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange YRange { get; set; }
    }

    public class Space1DDescription
    {
        [XmlElement("URI", Namespace = "http://www.onvif.org/ver10/schema")]
        public string URI { get; set; }

        [XmlElement("XRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public FloatRange XRange { get; set; }
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

    public class PanTiltLimits
    {
        [XmlElement("Range", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space2DDescription Range { get; set; }
    }

    public class ZoomLimits
    {
        [XmlElement("Range", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space1DDescription Range { get; set; }
    }

    public class PTZSpeed
    {
        [XmlElement("PanTilt", Namespace = "http://www.onvif.org/ver10/schema")]
        public Vector2D PanTilt { get; set; }

        [XmlElement("Zoom", Namespace = "http://www.onvif.org/ver10/schema")]
        public Vector1D Zoom { get; set; }
    }

    public class PTZVector
    {
        [XmlElement("PanTilt", Namespace = "http://www.onvif.org/ver10/schema")]
        public Vector2D PanTilt { get; set; }

        [XmlElement("Zoom", Namespace = "http://www.onvif.org/ver10/schema")]
        public Vector1D Zoom { get; set; }
    }

    public class Vector2D
    {
        [XmlAttribute("x")]
        public float X { get; set; }

        [XmlAttribute("y")]
        public float Y { get; set; }

        [XmlAttribute("space")]
        public string Space { get; set; }
    }

    public class Vector1D
    {
        [XmlAttribute("x")]
        public float X { get; set; }

        [XmlAttribute("space")]
        public string Space { get; set; }
    }

    public class PTZPreset
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name { get; set; }

        [XmlElement("PTZPosition", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZVector PTZPosition { get; set; }

        [XmlAttribute("token")]
        public string Token { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZStatus
    {
        [XmlElement("Position", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZVector Position { get; set; }

        [XmlElement("MoveStatus", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZMoveStatus MoveStatus { get; set; }

        [XmlElement("Error", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Error { get; set; }

        [XmlElement("UtcTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public string UtcTime { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZMoveStatus
    {
        [XmlElement("PanTilt", Namespace = "http://www.onvif.org/ver10/schema")]
        public string PanTilt { get; set; }

        [XmlElement("Zoom", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Zoom { get; set; }
    }

    public class PresetTour
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name { get; set; }

        [XmlElement("Status", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZPresetTourStatus Status { get; set; }

        [XmlElement("AutoStart", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool AutoStart { get; set; }

        [XmlElement("StartingCondition", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZPresetTourStartingCondition StartingCondition { get; set; }

        [XmlElement("TourSpot", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZPresetTourSpot[] TourSpot { get; set; }

        [XmlAttribute("token")]
        public string Token { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZPresetTourStatus
    {
        [XmlElement("State", Namespace = "http://www.onvif.org/ver10/schema")]
        public string State { get; set; }

        [XmlElement("CurrentTourSpot", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZPresetTourSpot CurrentTourSpot { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZPresetTourStartingCondition
    {
        [XmlElement("RecurringTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? RecurringTime { get; set; }

        [XmlElement("RecurringDuration", Namespace = "http://www.onvif.org/ver10/schema")]
        public string RecurringDuration { get; set; }

        [XmlElement("Direction", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Direction { get; set; }

        [XmlAttribute("RandomPresetOrder")]
        public string RandomPresetOrder { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZPresetTourSpot
    {
        [XmlElement("PresetDetail", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZPresetTourPresetDetail PresetDetail { get; set; }

        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZSpeed Speed { get; set; }

        [XmlElement("StayTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public string StayTime { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZPresetTourPresetDetail
    {
        [XmlElement("PresetToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public string PresetToken { get; set; }

        [XmlElement("Home", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? Home { get; set; }

        [XmlElement("PTZPosition", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZVector PTZPosition { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZPresetTourOptions
    {
        [XmlElement("AutoStart", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool AutoStart { get; set; }

        [XmlElement("StartingCondition", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZPresetTourStartingConditionOptions StartingCondition { get; set; }

        [XmlElement("TourSpot", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZPresetTourSpotOptions TourSpot { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZPresetTourStartingConditionOptions
    {
        [XmlElement("RecurringTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange RecurringTime { get; set; }

        [XmlElement("RecurringDuration", Namespace = "http://www.onvif.org/ver10/schema")]
        public DurationRange RecurringDuration { get; set; }

        [XmlElement("Direction", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] Direction { get; set; }

        [XmlAttribute("RandomPresetOrder")]
        public string RandomPresetOrder { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZPresetTourSpotOptions
    {
        [XmlElement("PresetDetail", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZPresetTourPresetDetailOptions PresetDetail { get; set; }

        [XmlElement("StayTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public DurationRange StayTime { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZPresetTourPresetDetailOptions
    {
        [XmlElement("PresetToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] PresetToken { get; set; }

        [XmlElement("Home", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? Home { get; set; }

        [XmlElement("PanTiltPositionSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space2DDescription PanTiltPositionSpace { get; set; }

        [XmlElement("ZoomPositionSpace", Namespace = "http://www.onvif.org/ver10/schema")]
        public Space1DDescription ZoomPositionSpace { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class GeoLocation
    {
        [XmlElement("Latitude", Namespace = "http://www.onvif.org/ver10/schema")]
        public double? Latitude { get; set; }

        [XmlElement("Longitude", Namespace = "http://www.onvif.org/ver10/schema")]
        public double? Longitude { get; set; }

        [XmlElement("Altitude", Namespace = "http://www.onvif.org/ver10/schema")]
        public double? Altitude { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum PTZPresetTourOperation
    {
        Start,
        Stop,
        Pause,
        Extended,
    }

    public class DeviceEntity
    {
        [XmlAttribute("token")]
        public string Token { get; set; }
    }

    public class ConfigurationEntity
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name { get; set; }

        [XmlElement("UseCount", Namespace = "http://www.onvif.org/ver10/schema")]
        public int UseCount { get; set; }

        [XmlAttribute("token")]
        public string Token { get; set; }
    }

    public class IntRange
    {
        [XmlElement("Min", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Min { get; set; }

        [XmlElement("Max", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Max { get; set; }
    }

    public class ProfileTokenRequestBase
    {
        [XmlElement("ProfileToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string ProfileToken { get; set; }
    }

    public class ProfilePresetTokenRequestBase : ProfileTokenRequestBase
    {
        [XmlElement("PresetToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string PresetToken { get; set; }
    }

    public class ProfilePresetTourTokenRequestBase : ProfileTokenRequestBase
    {
        [XmlElement("PresetTourToken", Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public string PresetTourToken { get; set; }
    }
}
