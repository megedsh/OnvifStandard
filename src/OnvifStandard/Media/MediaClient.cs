using System.Threading.Tasks;

namespace OnvifStandard.Media
{
    public class MediaClient : OnvifSoapClientBase
    {
        public Task<GetServiceCapabilitiesResponse> GetServiceCapabilities() => send<GetServiceCapabilitiesRequest, GetServiceCapabilitiesResponse>(new GetServiceCapabilitiesRequest());
        public Task<GetVideoSourcesResponse>        GetVideoSources()        => send<GetVideoSourcesRequest, GetVideoSourcesResponse>(new GetVideoSourcesRequest());
        public Task<GetAudioSourcesResponse>        GetAudioSources()        => send<GetAudioSourcesRequest, GetAudioSourcesResponse>(new GetAudioSourcesRequest());
        public Task<GetAudioOutputsResponse>        GetAudioOutputs()        => send<GetAudioOutputsRequest, GetAudioOutputsResponse>(new GetAudioOutputsRequest());

        public Task<CreateProfileResponse> CreateProfile(string name, string token = null) =>
            send<CreateProfileRequest, CreateProfileResponse>(new CreateProfileRequest
            {
                Name = name,
                Token = token
            });

        public Task<GetProfileResponse> GetProfile(string profileToken) =>
            send<GetProfileRequest, GetProfileResponse>(new GetProfileRequest
            {
                ProfileToken = profileToken
            });

        public Task<GetProfilesResponse> GetProfiles() => send<GetProfilesRequest, GetProfilesResponse>(new GetProfilesRequest());

        public Task<DeleteProfileResponse> DeleteProfile(string profileToken) =>
            send<DeleteProfileRequest, DeleteProfileResponse>(new DeleteProfileRequest
            {
                ProfileToken = profileToken
            });

        public Task<AddVideoEncoderConfigurationResponse> AddVideoEncoderConfiguration(string profileToken, string configurationToken) =>
            send<AddVideoEncoderConfigurationRequest, AddVideoEncoderConfigurationResponse>(new AddVideoEncoderConfigurationRequest
            {
                ProfileToken = profileToken,
                ConfigurationToken = configurationToken
            });

        public Task<RemoveVideoEncoderConfigurationResponse> RemoveVideoEncoderConfiguration(string profileToken) =>
            send<RemoveVideoEncoderConfigurationRequest, RemoveVideoEncoderConfigurationResponse>(new RemoveVideoEncoderConfigurationRequest
            {
                ProfileToken = profileToken
            });

        public Task<AddVideoSourceConfigurationResponse> AddVideoSourceConfiguration(string profileToken, string configurationToken) =>
            send<AddVideoSourceConfigurationRequest, AddVideoSourceConfigurationResponse>(new AddVideoSourceConfigurationRequest
            {
                ProfileToken = profileToken,
                ConfigurationToken = configurationToken
            });

        public Task<RemoveVideoSourceConfigurationResponse> RemoveVideoSourceConfiguration(string profileToken) =>
            send<RemoveVideoSourceConfigurationRequest, RemoveVideoSourceConfigurationResponse>(new RemoveVideoSourceConfigurationRequest
            {
                ProfileToken = profileToken
            });

        public Task<AddAudioEncoderConfigurationResponse> AddAudioEncoderConfiguration(string profileToken, string configurationToken) =>
            send<AddAudioEncoderConfigurationRequest, AddAudioEncoderConfigurationResponse>(new AddAudioEncoderConfigurationRequest
            {
                ProfileToken = profileToken,
                ConfigurationToken = configurationToken
            });

        public Task<RemoveAudioEncoderConfigurationResponse> RemoveAudioEncoderConfiguration(string profileToken) =>
            send<RemoveAudioEncoderConfigurationRequest, RemoveAudioEncoderConfigurationResponse>(new RemoveAudioEncoderConfigurationRequest
            {
                ProfileToken = profileToken
            });

        public Task<AddAudioSourceConfigurationResponse> AddAudioSourceConfiguration(string profileToken, string configurationToken) =>
            send<AddAudioSourceConfigurationRequest, AddAudioSourceConfigurationResponse>(new AddAudioSourceConfigurationRequest
            {
                ProfileToken = profileToken,
                ConfigurationToken = configurationToken
            });

