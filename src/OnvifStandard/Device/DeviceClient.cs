using System;
using System.Threading.Tasks;

using OnvifStandard.Common;

namespace OnvifStandard.Device
{
    public class DeviceClient : OnvifSoapClientBase
    {
        private Uri serviceUri => ServiceUri ?? throw new InvalidOperationException("ServiceUri must be set.");

        public Task<GetServicesResponse> GetServices(bool includeCapability)
        {
            GetServicesRequest getServicesRequest = new GetServicesRequest
            {
                IncludeCapability = includeCapability
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetServicesRequest, GetServicesResponse>(serviceUri, getServicesRequest, securityHeader);
        }

        public Task<GetDeviceInformationResponse> GetDeviceInformation()
        {
            GetDeviceInformationRequest getDeviceInformationRequest = new GetDeviceInformationRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetDeviceInformationRequest, GetDeviceInformationResponse>(serviceUri, getDeviceInformationRequest, securityHeader);
        }

        public Task<GetServiceCapabilitiesResponse> GetServiceCapabilities()
        {
            GetServiceCapabilitiesRequest getServiceCapabilitiesRequest = new GetServiceCapabilitiesRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetServiceCapabilitiesRequest, GetServiceCapabilitiesResponse>(serviceUri, getServiceCapabilitiesRequest, securityHeader);
        }

        public Task<GetSystemDateAndTimeResponse> GetSystemDateAndTime()
        {
            GetSystemDateAndTimeRequest getSystemDateAndTimeRequest = new GetSystemDateAndTimeRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetSystemDateAndTimeRequest, GetSystemDateAndTimeResponse>(serviceUri, getSystemDateAndTimeRequest, securityHeader);
        }

        public Task<GetSystemLogResponse> GetSystemLog(SystemLogType logType)
        {
            GetSystemLogRequest getSystemLogRequest = new GetSystemLogRequest
            {
                LogType = logType
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetSystemLogRequest, GetSystemLogResponse>(serviceUri, getSystemLogRequest, securityHeader);
        }

        public Task<GetSystemSupportInformationResponse> GetSystemSupportInformation()
        {
            GetSystemSupportInformationRequest getSystemSupportInformationRequest = new GetSystemSupportInformationRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetSystemSupportInformationRequest, GetSystemSupportInformationResponse>(serviceUri, getSystemSupportInformationRequest, securityHeader);
        }

        public Task<GetScopesResponse> GetScopes()
        {
            GetScopesRequest getScopesRequest = new GetScopesRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetScopesRequest, GetScopesResponse>(serviceUri, getScopesRequest, securityHeader);
        }

        public Task<GetDiscoveryModeResponse> GetDiscoveryMode()
        {
            GetDiscoveryModeRequest getDiscoveryModeRequest = new GetDiscoveryModeRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetDiscoveryModeRequest, GetDiscoveryModeResponse>(serviceUri, getDiscoveryModeRequest, securityHeader);
        }

        public Task<GetRemoteDiscoveryModeResponse> GetRemoteDiscoveryMode()
        {
            GetRemoteDiscoveryModeRequest getRemoteDiscoveryModeRequest = new GetRemoteDiscoveryModeRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetRemoteDiscoveryModeRequest, GetRemoteDiscoveryModeResponse>(serviceUri, getRemoteDiscoveryModeRequest, securityHeader);
        }

        public Task<GetWsdlUrlResponse> GetWsdlUrl()
        {
            GetWsdlUrlRequest getWsdlUrlRequest = new GetWsdlUrlRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetWsdlUrlRequest, GetWsdlUrlResponse>(serviceUri, getWsdlUrlRequest, securityHeader);
        }

        public Task<GetEndpointReferenceResponse> GetEndpointReference()
        {
            GetEndpointReferenceRequest getEndpointReferenceRequest = new GetEndpointReferenceRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetEndpointReferenceRequest, GetEndpointReferenceResponse>(serviceUri, getEndpointReferenceRequest, securityHeader);
        }

        public Task<GetHostnameResponse> GetHostname()
        {
            GetHostnameRequest getHostnameRequest = new GetHostnameRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetHostnameRequest, GetHostnameResponse>(serviceUri, getHostnameRequest, securityHeader);
        }

        public Task<GetPasswordComplexityOptionsResponse> GetPasswordComplexityOptions()
        {
            GetPasswordComplexityOptionsRequest getPasswordComplexityOptionsRequest = new GetPasswordComplexityOptionsRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetPasswordComplexityOptionsRequest, GetPasswordComplexityOptionsResponse>(serviceUri, getPasswordComplexityOptionsRequest, securityHeader);
        }

        public Task<GetPasswordComplexityConfigurationResponse> GetPasswordComplexityConfiguration()
        {
            GetPasswordComplexityConfigurationRequest getPasswordComplexityConfigurationRequest = new GetPasswordComplexityConfigurationRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetPasswordComplexityConfigurationRequest, GetPasswordComplexityConfigurationResponse>(serviceUri, getPasswordComplexityConfigurationRequest, securityHeader);
        }

        public Task<GetPasswordHistoryConfigurationResponse> GetPasswordHistoryConfiguration()
        {
            GetPasswordHistoryConfigurationRequest getPasswordHistoryConfigurationRequest = new GetPasswordHistoryConfigurationRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetPasswordHistoryConfigurationRequest, GetPasswordHistoryConfigurationResponse>(serviceUri, getPasswordHistoryConfigurationRequest, securityHeader);
        }

        public Task<GetAuthFailureWarningOptionsResponse> GetAuthFailureWarningOptions()
        {
            GetAuthFailureWarningOptionsRequest getAuthFailureWarningOptionsRequest = new GetAuthFailureWarningOptionsRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetAuthFailureWarningOptionsRequest, GetAuthFailureWarningOptionsResponse>(serviceUri, getAuthFailureWarningOptionsRequest, securityHeader);
        }

        public Task<GetAuthFailureWarningConfigurationResponse> GetAuthFailureWarningConfiguration()
        {
            GetAuthFailureWarningConfigurationRequest getAuthFailureWarningConfigurationRequest = new GetAuthFailureWarningConfigurationRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetAuthFailureWarningConfigurationRequest, GetAuthFailureWarningConfigurationResponse>(serviceUri, getAuthFailureWarningConfigurationRequest, securityHeader);
        }

        public Task<GetSystemBackupResponse> GetSystemBackup()
        {
            GetSystemBackupRequest getSystemBackupRequest = new GetSystemBackupRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetSystemBackupRequest, GetSystemBackupResponse>(serviceUri, getSystemBackupRequest, securityHeader);
        }

        public Task<GetDPAddressesResponse> GetDPAddresses()
        {
            GetDPAddressesRequest getDPAddressesRequest = new GetDPAddressesRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetDPAddressesRequest, GetDPAddressesResponse>(serviceUri, getDPAddressesRequest, securityHeader);
        }

        public Task<GetUserRolesResponse> GetUserRoles(string userRole = null)
        {
            GetUserRolesRequest getUserRolesRequest = new GetUserRolesRequest
            {
                UserRole = userRole
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetUserRolesRequest, GetUserRolesResponse>(serviceUri, getUserRolesRequest, securityHeader);
        }

        public Task<GetUsersResponse> GetUsers()
        {
            GetUsersRequest getUsersRequest = new GetUsersRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetUsersRequest, GetUsersResponse>(serviceUri, getUsersRequest, securityHeader);
        }

        public Task<GetDNSResponse> GetDNS()
        {
            GetDNSRequest getDNSRequest = new GetDNSRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetDNSRequest, GetDNSResponse>(serviceUri, getDNSRequest, securityHeader);
        }

        public Task<GetNTPResponse> GetNTP()
        {
            GetNTPRequest getNTPRequest = new GetNTPRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetNTPRequest, GetNTPResponse>(serviceUri, getNTPRequest, securityHeader);
        }

        public Task<GetDynamicDNSResponse> GetDynamicDNS()
        {
            GetDynamicDNSRequest getDynamicDNSRequest = new GetDynamicDNSRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetDynamicDNSRequest, GetDynamicDNSResponse>(serviceUri, getDynamicDNSRequest, securityHeader);
        }

        public Task<GetNetworkProtocolsResponse> GetNetworkProtocols()
        {
            GetNetworkProtocolsRequest getNetworkProtocolsRequest = new GetNetworkProtocolsRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetNetworkProtocolsRequest, GetNetworkProtocolsResponse>(serviceUri, getNetworkProtocolsRequest, securityHeader);
        }

        public Task<GetNetworkDefaultGatewayResponse> GetNetworkDefaultGateway()
        {
            GetNetworkDefaultGatewayRequest getNetworkDefaultGatewayRequest = new GetNetworkDefaultGatewayRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetNetworkDefaultGatewayRequest, GetNetworkDefaultGatewayResponse>(serviceUri, getNetworkDefaultGatewayRequest, securityHeader);
        }

        public Task<GetZeroConfigurationResponse> GetZeroConfiguration()
        {
            GetZeroConfigurationRequest getZeroConfigurationRequest = new GetZeroConfigurationRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetZeroConfigurationRequest, GetZeroConfigurationResponse>(serviceUri, getZeroConfigurationRequest, securityHeader);
        }

        public Task<GetIPAddressFilterResponse> GetIPAddressFilter()
        {
            GetIPAddressFilterRequest getIPAddressFilterRequest = new GetIPAddressFilterRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetIPAddressFilterRequest, GetIPAddressFilterResponse>(serviceUri, getIPAddressFilterRequest, securityHeader);
        }

        public Task<GetRemoteUserResponse> GetRemoteUser()
        {
            GetRemoteUserRequest getRemoteUserRequest = new GetRemoteUserRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetRemoteUserRequest, GetRemoteUserResponse>(serviceUri, getRemoteUserRequest, securityHeader);
        }

        public Task<GetNetworkInterfacesResponse> GetNetworkInterfaces()
        {
            GetNetworkInterfacesRequest getNetworkInterfacesRequest = new GetNetworkInterfacesRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetNetworkInterfacesRequest, GetNetworkInterfacesResponse>(serviceUri, getNetworkInterfacesRequest, securityHeader);
        }

        public Task<GetAccessPolicyResponse> GetAccessPolicy()
        {
            GetAccessPolicyRequest getAccessPolicyRequest = new GetAccessPolicyRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetAccessPolicyRequest, GetAccessPolicyResponse>(serviceUri, getAccessPolicyRequest, securityHeader);
        }

        public Task<GetRelayOutputsResponse> GetRelayOutputs()
        {
            GetRelayOutputsRequest getRelayOutputsRequest = new GetRelayOutputsRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetRelayOutputsRequest, GetRelayOutputsResponse>(serviceUri, getRelayOutputsRequest, securityHeader);
        }

        public Task<GetDot11CapabilitiesResponse> GetDot11Capabilities()
        {
            GetDot11CapabilitiesRequest getDot11CapabilitiesRequest = new GetDot11CapabilitiesRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetDot11CapabilitiesRequest, GetDot11CapabilitiesResponse>(serviceUri, getDot11CapabilitiesRequest, securityHeader);
        }

        public Task<GetDot11StatusResponse> GetDot11Status(string interfaceToken)
        {
            GetDot11StatusRequest getDot11StatusRequest = new GetDot11StatusRequest
            {
                InterfaceToken = interfaceToken
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetDot11StatusRequest, GetDot11StatusResponse>(serviceUri, getDot11StatusRequest, securityHeader);
        }

        public Task<GetSystemUrisResponse> GetSystemUris()
        {
            GetSystemUrisRequest getSystemUrisRequest = new GetSystemUrisRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetSystemUrisRequest, GetSystemUrisResponse>(serviceUri, getSystemUrisRequest, securityHeader);
        }

        public Task<GetStorageConfigurationsResponse> GetStorageConfigurations()
        {
            GetStorageConfigurationsRequest getStorageConfigurationsRequest = new GetStorageConfigurationsRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetStorageConfigurationsRequest, GetStorageConfigurationsResponse>(serviceUri, getStorageConfigurationsRequest, securityHeader);
        }

        public Task<GetStorageConfigurationResponse> GetStorageConfiguration(string token)
        {
            GetStorageConfigurationRequest getStorageConfigurationRequest = new GetStorageConfigurationRequest
            {
                Token = token
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetStorageConfigurationRequest, GetStorageConfigurationResponse>(serviceUri, getStorageConfigurationRequest, securityHeader);
        }

        public Task<GetGeoLocationResponse> GetGeoLocation()
        {
            GetGeoLocationRequest getGeoLocationRequest = new GetGeoLocationRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetGeoLocationRequest, GetGeoLocationResponse>(serviceUri, getGeoLocationRequest, securityHeader);
        }

        public Task<GetCertificatesResponse> GetCertificates()
        {
            GetCertificatesRequest getCertificatesRequest = new GetCertificatesRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetCertificatesRequest, GetCertificatesResponse>(serviceUri, getCertificatesRequest, securityHeader);
        }

        public Task<GetCertificatesStatusResponse> GetCertificatesStatus()
        {
            GetCertificatesStatusRequest getCertificatesStatusRequest = new GetCertificatesStatusRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetCertificatesStatusRequest, GetCertificatesStatusResponse>(serviceUri, getCertificatesStatusRequest, securityHeader);
        }

        public Task<GetPkcs10RequestResponse> GetPkcs10Request(string certificateId, string subject = null, BinaryData attributes = null)
        {
            GetPkcs10Request getPkcs10Request = new GetPkcs10Request
            {
                CertificateID = certificateId,
                Subject = subject,
                Attributes = attributes
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetPkcs10Request, GetPkcs10RequestResponse>(serviceUri, getPkcs10Request, securityHeader);
        }

        public Task<GetClientCertificateModeResponse> GetClientCertificateMode()
        {
            GetClientCertificateModeRequest getClientCertificateModeRequest = new GetClientCertificateModeRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetClientCertificateModeRequest, GetClientCertificateModeResponse>(serviceUri, getClientCertificateModeRequest, securityHeader);
        }

        public Task<GetCACertificatesResponse> GetCACertificates()
        {
            GetCACertificatesRequest getCACertificatesRequest = new GetCACertificatesRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetCACertificatesRequest, GetCACertificatesResponse>(serviceUri, getCACertificatesRequest, securityHeader);
        }

        public Task<GetCertificateInformationResponse> GetCertificateInformation(string certificateId)
        {
            GetCertificateInformationRequest getCertificateInformationRequest = new GetCertificateInformationRequest
            {
                CertificateID = certificateId
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetCertificateInformationRequest, GetCertificateInformationResponse>(serviceUri, getCertificateInformationRequest, securityHeader);
        }

        public Task<GetDot1XConfigurationResponse> GetDot1XConfiguration(string dot1XConfigurationToken)
        {
            GetDot1XConfigurationRequest getDot1XConfigurationRequest = new GetDot1XConfigurationRequest
            {
                Dot1XConfigurationToken = dot1XConfigurationToken
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetDot1XConfigurationRequest, GetDot1XConfigurationResponse>(serviceUri, getDot1XConfigurationRequest, securityHeader);
        }

        public Task<GetDot1XConfigurationsResponse> GetDot1XConfigurations()
        {
            GetDot1XConfigurationsRequest getDot1XConfigurationsRequest = new GetDot1XConfigurationsRequest();
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetDot1XConfigurationsRequest, GetDot1XConfigurationsResponse>(serviceUri, getDot1XConfigurationsRequest, securityHeader);
        }

        public Task<GetCapabilitiesResponse> GetCapabilities(CapabilityCategory[] categories)
        {
            GetCapabilitiesRequest getCapabilitiesRequest = new GetCapabilitiesRequest
            {
                Category = categories
            };
            SoapSecurityHeader securityHeader = getSecurityHeader();

            return doRequestAwaitResponse<GetCapabilitiesRequest, GetCapabilitiesResponse>(serviceUri, getCapabilitiesRequest, securityHeader);
        }
    }
}

