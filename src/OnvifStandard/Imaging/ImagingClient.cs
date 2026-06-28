using System;
using System.Threading.Tasks;

using OnvifStandard.Common;

namespace OnvifStandard.Imaging
{
    public class ImagingClient : OnvifSoapClientBase
    {
        private Uri serviceUri => ServiceUri ?? throw new InvalidOperationException("ServiceUri must be set.");

        public Task<GetServiceCapabilitiesResponse> GetServiceCapabilities() => send<GetServiceCapabilitiesRequest, GetServiceCapabilitiesResponse>(new GetServiceCapabilitiesRequest());

        public Task<GetImagingSettingsResponse> GetImagingSettings(string videoSourceToken) =>
            send<GetImagingSettingsRequest, GetImagingSettingsResponse>(new GetImagingSettingsRequest
            {
                VideoSourceToken = videoSourceToken
            });

        public Task<SetImagingSettingsResponse> SetImagingSettings(string videoSourceToken, ImagingSettings20 imagingSettings, bool? forcePersistence = null) =>
            send<SetImagingSettingsRequest, SetImagingSettingsResponse>(new SetImagingSettingsRequest
            {
                VideoSourceToken = videoSourceToken,
                ImagingSettings = imagingSettings,
                ForcePersistence = forcePersistence
            });

        public Task<GetOptionsResponse> GetOptions(string videoSourceToken) =>
            send<GetOptionsRequest, GetOptionsResponse>(new GetOptionsRequest
            {
                VideoSourceToken = videoSourceToken
            });

        public Task<GetMoveOptionsResponse> GetMoveOptions(string videoSourceToken) =>
            send<GetMoveOptionsRequest, GetMoveOptionsResponse>(new GetMoveOptionsRequest
            {
                VideoSourceToken = videoSourceToken
            });

        public Task<MoveResponse> Move(string videoSourceToken, FocusMove focus) =>
            send<MoveRequest, MoveResponse>(new MoveRequest
            {
                VideoSourceToken = videoSourceToken,
                Focus = focus
            });

        public Task<StopResponse> Stop(string videoSourceToken) =>
            send<StopRequest, StopResponse>(new StopRequest
            {
                VideoSourceToken = videoSourceToken
            });

        public Task<GetStatusResponse> GetStatus(string videoSourceToken) =>
            send<GetStatusRequest, GetStatusResponse>(new GetStatusRequest
            {
                VideoSourceToken = videoSourceToken
            });

        public Task<GetPresetsResponse> GetPresets(string videoSourceToken) =>
            send<GetPresetsRequest, GetPresetsResponse>(new GetPresetsRequest
            {
                VideoSourceToken = videoSourceToken
            });

        public Task<GetCurrentPresetResponse> GetCurrentPreset(string videoSourceToken) =>
            send<GetCurrentPresetRequest, GetCurrentPresetResponse>(new GetCurrentPresetRequest
            {
                VideoSourceToken = videoSourceToken
            });

        public Task<SetCurrentPresetResponse> SetCurrentPreset(string videoSourceToken, string presetToken) =>
            send<SetCurrentPresetRequest, SetCurrentPresetResponse>(new SetCurrentPresetRequest
            {
                VideoSourceToken = videoSourceToken,
                PresetToken = presetToken
            });

        private Task<TRes> send<TReq, TRes>(TReq request)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<TReq, TRes>(serviceUri, request, securityHeader);
        }
    }
}