        public Task<RemoveAudioSourceConfigurationResponse> RemoveAudioSourceConfiguration(string profileToken) =>
            send<RemoveAudioSourceConfigurationRequest, RemoveAudioSourceConfigurationResponse>(new RemoveAudioSourceConfigurationRequest
            {
                ProfileToken = profileToken
            });

        public Task<AddPTZConfigurationResponse> AddPTZConfiguration(string profileToken, string configurationToken) =>
            send<AddPTZConfigurationRequest, AddPTZConfigurationResponse>(new AddPTZConfigurationRequest
            {
                ProfileToken = profileToken,
                ConfigurationToken = configurationToken
            });

        public Task<RemovePTZConfigurationResponse> RemovePTZConfiguration(string profileToken) =>
            send<RemovePTZConfigurationRequest, RemovePTZConfigurationResponse>(new RemovePTZConfigurationRequest
            {
                ProfileToken = profileToken
            });

        public Task<AddVideoAnalyticsConfigurationResponse> AddVideoAnalyticsConfiguration(string profileToken, string configurationToken) =>
            send<AddVideoAnalyticsConfigurationRequest, AddVideoAnalyticsConfigurationResponse>(new AddVideoAnalyticsConfigurationRequest
            {
                ProfileToken = profileToken,
                ConfigurationToken = configurationToken
            });

        public Task<RemoveVideoAnalyticsConfigurationResponse> RemoveVideoAnalyticsConfiguration(string profileToken) =>
            send<RemoveVideoAnalyticsConfigurationRequest, RemoveVideoAnalyticsConfigurationResponse>(new RemoveVideoAnalyticsConfigurationRequest
            {
                ProfileToken = profileToken
            });

        public Task<AddMetadataConfigurationResponse> AddMetadataConfiguration(string profileToken, string configurationToken) =>
            send<AddMetadataConfigurationRequest, AddMetadataConfigurationResponse>(new AddMetadataConfigurationRequest
            {
                ProfileToken = profileToken,
                ConfigurationToken = configurationToken
            });

        public Task<RemoveMetadataConfigurationResponse> RemoveMetadataConfiguration(string profileToken) =>
            send<RemoveMetadataConfigurationRequest, RemoveMetadataConfigurationResponse>(new RemoveMetadataConfigurationRequest
            {
                ProfileToken = profileToken
            });

        public Task<AddAudioOutputConfigurationResponse> AddAudioOutputConfiguration(string profileToken, string configurationToken) =>
            send<AddAudioOutputConfigurationRequest, AddAudioOutputConfigurationResponse>(new AddAudioOutputConfigurationRequest
            {
                ProfileToken = profileToken,
                ConfigurationToken = configurationToken
            });

        public Task<RemoveAudioOutputConfigurationResponse> RemoveAudioOutputConfiguration(string profileToken) =>
            send<RemoveAudioOutputConfigurationRequest, RemoveAudioOutputConfigurationResponse>(new RemoveAudioOutputConfigurationRequest
            {
                ProfileToken = profileToken
            });

        public Task<AddAudioDecoderConfigurationResponse> AddAudioDecoderConfiguration(string profileToken, string configurationToken) =>
            send<AddAudioDecoderConfigurationRequest, AddAudioDecoderConfigurationResponse>(new AddAudioDecoderConfigurationRequest
            {
                ProfileToken = profileToken,
                ConfigurationToken = configurationToken
            });

        public Task<RemoveAudioDecoderConfigurationResponse> RemoveAudioDecoderConfiguration(string profileToken) =>
            send<RemoveAudioDecoderConfigurationRequest, RemoveAudioDecoderConfigurationResponse>(new RemoveAudioDecoderConfigurationRequest
            {
                ProfileToken = profileToken
            });

