using System;
using System.Threading.Tasks;

using OnvifStandard.Common;

namespace OnvifStandard.Imaging
{
    public class ImagingClient : OnvifSoapClientBase
    {
        private Uri serviceUri => ServiceUri ?? throw new InvalidOperationException("ServiceUri must be set.");

        public Task<GetServiceCapabilitiesResponse> GetServiceCapabilities()
        {
            GetServiceCapabilitiesRequest request = new GetServiceCapabilitiesRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetServiceCapabilitiesRequest, GetServiceCapabilitiesResponse>(serviceUri, request, securityHeader);
        }

        public Task<GetImagingSettingsResponse> GetImagingSettings(string videoSourceToken)
        {
            GetImagingSettingsRequest request = new GetImagingSettingsRequest
            {
                VideoSourceToken = videoSourceToken
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetImagingSettingsRequest, GetImagingSettingsResponse>(serviceUri, request, securityHeader);
        }

        public Task<SetImagingSettingsResponse> SetImagingSettings(string videoSourceToken, ImagingSettings20 imagingSettings, bool? forcePersistence = null)
        {
            SetImagingSettingsRequest request = new SetImagingSettingsRequest
            {
                VideoSourceToken = videoSourceToken,
                ImagingSettings = imagingSettings,
                ForcePersistence = forcePersistence
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<SetImagingSettingsRequest, SetImagingSettingsResponse>(serviceUri, request, securityHeader);
        }

        public Task<GetOptionsResponse> GetOptions(string videoSourceToken)
        {
            GetOptionsRequest request = new GetOptionsRequest
            {
                VideoSourceToken = videoSourceToken
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetOptionsRequest, GetOptionsResponse>(serviceUri, request, securityHeader);
        }

        public Task<GetMoveOptionsResponse> GetMoveOptions(string videoSourceToken)
        {
            GetMoveOptionsRequest request = new GetMoveOptionsRequest
            {
                VideoSourceToken = videoSourceToken
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetMoveOptionsRequest, GetMoveOptionsResponse>(serviceUri, request, securityHeader);
        }

        public Task<MoveResponse> Move(string videoSourceToken, FocusMove focus)
        {
            MoveRequest request = new MoveRequest
            {
                VideoSourceToken = videoSourceToken,
                Focus = focus
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<MoveRequest, MoveResponse>(serviceUri, request, securityHeader);
        }

        public Task<StopResponse> Stop(string videoSourceToken)
        {
            StopRequest request = new StopRequest
            {
                VideoSourceToken = videoSourceToken
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<StopRequest, StopResponse>(serviceUri, request, securityHeader);
        }

        public Task<GetStatusResponse> GetStatus(string videoSourceToken)
        {
            GetStatusRequest request = new GetStatusRequest
            {
                VideoSourceToken = videoSourceToken
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetStatusRequest, GetStatusResponse>(serviceUri, request, securityHeader);
        }

        public Task<GetPresetsResponse> GetPresets(string videoSourceToken)
        {
            GetPresetsRequest request = new GetPresetsRequest
            {
                VideoSourceToken = videoSourceToken
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetPresetsRequest, GetPresetsResponse>(serviceUri, request, securityHeader);
        }

        public Task<GetCurrentPresetResponse> GetCurrentPreset(string videoSourceToken)
        {
            GetCurrentPresetRequest request = new GetCurrentPresetRequest
            {
                VideoSourceToken = videoSourceToken
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetCurrentPresetRequest, GetCurrentPresetResponse>(serviceUri, request, securityHeader);
        }

        public Task<SetCurrentPresetResponse> SetCurrentPreset(string videoSourceToken, string presetToken)
        {
            SetCurrentPresetRequest request = new SetCurrentPresetRequest
            {
                VideoSourceToken = videoSourceToken,
                PresetToken = presetToken
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<SetCurrentPresetRequest, SetCurrentPresetResponse>(serviceUri, request, securityHeader);
        }
    }
}
