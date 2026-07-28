using System.Threading.Tasks;

namespace OnvifStandard.Imaging;

public interface IImagingClient : IOnvifSoapClient
{
    Task<GetServiceCapabilitiesResponse> GetServiceCapabilities();
    Task<GetImagingSettingsResponse>     GetImagingSettings(string videoSourceToken);
    Task<SetImagingSettingsResponse>     SetImagingSettings(string videoSourceToken, ImagingSettings20 imagingSettings, bool? forcePersistence = null);
    Task<GetOptionsResponse>             GetOptions(string         videoSourceToken);
    Task<GetMoveOptionsResponse>         GetMoveOptions(string     videoSourceToken);
    Task<MoveResponse>                   Move(string               videoSourceToken, FocusMove focus);
    Task<StopResponse>                   Stop(string               videoSourceToken);
    Task<GetStatusResponse>              GetStatus(string          videoSourceToken);
    Task<GetPresetsResponse>             GetPresets(string         videoSourceToken);
    Task<GetCurrentPresetResponse>       GetCurrentPreset(string   videoSourceToken);
    Task<SetCurrentPresetResponse>       SetCurrentPreset(string   videoSourceToken, string presetToken);
}