        public Task<GetVideoSourceConfigurationsResponse>    GetVideoSourceConfigurations()    => send<GetVideoSourceConfigurationsRequest, GetVideoSourceConfigurationsResponse>(new GetVideoSourceConfigurationsRequest());
        public Task<GetVideoEncoderConfigurationsResponse>   GetVideoEncoderConfigurations()   => send<GetVideoEncoderConfigurationsRequest, GetVideoEncoderConfigurationsResponse>(new GetVideoEncoderConfigurationsRequest());
        public Task<GetAudioSourceConfigurationsResponse>    GetAudioSourceConfigurations()    => send<GetAudioSourceConfigurationsRequest, GetAudioSourceConfigurationsResponse>(new GetAudioSourceConfigurationsRequest());
        public Task<GetAudioEncoderConfigurationsResponse>   GetAudioEncoderConfigurations()   => send<GetAudioEncoderConfigurationsRequest, GetAudioEncoderConfigurationsResponse>(new GetAudioEncoderConfigurationsRequest());
        public Task<GetVideoAnalyticsConfigurationsResponse> GetVideoAnalyticsConfigurations() => send<GetVideoAnalyticsConfigurationsRequest, GetVideoAnalyticsConfigurationsResponse>(new GetVideoAnalyticsConfigurationsRequest());
        public Task<GetMetadataConfigurationsResponse>       GetMetadataConfigurations()       => send<GetMetadataConfigurationsRequest, GetMetadataConfigurationsResponse>(new GetMetadataConfigurationsRequest());
        public Task<GetAudioOutputConfigurationsResponse>    GetAudioOutputConfigurations()    => send<GetAudioOutputConfigurationsRequest, GetAudioOutputConfigurationsResponse>(new GetAudioOutputConfigurationsRequest());
        public Task<GetAudioDecoderConfigurationsResponse>   GetAudioDecoderConfigurations()   => send<GetAudioDecoderConfigurationsRequest, GetAudioDecoderConfigurationsResponse>(new GetAudioDecoderConfigurationsRequest());

        public Task<GetVideoSourceConfigurationResponse> GetVideoSourceConfiguration(string configurationToken) =>
            send<GetVideoSourceConfigurationRequest, GetVideoSourceConfigurationResponse>(new GetVideoSourceConfigurationRequest
            {
                ConfigurationToken = configurationToken
            });

        public Task<GetVideoEncoderConfigurationResponse> GetVideoEncoderConfiguration(string configurationToken) =>
            send<GetVideoEncoderConfigurationRequest, GetVideoEncoderConfigurationResponse>(new GetVideoEncoderConfigurationRequest
            {
                ConfigurationToken = configurationToken
            });

        public Task<GetAudioSourceConfigurationResponse> GetAudioSourceConfiguration(string configurationToken) =>
            send<GetAudioSourceConfigurationRequest, GetAudioSourceConfigurationResponse>(new GetAudioSourceConfigurationRequest
            {
                ConfigurationToken = configurationToken
            });

        public Task<GetAudioEncoderConfigurationResponse> GetAudioEncoderConfiguration(string configurationToken) =>
            send<GetAudioEncoderConfigurationRequest, GetAudioEncoderConfigurationResponse>(new GetAudioEncoderConfigurationRequest
            {
                ConfigurationToken = configurationToken
            });

        public Task<GetVideoAnalyticsConfigurationResponse> GetVideoAnalyticsConfiguration(string configurationToken) =>
            send<GetVideoAnalyticsConfigurationRequest, GetVideoAnalyticsConfigurationResponse>(new GetVideoAnalyticsConfigurationRequest
            {
                ConfigurationToken = configurationToken
            });

        public Task<GetMetadataConfigurationResponse> GetMetadataConfiguration(string configurationToken) =>
            send<GetMetadataConfigurationRequest, GetMetadataConfigurationResponse>(new GetMetadataConfigurationRequest
            {
                ConfigurationToken = configurationToken
            });

        public Task<GetAudioOutputConfigurationResponse> GetAudioOutputConfiguration(string configurationToken) =>
            send<GetAudioOutputConfigurationRequest, GetAudioOutputConfigurationResponse>(new GetAudioOutputConfigurationRequest
            {
                ConfigurationToken = configurationToken
            });

        public Task<GetAudioDecoderConfigurationResponse> GetAudioDecoderConfiguration(string configurationToken) =>
            send<GetAudioDecoderConfigurationRequest, GetAudioDecoderConfigurationResponse>(new GetAudioDecoderConfigurationRequest
            {
                ConfigurationToken = configurationToken
            });

        public Task<GetCompatibleVideoEncoderConfigurationsResponse> GetCompatibleVideoEncoderConfigurations(string profileToken) =>
            send<GetCompatibleVideoEncoderConfigurationsRequest, GetCompatibleVideoEncoderConfigurationsResponse>(new GetCompatibleVideoEncoderConfigurationsRequest
            {
                ProfileToken = profileToken
            });

