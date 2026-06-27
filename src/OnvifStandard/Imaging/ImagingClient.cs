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
    }
}
