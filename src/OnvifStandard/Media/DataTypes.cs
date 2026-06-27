using System.Xml;
using System.Xml.Serialization;

namespace OnvifStandard.Media
{
    [XmlRoot("GetServiceCapabilities", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetServiceCapabilitiesRequest
    {
    }

    [XmlRoot("GetServiceCapabilitiesResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetServiceCapabilitiesResponse
    {
        [XmlElement("Capabilities", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public MediaServiceCapabilities Capabilities { get; set; }
    }

    public class MediaServiceCapabilities
    {
        [XmlElement("ProfileCapabilities", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public ProfileCapabilities ProfileCapabilities { get; set; }

        [XmlElement("StreamingCapabilities", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public StreamingCapabilities StreamingCapabilities { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAttribute("SnapshotUri")]
        public string SnapshotUri { get; set; }

        [XmlAttribute("Rotation")]
        public string Rotation { get; set; }

        [XmlAttribute("VideoSourceMode")]
        public string VideoSourceMode { get; set; }

        [XmlAttribute("OSD")]
        public string OSD { get; set; }

        [XmlAttribute("TemporaryOSDText")]
        public string TemporaryOSDText { get; set; }

        [XmlAttribute("EXICompression")]
        public string EXICompression { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ProfileCapabilities
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAttribute("MaximumNumberOfProfiles")]
        public string MaximumNumberOfProfiles { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class StreamingCapabilities
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAttribute("RTPMulticast")]
        public string RTPMulticast { get; set; }

        [XmlAttribute("RTP_TCP")]
        public string RTP_TCP { get; set; }

        [XmlAttribute("RTP_RTSP_TCP")]
        public string RTP_RTSP_TCP { get; set; }

        [XmlAttribute("NonAggregateControl")]
        public string NonAggregateControl { get; set; }

        [XmlAttribute("NoRTSPStreaming")]
        public string NoRTSPStreaming { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetVideoSources", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoSourcesRequest
    {
    }
    [XmlRoot("GetVideoSourcesResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoSourcesResponse
    {
        [XmlElement("VideoSources", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoSource[] VideoSources { get; set; }
    }

    [XmlRoot("GetAudioSources", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioSourcesRequest
    {
    }
    [XmlRoot("GetAudioSourcesResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioSourcesResponse
    {
        [XmlElement("AudioSources", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioSource[] AudioSources { get; set; }
    }

    [XmlRoot("GetAudioOutputs", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioOutputsRequest
    {
    }
    [XmlRoot("GetAudioOutputsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioOutputsResponse
    {
        [XmlElement("AudioOutputs", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioOutput[] AudioOutputs { get; set; }
    }

    [XmlRoot("CreateProfile", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class CreateProfileRequest
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string Name { get; set; }

        [XmlElement("Token", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string Token { get; set; }
    }
    [XmlRoot("CreateProfileResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class CreateProfileResponse
    {
        [XmlElement("Profile", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public MediaProfile Profile { get; set; }
    }

    [XmlRoot("GetProfile", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetProfileRequest
    {
        [XmlElement("ProfileToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string ProfileToken { get; set; }
    }
    [XmlRoot("GetProfileResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetProfileResponse
    {
        [XmlElement("Profile", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public MediaProfile Profile { get; set; }
    }

    [XmlRoot("GetProfiles", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetProfilesRequest
    {
    }
    [XmlRoot("GetProfilesResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetProfilesResponse
    {
        [XmlElement("Profiles", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public MediaProfile[] Profiles { get; set; }
    }

    [XmlRoot("DeleteProfile", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class DeleteProfileRequest
    {
        [XmlElement("ProfileToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string ProfileToken { get; set; }
    }
    [XmlRoot("DeleteProfileResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class DeleteProfileResponse
    {
    }

    [XmlRoot("AddVideoEncoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddVideoEncoderConfigurationRequest : ProfileConfigurationRequestBase
    {
    }
    [XmlRoot("AddVideoEncoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddVideoEncoderConfigurationResponse
    {
    }
    [XmlRoot("RemoveVideoEncoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveVideoEncoderConfigurationRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("RemoveVideoEncoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveVideoEncoderConfigurationResponse
    {
    }

    [XmlRoot("AddVideoSourceConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddVideoSourceConfigurationRequest : ProfileConfigurationRequestBase
    {
    }
    [XmlRoot("AddVideoSourceConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddVideoSourceConfigurationResponse
    {
    }
    [XmlRoot("RemoveVideoSourceConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveVideoSourceConfigurationRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("RemoveVideoSourceConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveVideoSourceConfigurationResponse
    {
    }

    [XmlRoot("AddAudioEncoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddAudioEncoderConfigurationRequest : ProfileConfigurationRequestBase
    {
    }
    [XmlRoot("AddAudioEncoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddAudioEncoderConfigurationResponse
    {
    }
    [XmlRoot("RemoveAudioEncoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveAudioEncoderConfigurationRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("RemoveAudioEncoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveAudioEncoderConfigurationResponse
    {
    }

    [XmlRoot("AddAudioSourceConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddAudioSourceConfigurationRequest : ProfileConfigurationRequestBase
    {
    }
    [XmlRoot("AddAudioSourceConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddAudioSourceConfigurationResponse
    {
    }
    [XmlRoot("RemoveAudioSourceConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveAudioSourceConfigurationRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("RemoveAudioSourceConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveAudioSourceConfigurationResponse
    {
    }

    [XmlRoot("AddPTZConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddPTZConfigurationRequest : ProfileConfigurationRequestBase
    {
    }
    [XmlRoot("AddPTZConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddPTZConfigurationResponse
    {
    }
    [XmlRoot("RemovePTZConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemovePTZConfigurationRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("RemovePTZConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemovePTZConfigurationResponse
    {
    }

    [XmlRoot("AddVideoAnalyticsConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddVideoAnalyticsConfigurationRequest : ProfileConfigurationRequestBase
    {
    }
    [XmlRoot("AddVideoAnalyticsConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddVideoAnalyticsConfigurationResponse
    {
    }
    [XmlRoot("RemoveVideoAnalyticsConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveVideoAnalyticsConfigurationRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("RemoveVideoAnalyticsConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveVideoAnalyticsConfigurationResponse
    {
    }

    [XmlRoot("AddMetadataConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddMetadataConfigurationRequest : ProfileConfigurationRequestBase
    {
    }
    [XmlRoot("AddMetadataConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddMetadataConfigurationResponse
    {
    }
    [XmlRoot("RemoveMetadataConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveMetadataConfigurationRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("RemoveMetadataConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveMetadataConfigurationResponse
    {
    }

    [XmlRoot("AddAudioOutputConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddAudioOutputConfigurationRequest : ProfileConfigurationRequestBase
    {
    }
    [XmlRoot("AddAudioOutputConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddAudioOutputConfigurationResponse
    {
    }
    [XmlRoot("RemoveAudioOutputConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveAudioOutputConfigurationRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("RemoveAudioOutputConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveAudioOutputConfigurationResponse
    {
    }

    [XmlRoot("AddAudioDecoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddAudioDecoderConfigurationRequest : ProfileConfigurationRequestBase
    {
    }
    [XmlRoot("AddAudioDecoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class AddAudioDecoderConfigurationResponse
    {
    }
    [XmlRoot("RemoveAudioDecoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveAudioDecoderConfigurationRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("RemoveAudioDecoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class RemoveAudioDecoderConfigurationResponse
    {
    }

    [XmlRoot("GetVideoSourceConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoSourceConfigurationsRequest
    {
    }
    [XmlRoot("GetVideoSourceConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoSourceConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoSourceConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetVideoEncoderConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoEncoderConfigurationsRequest
    {
    }
    [XmlRoot("GetVideoEncoderConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoEncoderConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoEncoderConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetAudioSourceConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioSourceConfigurationsRequest
    {
    }
    [XmlRoot("GetAudioSourceConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioSourceConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioSourceConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetAudioEncoderConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioEncoderConfigurationsRequest
    {
    }
    [XmlRoot("GetAudioEncoderConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioEncoderConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioEncoderConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetVideoAnalyticsConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoAnalyticsConfigurationsRequest
    {
    }
    [XmlRoot("GetVideoAnalyticsConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoAnalyticsConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoAnalyticsConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetMetadataConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetMetadataConfigurationsRequest
    {
    }
    [XmlRoot("GetMetadataConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetMetadataConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public MetadataConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetAudioOutputConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioOutputConfigurationsRequest
    {
    }
    [XmlRoot("GetAudioOutputConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioOutputConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioOutputConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetAudioDecoderConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioDecoderConfigurationsRequest
    {
    }
    [XmlRoot("GetAudioDecoderConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioDecoderConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioDecoderConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetVideoSourceConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoSourceConfigurationRequest : ConfigurationTokenRequestBase
    {
    }
    [XmlRoot("GetVideoSourceConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoSourceConfigurationResponse
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoSourceConfiguration Configuration { get; set; }
    }

    [XmlRoot("GetVideoEncoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoEncoderConfigurationRequest : ConfigurationTokenRequestBase
    {
    }
    [XmlRoot("GetVideoEncoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoEncoderConfigurationResponse
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoEncoderConfiguration Configuration { get; set; }
    }

    [XmlRoot("GetAudioSourceConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioSourceConfigurationRequest : ConfigurationTokenRequestBase
    {
    }
    [XmlRoot("GetAudioSourceConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioSourceConfigurationResponse
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioSourceConfiguration Configuration { get; set; }
    }

    [XmlRoot("GetAudioEncoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioEncoderConfigurationRequest : ConfigurationTokenRequestBase
    {
    }
    [XmlRoot("GetAudioEncoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioEncoderConfigurationResponse
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioEncoderConfiguration Configuration { get; set; }
    }

    [XmlRoot("GetVideoAnalyticsConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoAnalyticsConfigurationRequest : ConfigurationTokenRequestBase
    {
    }
    [XmlRoot("GetVideoAnalyticsConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoAnalyticsConfigurationResponse
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoAnalyticsConfiguration Configuration { get; set; }
    }

    [XmlRoot("GetMetadataConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetMetadataConfigurationRequest : ConfigurationTokenRequestBase
    {
    }
    [XmlRoot("GetMetadataConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetMetadataConfigurationResponse
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public MetadataConfiguration Configuration { get; set; }
    }

    [XmlRoot("GetAudioOutputConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioOutputConfigurationRequest : ConfigurationTokenRequestBase
    {
    }
    [XmlRoot("GetAudioOutputConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioOutputConfigurationResponse
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioOutputConfiguration Configuration { get; set; }
    }

    [XmlRoot("GetAudioDecoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioDecoderConfigurationRequest : ConfigurationTokenRequestBase
    {
    }
    [XmlRoot("GetAudioDecoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioDecoderConfigurationResponse
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioDecoderConfiguration Configuration { get; set; }
    }

    [XmlRoot("GetCompatibleVideoEncoderConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleVideoEncoderConfigurationsRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("GetCompatibleVideoEncoderConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleVideoEncoderConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoEncoderConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetCompatibleVideoSourceConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleVideoSourceConfigurationsRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("GetCompatibleVideoSourceConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleVideoSourceConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoSourceConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetCompatibleAudioEncoderConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleAudioEncoderConfigurationsRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("GetCompatibleAudioEncoderConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleAudioEncoderConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioEncoderConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetCompatibleAudioSourceConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleAudioSourceConfigurationsRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("GetCompatibleAudioSourceConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleAudioSourceConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioSourceConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetCompatibleVideoAnalyticsConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleVideoAnalyticsConfigurationsRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("GetCompatibleVideoAnalyticsConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleVideoAnalyticsConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoAnalyticsConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetCompatibleMetadataConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleMetadataConfigurationsRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("GetCompatibleMetadataConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleMetadataConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public MetadataConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetCompatibleAudioOutputConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleAudioOutputConfigurationsRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("GetCompatibleAudioOutputConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleAudioOutputConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioOutputConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("GetCompatibleAudioDecoderConfigurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleAudioDecoderConfigurationsRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("GetCompatibleAudioDecoderConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetCompatibleAudioDecoderConfigurationsResponse
    {
        [XmlElement("Configurations", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioDecoderConfiguration[] Configurations { get; set; }
    }

    [XmlRoot("SetVideoSourceConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetVideoSourceConfigurationRequest : SetConfigurationRequestBase
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoSourceConfiguration Configuration { get; set; }
    }
    [XmlRoot("SetVideoSourceConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetVideoSourceConfigurationResponse
    {
    }

    [XmlRoot("SetVideoEncoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetVideoEncoderConfigurationRequest : SetConfigurationRequestBase
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoEncoderConfiguration Configuration { get; set; }
    }
    [XmlRoot("SetVideoEncoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetVideoEncoderConfigurationResponse
    {
    }

    [XmlRoot("SetAudioSourceConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetAudioSourceConfigurationRequest : SetConfigurationRequestBase
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioSourceConfiguration Configuration { get; set; }
    }
    [XmlRoot("SetAudioSourceConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetAudioSourceConfigurationResponse
    {
    }

    [XmlRoot("SetAudioEncoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetAudioEncoderConfigurationRequest : SetConfigurationRequestBase
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioEncoderConfiguration Configuration { get; set; }
    }
    [XmlRoot("SetAudioEncoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetAudioEncoderConfigurationResponse
    {
    }

    [XmlRoot("SetVideoAnalyticsConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetVideoAnalyticsConfigurationRequest : SetConfigurationRequestBase
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoAnalyticsConfiguration Configuration { get; set; }
    }
    [XmlRoot("SetVideoAnalyticsConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetVideoAnalyticsConfigurationResponse
    {
    }

    [XmlRoot("SetMetadataConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetMetadataConfigurationRequest : SetConfigurationRequestBase
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public MetadataConfiguration Configuration { get; set; }
    }
    [XmlRoot("SetMetadataConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetMetadataConfigurationResponse
    {
    }

    [XmlRoot("SetAudioOutputConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetAudioOutputConfigurationRequest : SetConfigurationRequestBase
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioOutputConfiguration Configuration { get; set; }
    }
    [XmlRoot("SetAudioOutputConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetAudioOutputConfigurationResponse
    {
    }

    [XmlRoot("SetAudioDecoderConfiguration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetAudioDecoderConfigurationRequest : SetConfigurationRequestBase
    {
        [XmlElement("Configuration", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioDecoderConfiguration Configuration { get; set; }
    }
    [XmlRoot("SetAudioDecoderConfigurationResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetAudioDecoderConfigurationResponse
    {
    }

    [XmlRoot("GetVideoSourceConfigurationOptions", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoSourceConfigurationOptionsRequest : ConfigurationOptionsRequestBase
    {
    }
    [XmlRoot("GetVideoSourceConfigurationOptionsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoSourceConfigurationOptionsResponse
    {
        [XmlElement("Options", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoSourceConfigurationOptions Options { get; set; }
    }

    [XmlRoot("GetVideoEncoderConfigurationOptions", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoEncoderConfigurationOptionsRequest : ConfigurationOptionsRequestBase
    {
    }
    [XmlRoot("GetVideoEncoderConfigurationOptionsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoEncoderConfigurationOptionsResponse
    {
        [XmlElement("Options", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoEncoderConfigurationOptions Options { get; set; }
    }

    [XmlRoot("GetAudioSourceConfigurationOptions", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioSourceConfigurationOptionsRequest : ConfigurationOptionsRequestBase
    {
    }
    [XmlRoot("GetAudioSourceConfigurationOptionsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioSourceConfigurationOptionsResponse
    {
        [XmlElement("Options", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioSourceConfigurationOptions Options { get; set; }
    }

    [XmlRoot("GetAudioEncoderConfigurationOptions", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioEncoderConfigurationOptionsRequest : ConfigurationOptionsRequestBase
    {
    }
    [XmlRoot("GetAudioEncoderConfigurationOptionsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioEncoderConfigurationOptionsResponse
    {
        [XmlElement("Options", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioEncoderConfigurationOptions Options { get; set; }
    }

    [XmlRoot("GetMetadataConfigurationOptions", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetMetadataConfigurationOptionsRequest : ConfigurationOptionsRequestBase
    {
    }
    [XmlRoot("GetMetadataConfigurationOptionsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetMetadataConfigurationOptionsResponse
    {
        [XmlElement("Options", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public MetadataConfigurationOptions Options { get; set; }
    }

    [XmlRoot("GetAudioOutputConfigurationOptions", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioOutputConfigurationOptionsRequest : ConfigurationOptionsRequestBase
    {
    }
    [XmlRoot("GetAudioOutputConfigurationOptionsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioOutputConfigurationOptionsResponse
    {
        [XmlElement("Options", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioOutputConfigurationOptions Options { get; set; }
    }

    [XmlRoot("GetAudioDecoderConfigurationOptions", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioDecoderConfigurationOptionsRequest : ConfigurationOptionsRequestBase
    {
    }
    [XmlRoot("GetAudioDecoderConfigurationOptionsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetAudioDecoderConfigurationOptionsResponse
    {
        [XmlElement("Options", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public AudioDecoderConfigurationOptions Options { get; set; }
    }

    [XmlRoot("GetGuaranteedNumberOfVideoEncoderInstances", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetGuaranteedNumberOfVideoEncoderInstancesRequest : ConfigurationTokenRequestBase
    {
    }
    [XmlRoot("GetGuaranteedNumberOfVideoEncoderInstancesResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetGuaranteedNumberOfVideoEncoderInstancesResponse
    {
        [XmlElement("TotalNumber", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public int TotalNumber { get; set; }
    }

    [XmlRoot("GetStreamUri", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetStreamUriRequest
    {
        [XmlElement("StreamSetup", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public StreamSetup StreamSetup { get; set; }

        [XmlElement("ProfileToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string ProfileToken { get; set; }
    }
    [XmlRoot("GetStreamUriResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetStreamUriResponse
    {
        [XmlElement("MediaUri", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public MediaUri MediaUri { get; set; }
    }

    [XmlRoot("StartMulticastStreaming", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class StartMulticastStreamingRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("StartMulticastStreamingResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class StartMulticastStreamingResponse
    {
    }

    [XmlRoot("StopMulticastStreaming", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class StopMulticastStreamingRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("StopMulticastStreamingResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class StopMulticastStreamingResponse
    {
    }

    [XmlRoot("SetSynchronizationPoint", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetSynchronizationPointRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("SetSynchronizationPointResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetSynchronizationPointResponse
    {
    }

    [XmlRoot("GetSnapshotUri", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetSnapshotUriRequest : ProfileTokenRequestBase
    {
    }
    [XmlRoot("GetSnapshotUriResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetSnapshotUriResponse
    {
        [XmlElement("MediaUri", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public MediaUri MediaUri { get; set; }
    }

    [XmlRoot("GetVideoSourceModes", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoSourceModesRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string VideoSourceToken { get; set; }
    }
    [XmlRoot("GetVideoSourceModesResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetVideoSourceModesResponse
    {
        [XmlElement("VideoSourceModes", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoSourceMode[] VideoSourceModes { get; set; }
    }

    [XmlRoot("SetVideoSourceMode", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetVideoSourceModeRequest
    {
        [XmlElement("VideoSourceToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string VideoSourceToken { get; set; }

        [XmlElement("VideoSourceModeToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string VideoSourceModeToken { get; set; }
    }
    [XmlRoot("SetVideoSourceModeResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetVideoSourceModeResponse
    {
    }

    [XmlRoot("GetOSDs", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetOSDsRequest
    {
        [XmlElement("VideoSourceConfigurationToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string VideoSourceConfigurationToken { get; set; }
    }
    [XmlRoot("GetOSDsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetOSDsResponse
    {
        [XmlElement("OSDs", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public OSDConfiguration[] OSDs { get; set; }
    }

    [XmlRoot("GetOSD", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetOSDRequest
    {
        [XmlElement("OSDToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string OSDToken { get; set; }
    }
    [XmlRoot("GetOSDResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetOSDResponse
    {
        [XmlElement("OSD", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public OSDConfiguration OSD { get; set; }
    }

    [XmlRoot("GetOSDOptions", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetOSDOptionsRequest
    {
        [XmlElement("ConfigurationToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string ConfigurationToken { get; set; }
    }
    [XmlRoot("GetOSDOptionsResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class GetOSDOptionsResponse
    {
        [XmlElement("OSDOptions", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public OSDConfigurationOptions OSDOptions { get; set; }
    }

    [XmlRoot("SetOSD", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetOSDRequest
    {
        [XmlElement("OSD", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public OSDConfiguration OSD { get; set; }
    }
    [XmlRoot("SetOSDResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class SetOSDResponse
    {
    }

    [XmlRoot("CreateOSD", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class CreateOSDRequest
    {
        [XmlElement("OSD", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public OSDConfiguration OSD { get; set; }
    }
    [XmlRoot("CreateOSDResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class CreateOSDResponse
    {
        [XmlElement("OSDToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string OSDToken { get; set; }
    }

    [XmlRoot("DeleteOSD", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class DeleteOSDRequest
    {
        [XmlElement("OSDToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string OSDToken { get; set; }
    }
    [XmlRoot("DeleteOSDResponse", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public class DeleteOSDResponse
    {
    }

    public class DeviceEntity
    {
        [XmlAttribute("token")]
        public string Token { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
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

    public class VideoSource : DeviceEntity
    {
        [XmlElement("Framerate", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Framerate { get; set; }

        [XmlElement("Resolution", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoResolution Resolution { get; set; }

        [XmlElement("Imaging", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImagingSettings Imaging { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoSourceExtension Extension { get; set; }
    }

    public class AudioSource : DeviceEntity
    {
        [XmlElement("Channels", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Channels { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class AudioOutput : DeviceEntity
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class MediaProfile
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name { get; set; }

        [XmlElement("VideoSourceConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoSourceConfiguration VideoSourceConfiguration { get; set; }

        [XmlElement("AudioSourceConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public AudioSourceConfiguration AudioSourceConfiguration { get; set; }

        [XmlElement("VideoEncoderConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoEncoderConfiguration VideoEncoderConfiguration { get; set; }

        [XmlElement("AudioEncoderConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public AudioEncoderConfiguration AudioEncoderConfiguration { get; set; }

        [XmlElement("VideoAnalyticsConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoAnalyticsConfiguration VideoAnalyticsConfiguration { get; set; }

        [XmlElement("MetadataConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public MetadataConfiguration MetadataConfiguration { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public ProfileExtension Extension { get; set; }

        [XmlAttribute("token")]
        public string Token { get; set; }

        [XmlAttribute("fixed")]
        public string Fixed { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ProfileExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("AudioOutputConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public AudioOutputConfiguration AudioOutputConfiguration { get; set; }

        [XmlElement("AudioDecoderConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public AudioDecoderConfiguration AudioDecoderConfiguration { get; set; }
    }

    public class VideoSourceConfiguration : ConfigurationEntity
    {
        [XmlElement("SourceToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public string SourceToken { get; set; }

        [XmlElement("Bounds", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRectangle Bounds { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoSourceConfigurationExtension Extension { get; set; }

        [XmlAttribute("ViewMode")]
        public string ViewMode { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class VideoEncoderConfiguration : ConfigurationEntity
    {
        [XmlElement("Encoding", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Encoding { get; set; }

        [XmlElement("Resolution", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoResolution Resolution { get; set; }

        [XmlElement("Quality", Namespace = "http://www.onvif.org/ver10/schema")]
        public float Quality { get; set; }

        [XmlElement("RateControl", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoRateControl RateControl { get; set; }

        [XmlElement("MPEG4", Namespace = "http://www.onvif.org/ver10/schema")]
        public Mpeg4Configuration MPEG4 { get; set; }

        [XmlElement("H264", Namespace = "http://www.onvif.org/ver10/schema")]
        public H264Configuration H264 { get; set; }

        [XmlElement("Multicast", Namespace = "http://www.onvif.org/ver10/schema")]
        public MulticastConfiguration Multicast { get; set; }

        [XmlElement("SessionTimeout", Namespace = "http://www.onvif.org/ver10/schema")]
        public string SessionTimeout { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAttribute("GuaranteedFrameRate")]
        public string GuaranteedFrameRate { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class AudioSourceConfiguration : ConfigurationEntity
    {
        [XmlElement("SourceToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public string SourceToken { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class AudioEncoderConfiguration : ConfigurationEntity
    {
        [XmlElement("Encoding", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Encoding { get; set; }

        [XmlElement("Bitrate", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Bitrate { get; set; }

        [XmlElement("SampleRate", Namespace = "http://www.onvif.org/ver10/schema")]
        public int SampleRate { get; set; }

        [XmlElement("Multicast", Namespace = "http://www.onvif.org/ver10/schema")]
        public MulticastConfiguration Multicast { get; set; }

        [XmlElement("SessionTimeout", Namespace = "http://www.onvif.org/ver10/schema")]
        public string SessionTimeout { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class VideoAnalyticsConfiguration : ConfigurationEntity
    {
        [XmlElement("AnalyticsEngineConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public AnalyticsEngineConfiguration AnalyticsEngineConfiguration { get; set; }

        [XmlElement("RuleEngineConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public RuleEngineConfiguration RuleEngineConfiguration { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class MetadataConfiguration : ConfigurationEntity
    {
        [XmlElement("PTZStatus", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZFilter PTZStatus { get; set; }

        [XmlElement("Events", Namespace = "http://www.onvif.org/ver10/schema")]
        public EventSubscription Events { get; set; }

        [XmlElement("Analytics", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? Analytics { get; set; }

        [XmlElement("Multicast", Namespace = "http://www.onvif.org/ver10/schema")]
        public MulticastConfiguration Multicast { get; set; }

        [XmlElement("SessionTimeout", Namespace = "http://www.onvif.org/ver10/schema")]
        public string SessionTimeout { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("AnalyticsEngineConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public AnalyticsEngineConfiguration AnalyticsEngineConfiguration { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public MetadataConfigurationExtension Extension { get; set; }

        [XmlAttribute("CompressionType")]
        public string CompressionType { get; set; }

        [XmlAttribute("GeoLocation")]
        public string GeoLocation { get; set; }

        [XmlAttribute("ShapePolygon")]
        public string ShapePolygon { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class AudioOutputConfiguration : ConfigurationEntity
    {
        [XmlElement("OutputToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public string OutputToken { get; set; }

        [XmlElement("SendPrimacy", Namespace = "http://www.onvif.org/ver10/schema")]
        public string SendPrimacy { get; set; }

        [XmlElement("OutputLevel", Namespace = "http://www.onvif.org/ver10/schema")]
        public int OutputLevel { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class AudioDecoderConfiguration : ConfigurationEntity
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class VideoSourceConfigurationOptions
    {
        [XmlElement("BoundsRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRectangleRange BoundsRange { get; set; }

        [XmlElement("VideoSourceTokensAvailable", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] VideoSourceTokensAvailable { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoSourceConfigurationOptionsExtension Extension { get; set; }

        [XmlAttribute("MaximumNumberOfProfiles")]
        public string MaximumNumberOfProfiles { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class VideoEncoderConfigurationOptions
    {
        [XmlElement("QualityRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange QualityRange { get; set; }

        [XmlElement("JPEG", Namespace = "http://www.onvif.org/ver10/schema")]
        public JpegOptions JPEG { get; set; }

        [XmlElement("MPEG4", Namespace = "http://www.onvif.org/ver10/schema")]
        public Mpeg4Options MPEG4 { get; set; }

        [XmlElement("H264", Namespace = "http://www.onvif.org/ver10/schema")]
        public H264Options H264 { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoEncoderOptionsExtension Extension { get; set; }

        [XmlAttribute("GuaranteedFrameRateSupported")]
        public string GuaranteedFrameRateSupported { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class AudioSourceConfigurationOptions
    {
        [XmlElement("InputTokensAvailable", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] InputTokensAvailable { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public AudioSourceOptionsExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class AudioEncoderConfigurationOptions
    {
        [XmlElement("Options", Namespace = "http://www.onvif.org/ver10/schema")]
        public AudioEncoderConfigurationOption[] Options { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class MetadataConfigurationOptions
    {
        [XmlElement("PTZStatusFilterOptions", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZStatusFilterOptions PTZStatusFilterOptions { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public MetadataConfigurationOptionsExtension Extension { get; set; }

        [XmlAttribute("GeoLocation")]
        public string GeoLocation { get; set; }

        [XmlAttribute("MaxContentFilterSize")]
        public string MaxContentFilterSize { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class AudioOutputConfigurationOptions
    {
        [XmlElement("OutputTokensAvailable", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] OutputTokensAvailable { get; set; }

        [XmlElement("SendPrimacyOptions", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] SendPrimacyOptions { get; set; }

        [XmlElement("OutputLevelRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange OutputLevelRange { get; set; }

        [XmlElement("EQPresetScheduleSupport", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? EQPresetScheduleSupport { get; set; }

        [XmlElement("EQPresets", Namespace = "http://www.onvif.org/ver10/schema")]
        public EQPreset[] EQPresets { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class AudioDecoderConfigurationOptions
    {
        [XmlElement("AACDecOptions", Namespace = "http://www.onvif.org/ver10/schema")]
        public AACDecOptions AACDecOptions { get; set; }

        [XmlElement("G711DecOptions", Namespace = "http://www.onvif.org/ver10/schema")]
        public G711DecOptions G711DecOptions { get; set; }

        [XmlElement("G726DecOptions", Namespace = "http://www.onvif.org/ver10/schema")]
        public G726DecOptions G726DecOptions { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public AudioDecoderConfigurationOptionsExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class StreamSetup
    {
        [XmlElement("Stream", Namespace = "http://www.onvif.org/ver10/schema")]
        public StreamType Stream { get; set; }

        [XmlElement("Transport", Namespace = "http://www.onvif.org/ver10/schema")]
        public Transport Transport { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class MediaUri
    {
        [XmlElement("Uri", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Uri { get; set; }

        [XmlElement("InvalidAfterConnect", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool InvalidAfterConnect { get; set; }

        [XmlElement("InvalidAfterReboot", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool InvalidAfterReboot { get; set; }

        [XmlElement("Timeout", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Timeout { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum StreamType
    {
        [XmlEnum("RTP-Unicast")]
        RTPUnicast,

        [XmlEnum("RTP-Multicast")]
        RTPMulticast,
    }

    public class Transport
    {
        [XmlElement("Protocol", Namespace = "http://www.onvif.org/ver10/schema")]
        public TransportProtocol Protocol { get; set; }

        [XmlElement("Tunnel", Namespace = "http://www.onvif.org/ver10/schema")]
        public Transport Tunnel { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum TransportProtocol
    {
        UDP,
        TCP,
        RTSP,
        HTTP,
    }

    public class VideoSourceMode
    {
        [XmlElement("MaxFramerate", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public float MaxFramerate { get; set; }

        [XmlElement("MaxResolution", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoResolution MaxResolution { get; set; }

        [XmlElement("Encodings", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string[] Encodings { get; set; }

        [XmlElement("Reboot", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public bool Reboot { get; set; }

        [XmlElement("Description", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string Description { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public VideoSourceModeExtension Extension { get; set; }

        [XmlAttribute("token")]
        public string Token { get; set; }

        [XmlAttribute("Enabled")]
        public string Enabled { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class OSDConfiguration : DeviceEntity
    {
        [XmlElement("VideoSourceConfigurationToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public string VideoSourceConfigurationToken { get; set; }

        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Type { get; set; }

        [XmlElement("Position", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDPosConfiguration Position { get; set; }

        [XmlElement("TextString", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDTextConfiguration TextString { get; set; }

        [XmlElement("Image", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDImgConfiguration Image { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDConfigurationExtension Extension { get; set; }
    }

    public class OSDConfigurationOptions
    {
        [XmlElement("MaximumNumberOfOSDs", Namespace = "http://www.onvif.org/ver10/schema")]
        public MaximumNumberOfOSDs MaximumNumberOfOSDs { get; set; }

        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] Type { get; set; }

        [XmlElement("PositionOption", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] PositionOption { get; set; }

        [XmlElement("TextOption", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDTextOptions TextOption { get; set; }

        [XmlElement("ImageOption", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDImgOptions ImageOption { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDConfigurationOptionsExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class IntRectangle
    {
        [XmlAttribute("x")]
        public int X { get; set; }

        [XmlAttribute("y")]
        public int Y { get; set; }

        [XmlAttribute("width")]
        public int Width { get; set; }

        [XmlAttribute("height")]
        public int Height { get; set; }
    }

    public class IntRectangleRange
    {
        [XmlElement("XRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange XRange { get; set; }

        [XmlElement("YRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange YRange { get; set; }

        [XmlElement("WidthRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange WidthRange { get; set; }

        [XmlElement("HeightRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange HeightRange { get; set; }
    }

    public class IntRange
    {
        [XmlElement("Min", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Min { get; set; }

        [XmlElement("Max", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Max { get; set; }
    }

    public class VideoResolution
    {
        [XmlElement("Width", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Width { get; set; }

        [XmlElement("Height", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Height { get; set; }
    }

    public class VideoRateControl
    {
        [XmlElement("FrameRateLimit", Namespace = "http://www.onvif.org/ver10/schema")]
        public int FrameRateLimit { get; set; }

        [XmlElement("EncodingInterval", Namespace = "http://www.onvif.org/ver10/schema")]
        public int EncodingInterval { get; set; }

        [XmlElement("BitrateLimit", Namespace = "http://www.onvif.org/ver10/schema")]
        public int BitrateLimit { get; set; }
    }

    public class Mpeg4Configuration
    {
        [XmlElement("GovLength", Namespace = "http://www.onvif.org/ver10/schema")]
        public int GovLength { get; set; }

        [XmlElement("Mpeg4Profile", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Mpeg4Profile { get; set; }
    }

    public class H264Configuration
    {
        [XmlElement("GovLength", Namespace = "http://www.onvif.org/ver10/schema")]
        public int GovLength { get; set; }

        [XmlElement("H264Profile", Namespace = "http://www.onvif.org/ver10/schema")]
        public string H264Profile { get; set; }
    }

    public class MulticastConfiguration
    {
        [XmlElement("Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public IPAddress Address { get; set; }

        [XmlElement("Port", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Port { get; set; }

        [XmlElement("TTL", Namespace = "http://www.onvif.org/ver10/schema")]
        public int TTL { get; set; }

        [XmlElement("AutoStart", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool AutoStart { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class IPAddress
    {
        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/schema")]
        public IPType Type { get; set; }

        [XmlElement("IPv4Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public string IPv4Address { get; set; }

        [XmlElement("IPv6Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public string IPv6Address { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum IPType
    {
        IPv4,
        IPv6,
    }

    public class VideoSourceExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
    public class ImagingSettings
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
    public class VideoSourceConfigurationExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
    public class VideoSourceConfigurationOptionsExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
    public class AudioSourceOptionsExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
    public class VideoEncoderOptionsExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
    public class MetadataConfigurationExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
    public class MetadataConfigurationOptionsExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
    public class AudioDecoderConfigurationOptionsExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
    public class AnalyticsEngineConfiguration
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
    public class RuleEngineConfiguration
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class PTZFilter
    {
        [XmlElement("Status", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool Status { get; set; }

        [XmlElement("Position", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool Position { get; set; }

        [XmlElement("FieldOfView", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? FieldOfView { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class EventSubscription
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class PTZStatusFilterOptions
    {
        [XmlElement("PanTiltStatusSupported", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool PanTiltStatusSupported { get; set; }

        [XmlElement("ZoomStatusSupported", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool ZoomStatusSupported { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("PanTiltPositionSupported", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? PanTiltPositionSupported { get; set; }

        [XmlElement("ZoomPositionSupported", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? ZoomPositionSupported { get; set; }

        [XmlElement("FieldOfViewSupported", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? FieldOfViewSupported { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class AudioEncoderConfigurationOption
    {
        [XmlElement("Encoding", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Encoding { get; set; }

        [XmlElement("BitrateList", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntItems BitrateList { get; set; }

        [XmlElement("SampleRateList", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntItems SampleRateList { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class IntItems
    {
        [XmlElement("Items", Namespace = "http://www.onvif.org/ver10/schema")]
        public int[] Items { get; set; }
    }

    public class AACDecOptions
    {
        [XmlElement("Bitrate", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntItems Bitrate { get; set; }

        [XmlElement("SampleRateRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntItems SampleRateRange { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class G711DecOptions
    {
        [XmlElement("Bitrate", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntItems Bitrate { get; set; }

        [XmlElement("SampleRateRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntItems SampleRateRange { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class G726DecOptions
    {
        [XmlElement("Bitrate", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntItems Bitrate { get; set; }

        [XmlElement("SampleRateRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntItems SampleRateRange { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class JpegOptions
    {
        [XmlElement("ResolutionsAvailable", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoResolution[] ResolutionsAvailable { get; set; }

        [XmlElement("FrameRateRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange FrameRateRange { get; set; }

        [XmlElement("EncodingIntervalRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange EncodingIntervalRange { get; set; }
    }
    public class Mpeg4Options
    {
        [XmlElement("ResolutionsAvailable", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoResolution[] ResolutionsAvailable { get; set; }

        [XmlElement("GovLengthRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange GovLengthRange { get; set; }

        [XmlElement("FrameRateRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange FrameRateRange { get; set; }

        [XmlElement("EncodingIntervalRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange EncodingIntervalRange { get; set; }

        [XmlElement("Mpeg4ProfilesSupported", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] Mpeg4ProfilesSupported { get; set; }
    }
    public class H264Options
    {
        [XmlElement("ResolutionsAvailable", Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoResolution[] ResolutionsAvailable { get; set; }

        [XmlElement("GovLengthRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange GovLengthRange { get; set; }

        [XmlElement("FrameRateRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange FrameRateRange { get; set; }

        [XmlElement("EncodingIntervalRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange EncodingIntervalRange { get; set; }

        [XmlElement("H264ProfilesSupported", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] H264ProfilesSupported { get; set; }
    }

    public class EQPreset
    {
        [XmlElement("Token", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Token { get; set; }

        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name { get; set; }

        [XmlElement("isDefault", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool IsDefault { get; set; }

        [XmlElement("ScheduleToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public string ScheduleToken { get; set; }

        [XmlElement("isFrequencyDecibelEditable", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool IsFrequencyDecibelEditable { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class OSDPosConfiguration
    {
        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Type { get; set; }

        [XmlElement("Pos", Namespace = "http://www.onvif.org/ver10/schema")]
        public Vector Pos { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDPosConfigurationExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class OSDTextConfiguration
    {
        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Type { get; set; }

        [XmlElement("DateFormat", Namespace = "http://www.onvif.org/ver10/schema")]
        public string DateFormat { get; set; }

        [XmlElement("TimeFormat", Namespace = "http://www.onvif.org/ver10/schema")]
        public string TimeFormat { get; set; }

        [XmlElement("FontSize", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? FontSize { get; set; }

        [XmlElement("FontColor", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDColor FontColor { get; set; }

        [XmlElement("BackgroundColor", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDColor BackgroundColor { get; set; }

        [XmlElement("PlainText", Namespace = "http://www.onvif.org/ver10/schema")]
        public string PlainText { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDTextConfigurationExtension Extension { get; set; }

        [XmlAttribute("IsPersistentText")]
        public string IsPersistentText { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class OSDImgConfiguration
    {
        [XmlElement("ImgPath", Namespace = "http://www.onvif.org/ver10/schema")]
        public string ImgPath { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDImgConfigurationExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class MaximumNumberOfOSDs
    {
        [XmlAttribute("Total")]
        public int Total { get; set; }

        [XmlAttribute("Image")]
        public int Image { get; set; }

        [XmlAttribute("PlainText")]
        public int PlainText { get; set; }

        [XmlAttribute("Date")]
        public int Date { get; set; }

        [XmlAttribute("Time")]
        public int Time { get; set; }

        [XmlAttribute("DateAndTime")]
        public int DateAndTime { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class OSDTextOptions
    {
        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] Type { get; set; }

        [XmlElement("FontSizeRange", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange FontSizeRange { get; set; }

        [XmlElement("DateFormat", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] DateFormat { get; set; }

        [XmlElement("TimeFormat", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] TimeFormat { get; set; }

        [XmlElement("FontColor", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDColorOptions FontColor { get; set; }

        [XmlElement("BackgroundColor", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDColorOptions BackgroundColor { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDTextOptionsExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class OSDImgOptions
    {
        [XmlElement("ImagePath", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] ImagePath { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDImgOptionsExtension Extension { get; set; }

        [XmlAttribute("FormatsSupported")]
        public string FormatsSupported { get; set; }

        [XmlAttribute("MaxSize")]
        public string MaxSize { get; set; }

        [XmlAttribute("MaxWidth")]
        public string MaxWidth { get; set; }

        [XmlAttribute("MaxHeight")]
        public string MaxHeight { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class OSDColor
    {
        [XmlElement("Color", Namespace = "http://www.onvif.org/ver10/schema")]
        public Color Color { get; set; }

        [XmlAttribute("Transparent")]
        public string Transparent { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class OSDColorOptions
    {
        [XmlElement("Color", Namespace = "http://www.onvif.org/ver10/schema")]
        public ColorOptions Color { get; set; }

        [XmlElement("Transparent", Namespace = "http://www.onvif.org/ver10/schema")]
        public IntRange Transparent { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public OSDColorOptionsExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ColorOptions
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class Color
    {
        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class Vector
    {
        [XmlAttribute("x")]
        public float X { get; set; }

        [XmlAttribute("y")]
        public float Y { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class VideoSourceModeExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
    public class OSDConfigurationExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class OSDConfigurationOptionsExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class OSDPosConfigurationExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class OSDTextConfigurationExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class OSDImgConfigurationExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class OSDTextOptionsExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class OSDImgOptionsExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }
    public class OSDColorOptionsExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ProfileTokenRequestBase
    {
        [XmlElement("ProfileToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string ProfileToken { get; set; }
    }

    public class ProfileConfigurationRequestBase : ProfileTokenRequestBase
    {
        [XmlElement("ConfigurationToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string ConfigurationToken { get; set; }
    }

    public class ConfigurationTokenRequestBase
    {
        [XmlElement("ConfigurationToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string ConfigurationToken { get; set; }
    }

    public class ConfigurationOptionsRequestBase
    {
        [XmlElement("ConfigurationToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string ConfigurationToken { get; set; }

        [XmlElement("ProfileToken", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public string ProfileToken { get; set; }
    }

    public class SetConfigurationRequestBase
    {
        [XmlElement("ForcePersistence", Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public bool? ForcePersistence { get; set; }
    }
}