        public Task<GetCompatibleVideoSourceConfigurationsResponse> GetCompatibleVideoSourceConfigurations(string profileToken) =>
            send<GetCompatibleVideoSourceConfigurationsRequest, GetCompatibleVideoSourceConfigurationsResponse>(new GetCompatibleVideoSourceConfigurationsRequest
            {
                ProfileToken = profileToken
            });

        public Task<GetCompatibleAudioEncoderConfigurationsResponse> GetCompatibleAudioEncoderConfigurations(string profileToken) =>
            send<GetCompatibleAudioEncoderConfigurationsRequest, GetCompatibleAudioEncoderConfigurationsResponse>(new GetCompatibleAudioEncoderConfigurationsRequest
            {
                ProfileToken = profileToken
            });

        public Task<GetCompatibleAudioSourceConfigurationsResponse> GetCompatibleAudioSourceConfigurations(string profileToken) =>
            send<GetCompatibleAudioSourceConfigurationsRequest, GetCompatibleAudioSourceConfigurationsResponse>(new GetCompatibleAudioSourceConfigurationsRequest
            {
                ProfileToken = profileToken
            });

        public Task<GetCompatibleVideoAnalyticsConfigurationsResponse> GetCompatibleVideoAnalyticsConfigurations(string profileToken) =>
            send<GetCompatibleVideoAnalyticsConfigurationsRequest, GetCompatibleVideoAnalyticsConfigurationsResponse>(new GetCompatibleVideoAnalyticsConfigurationsRequest
            {
                ProfileToken = profileToken
            });

        public Task<GetCompatibleMetadataConfigurationsResponse> GetCompatibleMetadataConfigurations(string profileToken) =>
            send<GetCompatibleMetadataConfigurationsRequest, GetCompatibleMetadataConfigurationsResponse>(new GetCompatibleMetadataConfigurationsRequest
            {
                ProfileToken = profileToken
            });

        public Task<GetCompatibleAudioOutputConfigurationsResponse> GetCompatibleAudioOutputConfigurations(string profileToken) =>
            send<GetCompatibleAudioOutputConfigurationsRequest, GetCompatibleAudioOutputConfigurationsResponse>(new GetCompatibleAudioOutputConfigurationsRequest
            {
                ProfileToken = profileToken
            });

        public Task<GetCompatibleAudioDecoderConfigurationsResponse> GetCompatibleAudioDecoderConfigurations(string profileToken) =>
            send<GetCompatibleAudioDecoderConfigurationsRequest, GetCompatibleAudioDecoderConfigurationsResponse>(new GetCompatibleAudioDecoderConfigurationsRequest
            {
                ProfileToken = profileToken
            });

        public Task<SetVideoSourceConfigurationResponse> SetVideoSourceConfiguration(VideoSourceConfiguration configuration, bool? forcePersistence = null) =>
            send<SetVideoSourceConfigurationRequest, SetVideoSourceConfigurationResponse>(new SetVideoSourceConfigurationRequest
            {
                Configuration = configuration,
                ForcePersistence = forcePersistence
            });

        public Task<SetVideoEncoderConfigurationResponse> SetVideoEncoderConfiguration(VideoEncoderConfiguration configuration, bool? forcePersistence = null) =>
            send<SetVideoEncoderConfigurationRequest, SetVideoEncoderConfigurationResponse>(new SetVideoEncoderConfigurationRequest
            {
                Configuration = configuration,
                ForcePersistence = forcePersistence
            });

        public Task<SetAudioSourceConfigurationResponse> SetAudioSourceConfiguration(AudioSourceConfiguration configuration, bool? forcePersistence = null) =>
            send<SetAudioSourceConfigurationRequest, SetAudioSourceConfigurationResponse>(new SetAudioSourceConfigurationRequest
            {
                Configuration = configuration,
                ForcePersistence = forcePersistence
            });

        public Task<SetAudioEncoderConfigurationResponse> SetAudioEncoderConfiguration(AudioEncoderConfiguration configuration, bool? forcePersistence = null) =>
            send<SetAudioEncoderConfigurationRequest, SetAudioEncoderConfigurationResponse>(new SetAudioEncoderConfigurationRequest
            {
                Configuration = configuration,
                ForcePersistence = forcePersistence
            });

