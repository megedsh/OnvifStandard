using System.Threading.Tasks;

using OnvifStandard.Common;

namespace OnvifStandard.Ptz;

public interface IPtzClient : IOnvifSoapClient
{
    Task<GetServiceCapabilitiesResponse>      GetServiceCapabilities();
    Task<GetNodesResponse>                    GetNodes();
    Task<GetNodeResponse>                     GetNode(string nodeToken);
    Task<GetConfigurationsResponse>           GetConfigurations();
    Task<GetConfigurationResponse>            GetConfiguration(string            ptzConfigurationToken);
    Task<SetConfigurationResponse>            SetConfiguration(PTZConfiguration  ptzConfiguration, bool forcePersistence);
    Task<GetConfigurationOptionsResponse>     GetConfigurationOptions(string     configurationToken);
    Task<SendAuxiliaryCommandResponse>        SendAuxiliaryCommand(string        profileToken, string auxiliaryData);
    Task<GetPresetsResponse>                  GetPresets(string                  profileToken);
    Task<SetPresetResponse>                   SetPreset(string                   profileToken, string presetName = null, string presetToken = null);
    Task<RemovePresetResponse>                RemovePreset(string                profileToken, string presetToken);
    Task<GotoPresetResponse>                  GotoPreset(string                  profileToken, string presetToken, PTZSpeed speed = null);
    Task<GetStatusResponse>                   GetStatus(string                   profileToken);
    Task<GotoHomePositionResponse>            GotoHomePosition(string            profileToken, PTZSpeed speed = null);
    Task<SetHomePositionResponse>             SetHomePosition(string             profileToken);
    Task<ContinuousMoveResponse>              ContinuousMove(string              profileToken, PTZSpeed    velocity,       string   timeout = null);
    Task<RelativeMoveResponse>                RelativeMove(string                profileToken, PTZVector   translation,    PTZSpeed speed   = null);
    Task<AbsoluteMoveResponse>                AbsoluteMove(string                profileToken, PTZVector   position,       PTZSpeed speed   = null);
    Task<GeoMoveResponse>                     GeoMove(string                     profileToken, GeoLocation target,         PTZSpeed speed   = null, float? areaHeight = null, float? areaWidth = null);
    Task<StopResponse>                        Stop(string                        profileToken, bool?       panTilt = null, bool?    zoom    = null);
    Task<GetPresetToursResponse>              GetPresetTours(string              profileToken);
    Task<GetPresetTourResponse>               GetPresetTour(string               profileToken, string presetTourToken);
    Task<GetPresetTourOptionsResponse>        GetPresetTourOptions(string        profileToken, string presetTourToken = null);
    Task<CreatePresetTourResponse>            CreatePresetTour(string            profileToken);
    Task<ModifyPresetTourResponse>            ModifyPresetTour(string            profileToken, PresetTour presetTour);
    Task<OperatePresetTourResponse>           OperatePresetTour(string           profileToken, string     presetTourToken, PTZPresetTourOperation operation);
    Task<RemovePresetTourResponse>            RemovePresetTour(string            profileToken, string     presetTourToken);
    Task<GetCompatibleConfigurationsResponse> GetCompatibleConfigurations(string profileToken);
    Task<MoveAndStartTrackingResponse>        MoveAndStartTracking(string        profileToken, string presetToken = null, GeoLocation geoLocation = null, PTZVector targetPosition = null, PTZSpeed speed = null, int? objectId = null);
}