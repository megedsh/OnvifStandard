using System;
using System.Threading.Tasks;

using OnvifStandard.Common;

namespace OnvifStandard.Ptz
{
    public class PtzClient : OnvifSoapClientBase
    {
        private Uri serviceUri => ServiceUri ?? throw new InvalidOperationException("ServiceUri must be set.");

        private Task<TRes> send<TReq, TRes>(TReq request)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<TReq, TRes>(serviceUri, request, securityHeader);
        }

        public Task<GetServiceCapabilitiesResponse> GetServiceCapabilities() => send<GetServiceCapabilitiesRequest, GetServiceCapabilitiesResponse>(new GetServiceCapabilitiesRequest());
        public Task<GetNodesResponse> GetNodes() => send<GetNodesRequest, GetNodesResponse>(new GetNodesRequest());
        public Task<GetNodeResponse> GetNode(string nodeToken) => send<GetNodeRequest, GetNodeResponse>(new GetNodeRequest { NodeToken = nodeToken });
        public Task<GetConfigurationsResponse> GetConfigurations() => send<GetConfigurationsRequest, GetConfigurationsResponse>(new GetConfigurationsRequest());
        public Task<GetConfigurationResponse> GetConfiguration(string ptzConfigurationToken) => send<GetConfigurationRequest, GetConfigurationResponse>(new GetConfigurationRequest { PTZConfigurationToken = ptzConfigurationToken });
        public Task<SetConfigurationResponse> SetConfiguration(PTZConfiguration ptzConfiguration, bool forcePersistence) => send<SetConfigurationRequest, SetConfigurationResponse>(new SetConfigurationRequest { PTZConfiguration = ptzConfiguration, ForcePersistence = forcePersistence });
        public Task<GetConfigurationOptionsResponse> GetConfigurationOptions(string configurationToken) => send<GetConfigurationOptionsRequest, GetConfigurationOptionsResponse>(new GetConfigurationOptionsRequest { ConfigurationToken = configurationToken });
        public Task<SendAuxiliaryCommandResponse> SendAuxiliaryCommand(string profileToken, string auxiliaryData) => send<SendAuxiliaryCommandRequest, SendAuxiliaryCommandResponse>(new SendAuxiliaryCommandRequest { ProfileToken = profileToken, AuxiliaryData = auxiliaryData });
        public Task<GetPresetsResponse> GetPresets(string profileToken) => send<GetPresetsRequest, GetPresetsResponse>(new GetPresetsRequest { ProfileToken = profileToken });
        public Task<SetPresetResponse> SetPreset(string profileToken, string presetName = null, string presetToken = null) => send<SetPresetRequest, SetPresetResponse>(new SetPresetRequest { ProfileToken = profileToken, PresetName = presetName, PresetToken = presetToken });
        public Task<RemovePresetResponse> RemovePreset(string profileToken, string presetToken) => send<RemovePresetRequest, RemovePresetResponse>(new RemovePresetRequest { ProfileToken = profileToken, PresetToken = presetToken });
        public Task<GotoPresetResponse> GotoPreset(string profileToken, string presetToken, PTZSpeed speed = null) => send<GotoPresetRequest, GotoPresetResponse>(new GotoPresetRequest { ProfileToken = profileToken, PresetToken = presetToken, Speed = speed });
        public Task<GetStatusResponse> GetStatus(string profileToken) => send<GetStatusRequest, GetStatusResponse>(new GetStatusRequest { ProfileToken = profileToken });
        public Task<GotoHomePositionResponse> GotoHomePosition(string profileToken, PTZSpeed speed = null) => send<GotoHomePositionRequest, GotoHomePositionResponse>(new GotoHomePositionRequest { ProfileToken = profileToken, Speed = speed });
        public Task<SetHomePositionResponse> SetHomePosition(string profileToken) => send<SetHomePositionRequest, SetHomePositionResponse>(new SetHomePositionRequest { ProfileToken = profileToken });
        public Task<ContinuousMoveResponse> ContinuousMove(string profileToken, PTZSpeed velocity, string timeout = null) => send<ContinuousMoveRequest, ContinuousMoveResponse>(new ContinuousMoveRequest { ProfileToken = profileToken, Velocity = velocity, Timeout = timeout });
        public Task<RelativeMoveResponse> RelativeMove(string profileToken, PTZVector translation, PTZSpeed speed = null) => send<RelativeMoveRequest, RelativeMoveResponse>(new RelativeMoveRequest { ProfileToken = profileToken, Translation = translation, Speed = speed });
        public Task<AbsoluteMoveResponse> AbsoluteMove(string profileToken, PTZVector position, PTZSpeed speed = null) => send<AbsoluteMoveRequest, AbsoluteMoveResponse>(new AbsoluteMoveRequest { ProfileToken = profileToken, Position = position, Speed = speed });
        public Task<GeoMoveResponse> GeoMove(string profileToken, GeoLocation target, PTZSpeed speed = null, float? areaHeight = null, float? areaWidth = null) => send<GeoMoveRequest, GeoMoveResponse>(new GeoMoveRequest { ProfileToken = profileToken, Target = target, Speed = speed, AreaHeight = areaHeight, AreaWidth = areaWidth });
        public Task<StopResponse> Stop(string profileToken, bool? panTilt = null, bool? zoom = null) => send<StopRequest, StopResponse>(new StopRequest { ProfileToken = profileToken, PanTilt = panTilt, Zoom = zoom });
        public Task<GetPresetToursResponse> GetPresetTours(string profileToken) => send<GetPresetToursRequest, GetPresetToursResponse>(new GetPresetToursRequest { ProfileToken = profileToken });
        public Task<GetPresetTourResponse> GetPresetTour(string profileToken, string presetTourToken) => send<GetPresetTourRequest, GetPresetTourResponse>(new GetPresetTourRequest { ProfileToken = profileToken, PresetTourToken = presetTourToken });
        public Task<GetPresetTourOptionsResponse> GetPresetTourOptions(string profileToken, string presetTourToken = null) => send<GetPresetTourOptionsRequest, GetPresetTourOptionsResponse>(new GetPresetTourOptionsRequest { ProfileToken = profileToken, PresetTourToken = presetTourToken });
        public Task<CreatePresetTourResponse> CreatePresetTour(string profileToken) => send<CreatePresetTourRequest, CreatePresetTourResponse>(new CreatePresetTourRequest { ProfileToken = profileToken });
        public Task<ModifyPresetTourResponse> ModifyPresetTour(string profileToken, PresetTour presetTour) => send<ModifyPresetTourRequest, ModifyPresetTourResponse>(new ModifyPresetTourRequest { ProfileToken = profileToken, PresetTour = presetTour });
        public Task<OperatePresetTourResponse> OperatePresetTour(string profileToken, string presetTourToken, PTZPresetTourOperation operation) => send<OperatePresetTourRequest, OperatePresetTourResponse>(new OperatePresetTourRequest { ProfileToken = profileToken, PresetTourToken = presetTourToken, Operation = operation });
        public Task<RemovePresetTourResponse> RemovePresetTour(string profileToken, string presetTourToken) => send<RemovePresetTourRequest, RemovePresetTourResponse>(new RemovePresetTourRequest { ProfileToken = profileToken, PresetTourToken = presetTourToken });
        public Task<GetCompatibleConfigurationsResponse> GetCompatibleConfigurations(string profileToken) => send<GetCompatibleConfigurationsRequest, GetCompatibleConfigurationsResponse>(new GetCompatibleConfigurationsRequest { ProfileToken = profileToken });
        public Task<MoveAndStartTrackingResponse> MoveAndStartTracking(string profileToken, string presetToken = null, GeoLocation geoLocation = null, PTZVector targetPosition = null, PTZSpeed speed = null, int? objectId = null) => send<MoveAndStartTrackingRequest, MoveAndStartTrackingResponse>(new MoveAndStartTrackingRequest { ProfileToken = profileToken, PresetToken = presetToken, GeoLocation = geoLocation, TargetPosition = targetPosition, Speed = speed, ObjectID = objectId });
    }
}