        public Task<SetVideoAnalyticsConfigurationResponse> SetVideoAnalyticsConfiguration(VideoAnalyticsConfiguration configuration, bool? forcePersistence = null) =>
            send<SetVideoAnalyticsConfigurationRequest, SetVideoAnalyticsConfigurationResponse>(new SetVideoAnalyticsConfigurationRequest
            {
                Configuration = configuration,
                ForcePersistence = forcePersistence
            });

        public Task<SetMetadataConfigurationResponse> SetMetadataConfiguration(MetadataConfiguration configuration, bool? forcePersistence = null) =>
            send<SetMetadataConfigurationRequest, SetMetadataConfigurationResponse>(new SetMetadataConfigurationRequest
            {
                Configuration = configuration,
                ForcePersistence = forcePersistence
            });

        public Task<SetAudioOutputConfigurationResponse> SetAudioOutputConfiguration(AudioOutputConfiguration configuration, bool? forcePersistence = null) =>
            send<SetAudioOutputConfigurationRequest, SetAudioOutputConfigurationResponse>(new SetAudioOutputConfigurationRequest
            {
                Configuration = configuration,
                ForcePersistence = forcePersistence
            });

        public Task<SetAudioDecoderConfigurationResponse> SetAudioDecoderConfiguration(AudioDecoderConfiguration configuration, bool? forcePersistence = null) =>
            send<SetAudioDecoderConfigurationRequest, SetAudioDecoderConfigurationResponse>(new SetAudioDecoderConfigurationRequest
            {
                Configuration = configuration,
                ForcePersistence = forcePersistence
            });

        public Task<GetVideoSourceConfigurationOptionsResponse> GetVideoSourceConfigurationOptions(string configurationToken = null, string profileToken = null) =>
            send<GetVideoSourceConfigurationOptionsRequest, GetVideoSourceConfigurationOptionsResponse>(new GetVideoSourceConfigurationOptionsRequest
            {
                ConfigurationToken = configurationToken,
                ProfileToken = profileToken
            });

        public Task<GetVideoEncoderConfigurationOptionsResponse> GetVideoEncoderConfigurationOptions(string configurationToken = null, string profileToken = null) =>
            send<GetVideoEncoderConfigurationOptionsRequest, GetVideoEncoderConfigurationOptionsResponse>(new GetVideoEncoderConfigurationOptionsRequest
            {
                ConfigurationToken = configurationToken,
                ProfileToken = profileToken
            });

        public Task<GetAudioSourceConfigurationOptionsResponse> GetAudioSourceConfigurationOptions(string configurationToken = null, string profileToken = null) =>
            send<GetAudioSourceConfigurationOptionsRequest, GetAudioSourceConfigurationOptionsResponse>(new GetAudioSourceConfigurationOptionsRequest
            {
                ConfigurationToken = configurationToken,
                ProfileToken = profileToken
            });

        public Task<GetAudioEncoderConfigurationOptionsResponse> GetAudioEncoderConfigurationOptions(string configurationToken = null, string profileToken = null) =>
            send<GetAudioEncoderConfigurationOptionsRequest, GetAudioEncoderConfigurationOptionsResponse>(new GetAudioEncoderConfigurationOptionsRequest
            {
                ConfigurationToken = configurationToken,
                ProfileToken = profileToken
            });

        public Task<GetMetadataConfigurationOptionsResponse> GetMetadataConfigurationOptions(string configurationToken = null, string profileToken = null) =>
            send<GetMetadataConfigurationOptionsRequest, GetMetadataConfigurationOptionsResponse>(new GetMetadataConfigurationOptionsRequest
            {
                ConfigurationToken = configurationToken,
                ProfileToken = profileToken
            });

        public Task<GetAudioOutputConfigurationOptionsResponse> GetAudioOutputConfigurationOptions(string configurationToken = null, string profileToken = null) =>
            send<GetAudioOutputConfigurationOptionsRequest, GetAudioOutputConfigurationOptionsResponse>(new GetAudioOutputConfigurationOptionsRequest
            {
                ConfigurationToken = configurationToken,
                ProfileToken = profileToken
            });

        public Task<GetAudioDecoderConfigurationOptionsResponse> GetAudioDecoderConfigurationOptions(string configurationToken = null, string profileToken = null) =>
            send<GetAudioDecoderConfigurationOptionsRequest, GetAudioDecoderConfigurationOptionsResponse>(new GetAudioDecoderConfigurationOptionsRequest
            {
                ConfigurationToken = configurationToken,
                ProfileToken = profileToken
            });

        public Task<GetGuaranteedNumberOfVideoEncoderInstancesResponse> GetGuaranteedNumberOfVideoEncoderInstances(string configurationToken) =>
            send<GetGuaranteedNumberOfVideoEncoderInstancesRequest, GetGuaranteedNumberOfVideoEncoderInstancesResponse>(new GetGuaranteedNumberOfVideoEncoderInstancesRequest
            {
                ConfigurationToken = configurationToken
            });

        public Task<GetStreamUriResponse> GetStreamUri(StreamSetup streamSetup, string profileToken) =>
            send<GetStreamUriRequest, GetStreamUriResponse>(new GetStreamUriRequest
            {
                StreamSetup = streamSetup,
                ProfileToken = profileToken
            });

        public Task<StartMulticastStreamingResponse> StartMulticastStreaming(string profileToken) =>
            send<StartMulticastStreamingRequest, StartMulticastStreamingResponse>(new StartMulticastStreamingRequest
            {
                ProfileToken = profileToken
            });

        public Task<StopMulticastStreamingResponse> StopMulticastStreaming(string profileToken) =>
            send<StopMulticastStreamingRequest, StopMulticastStreamingResponse>(new StopMulticastStreamingRequest
            {
                ProfileToken = profileToken
            });

        public Task<SetSynchronizationPointResponse> SetSynchronizationPoint(string profileToken) =>
            send<SetSynchronizationPointRequest, SetSynchronizationPointResponse>(new SetSynchronizationPointRequest
            {
                ProfileToken = profileToken
            });

        public Task<GetSnapshotUriResponse> GetSnapshotUri(string profileToken) =>
            send<GetSnapshotUriRequest, GetSnapshotUriResponse>(new GetSnapshotUriRequest
            {
                ProfileToken = profileToken
            });

        public Task<GetVideoSourceModesResponse> GetVideoSourceModes(string videoSourceToken) =>
            send<GetVideoSourceModesRequest, GetVideoSourceModesResponse>(new GetVideoSourceModesRequest
            {
                VideoSourceToken = videoSourceToken
            });

        public Task<SetVideoSourceModeResponse> SetVideoSourceMode(string videoSourceToken, string videoSourceModeToken) =>
            send<SetVideoSourceModeRequest, SetVideoSourceModeResponse>(new SetVideoSourceModeRequest
            {
                VideoSourceToken = videoSourceToken,
                VideoSourceModeToken = videoSourceModeToken
            });

        public Task<GetOSDsResponse> GetOSDs(string videoSourceConfigurationToken = null) =>
            send<GetOSDsRequest, GetOSDsResponse>(new GetOSDsRequest
            {
                VideoSourceConfigurationToken = videoSourceConfigurationToken
            });

        public Task<GetOSDResponse> GetOSD(string osdToken) =>
            send<GetOSDRequest, GetOSDResponse>(new GetOSDRequest
            {
                OSDToken = osdToken
            });

        public Task<GetOSDOptionsResponse> GetOSDOptions(string videoSourceConfigurationToken = null) =>
            send<GetOSDOptionsRequest, GetOSDOptionsResponse>(new GetOSDOptionsRequest
            {
                ConfigurationToken = videoSourceConfigurationToken
            });

        public Task<SetOSDResponse> SetOSD(OSDConfiguration osd) =>
            send<SetOSDRequest, SetOSDResponse>(new SetOSDRequest
            {
                OSD = osd
            });

        public Task<CreateOSDResponse> CreateOSD(OSDConfiguration osd) =>
            send<CreateOSDRequest, CreateOSDResponse>(new CreateOSDRequest
            {
                OSD = osd
            });

        public Task<DeleteOSDResponse> DeleteOSD(string osdToken) =>
            send<DeleteOSDRequest, DeleteOSDResponse>(new DeleteOSDRequest
            {
                OSDToken = osdToken
            });
    }
}