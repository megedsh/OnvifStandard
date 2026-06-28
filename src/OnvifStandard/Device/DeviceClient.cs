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

        public Task<AddIPAddressFilterResponse> AddIPAddressFilter(AddIPAddressFilterRequest addIPAddressFilterRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<AddIPAddressFilterRequest, AddIPAddressFilterResponse>(serviceUri, addIPAddressFilterRequest, securityHeader);
        }

        public Task<AddScopesResponse> AddScopes(AddScopesRequest addScopesRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<AddScopesRequest, AddScopesResponse>(serviceUri, addScopesRequest, securityHeader);
        }

        public Task<CreateCertificateResponse> CreateCertificate(CreateCertificateRequest createCertificateRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<CreateCertificateRequest, CreateCertificateResponse>(serviceUri, createCertificateRequest, securityHeader);
        }

        public Task<CreateDot1XConfigurationResponse> CreateDot1XConfiguration(CreateDot1XConfigurationRequest createDot1XConfigurationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<CreateDot1XConfigurationRequest, CreateDot1XConfigurationResponse>(serviceUri, createDot1XConfigurationRequest, securityHeader);
        }

        public Task<CreateStorageConfigurationResponse> CreateStorageConfiguration(CreateStorageConfigurationRequest createStorageConfigurationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<CreateStorageConfigurationRequest, CreateStorageConfigurationResponse>(serviceUri, createStorageConfigurationRequest, securityHeader);
        }

        public Task<CreateUsersResponse> CreateUsers(CreateUsersRequest createUsersRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<CreateUsersRequest, CreateUsersResponse>(serviceUri, createUsersRequest, securityHeader);
        }

        public Task<DeleteCertificatesResponse> DeleteCertificates(DeleteCertificatesRequest deleteCertificatesRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<DeleteCertificatesRequest, DeleteCertificatesResponse>(serviceUri, deleteCertificatesRequest, securityHeader);
        }

        public Task<DeleteDot1XConfigurationResponse> DeleteDot1XConfiguration(DeleteDot1XConfigurationRequest deleteDot1XConfigurationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<DeleteDot1XConfigurationRequest, DeleteDot1XConfigurationResponse>(serviceUri, deleteDot1XConfigurationRequest, securityHeader);
        }

        public Task<DeleteGeoLocationResponse> DeleteGeoLocation(DeleteGeoLocationRequest deleteGeoLocationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<DeleteGeoLocationRequest, DeleteGeoLocationResponse>(serviceUri, deleteGeoLocationRequest, securityHeader);
        }

        public Task<DeleteStorageConfigurationResponse> DeleteStorageConfiguration(DeleteStorageConfigurationRequest deleteStorageConfigurationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<DeleteStorageConfigurationRequest, DeleteStorageConfigurationResponse>(serviceUri, deleteStorageConfigurationRequest, securityHeader);
        }

        public Task<DeleteUserRoleResponse> DeleteUserRole(DeleteUserRoleRequest deleteUserRoleRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<DeleteUserRoleRequest, DeleteUserRoleResponse>(serviceUri, deleteUserRoleRequest, securityHeader);
        }

        public Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest deleteUsersRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<DeleteUsersRequest, DeleteUsersResponse>(serviceUri, deleteUsersRequest, securityHeader);
        }

        public Task<LoadCACertificatesResponse> LoadCACertificates(LoadCACertificatesRequest loadCACertificatesRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<LoadCACertificatesRequest, LoadCACertificatesResponse>(serviceUri, loadCACertificatesRequest, securityHeader);
        }

        public Task<LoadCertificatesResponse> LoadCertificates(LoadCertificatesRequest loadCertificatesRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<LoadCertificatesRequest, LoadCertificatesResponse>(serviceUri, loadCertificatesRequest, securityHeader);
        }

        public Task<LoadCertificateWithPrivateKeyResponse> LoadCertificateWithPrivateKey(LoadCertificateWithPrivateKeyRequest loadCertificateWithPrivateKeyRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<LoadCertificateWithPrivateKeyRequest, LoadCertificateWithPrivateKeyResponse>(serviceUri, loadCertificateWithPrivateKeyRequest, securityHeader);
        }

        public Task<RemoveIPAddressFilterResponse> RemoveIPAddressFilter(RemoveIPAddressFilterRequest removeIPAddressFilterRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<RemoveIPAddressFilterRequest, RemoveIPAddressFilterResponse>(serviceUri, removeIPAddressFilterRequest, securityHeader);
        }

        public Task<RemoveScopesResponse> RemoveScopes(RemoveScopesRequest removeScopesRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<RemoveScopesRequest, RemoveScopesResponse>(serviceUri, removeScopesRequest, securityHeader);
        }

        public Task<RestoreSystemResponse> RestoreSystem(RestoreSystemRequest restoreSystemRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<RestoreSystemRequest, RestoreSystemResponse>(serviceUri, restoreSystemRequest, securityHeader);
        }

        public Task<ScanAvailableDot11NetworksResponse> ScanAvailableDot11Networks(ScanAvailableDot11NetworksRequest scanAvailableDot11NetworksRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<ScanAvailableDot11NetworksRequest, ScanAvailableDot11NetworksResponse>(serviceUri, scanAvailableDot11NetworksRequest, securityHeader);
        }

        public Task<SendAuxiliaryCommandResponse> SendAuxiliaryCommand(SendAuxiliaryCommandRequest sendAuxiliaryCommandRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SendAuxiliaryCommandRequest, SendAuxiliaryCommandResponse>(serviceUri, sendAuxiliaryCommandRequest, securityHeader);
        }

        public Task<SetAccessPolicyResponse> SetAccessPolicy(SetAccessPolicyRequest setAccessPolicyRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetAccessPolicyRequest, SetAccessPolicyResponse>(serviceUri, setAccessPolicyRequest, securityHeader);
        }

        public Task<SetAuthFailureWarningConfigurationResponse> SetAuthFailureWarningConfiguration(SetAuthFailureWarningConfigurationRequest setAuthFailureWarningConfigurationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetAuthFailureWarningConfigurationRequest, SetAuthFailureWarningConfigurationResponse>(serviceUri, setAuthFailureWarningConfigurationRequest, securityHeader);
        }

        public Task<SetCertificatesStatusResponse> SetCertificatesStatus(SetCertificatesStatusRequest setCertificatesStatusRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetCertificatesStatusRequest, SetCertificatesStatusResponse>(serviceUri, setCertificatesStatusRequest, securityHeader);
        }

        public Task<SetClientCertificateModeResponse> SetClientCertificateMode(SetClientCertificateModeRequest setClientCertificateModeRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetClientCertificateModeRequest, SetClientCertificateModeResponse>(serviceUri, setClientCertificateModeRequest, securityHeader);
        }

        public Task<SetDiscoveryModeResponse> SetDiscoveryMode(SetDiscoveryModeRequest setDiscoveryModeRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetDiscoveryModeRequest, SetDiscoveryModeResponse>(serviceUri, setDiscoveryModeRequest, securityHeader);
        }

        public Task<SetDNSResponse> SetDNS(SetDNSRequest setDNSRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetDNSRequest, SetDNSResponse>(serviceUri, setDNSRequest, securityHeader);
        }

        public Task<SetDot1XConfigurationResponse> SetDot1XConfiguration(SetDot1XConfigurationRequest setDot1XConfigurationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetDot1XConfigurationRequest, SetDot1XConfigurationResponse>(serviceUri, setDot1XConfigurationRequest, securityHeader);
        }

        public Task<SetDPAddressesResponse> SetDPAddresses(SetDPAddressesRequest setDPAddressesRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetDPAddressesRequest, SetDPAddressesResponse>(serviceUri, setDPAddressesRequest, securityHeader);
        }

        public Task<SetDynamicDNSResponse> SetDynamicDNS(SetDynamicDNSRequest setDynamicDNSRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetDynamicDNSRequest, SetDynamicDNSResponse>(serviceUri, setDynamicDNSRequest, securityHeader);
        }

        public Task<SetGeoLocationResponse> SetGeoLocation(SetGeoLocationRequest setGeoLocationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetGeoLocationRequest, SetGeoLocationResponse>(serviceUri, setGeoLocationRequest, securityHeader);
        }

        public Task<SetHashingAlgorithmResponse> SetHashingAlgorithm(SetHashingAlgorithmRequest setHashingAlgorithmRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetHashingAlgorithmRequest, SetHashingAlgorithmResponse>(serviceUri, setHashingAlgorithmRequest, securityHeader);
        }

        public Task<SetHostnameResponse> SetHostname(SetHostnameRequest setHostnameRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetHostnameRequest, SetHostnameResponse>(serviceUri, setHostnameRequest, securityHeader);
        }

        public Task<SetHostnameFromDHCPResponse> SetHostnameFromDHCP(SetHostnameFromDHCPRequest setHostnameFromDHCPRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetHostnameFromDHCPRequest, SetHostnameFromDHCPResponse>(serviceUri, setHostnameFromDHCPRequest, securityHeader);
        }

        public Task<SetIPAddressFilterResponse> SetIPAddressFilter(SetIPAddressFilterRequest setIPAddressFilterRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetIPAddressFilterRequest, SetIPAddressFilterResponse>(serviceUri, setIPAddressFilterRequest, securityHeader);
        }

        public Task<SetNetworkDefaultGatewayResponse> SetNetworkDefaultGateway(SetNetworkDefaultGatewayRequest setNetworkDefaultGatewayRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetNetworkDefaultGatewayRequest, SetNetworkDefaultGatewayResponse>(serviceUri, setNetworkDefaultGatewayRequest, securityHeader);
        }

        public Task<SetNetworkInterfacesResponse> SetNetworkInterfaces(SetNetworkInterfacesRequest setNetworkInterfacesRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetNetworkInterfacesRequest, SetNetworkInterfacesResponse>(serviceUri, setNetworkInterfacesRequest, securityHeader);
        }

        public Task<SetNetworkProtocolsResponse> SetNetworkProtocols(SetNetworkProtocolsRequest setNetworkProtocolsRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetNetworkProtocolsRequest, SetNetworkProtocolsResponse>(serviceUri, setNetworkProtocolsRequest, securityHeader);
        }

        public Task<SetNTPResponse> SetNTP(SetNTPRequest setNTPRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetNTPRequest, SetNTPResponse>(serviceUri, setNTPRequest, securityHeader);
        }

        public Task<SetPasswordComplexityConfigurationResponse> SetPasswordComplexityConfiguration(SetPasswordComplexityConfigurationRequest setPasswordComplexityConfigurationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetPasswordComplexityConfigurationRequest, SetPasswordComplexityConfigurationResponse>(serviceUri, setPasswordComplexityConfigurationRequest, securityHeader);
        }

        public Task<SetPasswordHistoryConfigurationResponse> SetPasswordHistoryConfiguration(SetPasswordHistoryConfigurationRequest setPasswordHistoryConfigurationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetPasswordHistoryConfigurationRequest, SetPasswordHistoryConfigurationResponse>(serviceUri, setPasswordHistoryConfigurationRequest, securityHeader);
        }

        public Task<SetRelayOutputSettingsResponse> SetRelayOutputSettings(SetRelayOutputSettingsRequest setRelayOutputSettingsRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetRelayOutputSettingsRequest, SetRelayOutputSettingsResponse>(serviceUri, setRelayOutputSettingsRequest, securityHeader);
        }

        public Task<SetRelayOutputStateResponse> SetRelayOutputState(SetRelayOutputStateRequest setRelayOutputStateRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetRelayOutputStateRequest, SetRelayOutputStateResponse>(serviceUri, setRelayOutputStateRequest, securityHeader);
        }

        public Task<SetRemoteDiscoveryModeResponse> SetRemoteDiscoveryMode(SetRemoteDiscoveryModeRequest setRemoteDiscoveryModeRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetRemoteDiscoveryModeRequest, SetRemoteDiscoveryModeResponse>(serviceUri, setRemoteDiscoveryModeRequest, securityHeader);
        }

        public Task<SetRemoteUserResponse> SetRemoteUser(SetRemoteUserRequest setRemoteUserRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetRemoteUserRequest, SetRemoteUserResponse>(serviceUri, setRemoteUserRequest, securityHeader);
        }

        public Task<SetScopesResponse> SetScopes(SetScopesRequest setScopesRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetScopesRequest, SetScopesResponse>(serviceUri, setScopesRequest, securityHeader);
        }

        public Task<SetStorageConfigurationResponse> SetStorageConfiguration(SetStorageConfigurationRequest setStorageConfigurationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetStorageConfigurationRequest, SetStorageConfigurationResponse>(serviceUri, setStorageConfigurationRequest, securityHeader);
        }

        public Task<SetSystemDateAndTimeResponse> SetSystemDateAndTime(SetSystemDateAndTimeRequest setSystemDateAndTimeRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetSystemDateAndTimeRequest, SetSystemDateAndTimeResponse>(serviceUri, setSystemDateAndTimeRequest, securityHeader);
        }

        public Task<SetSystemFactoryDefaultResponse> SetSystemFactoryDefault(SetSystemFactoryDefaultRequest setSystemFactoryDefaultRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetSystemFactoryDefaultRequest, SetSystemFactoryDefaultResponse>(serviceUri, setSystemFactoryDefaultRequest, securityHeader);
        }

        public Task<SetUserResponse> SetUser(SetUserRequest setUserRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetUserRequest, SetUserResponse>(serviceUri, setUserRequest, securityHeader);
        }

        public Task<SetUserRoleResponse> SetUserRole(SetUserRoleRequest setUserRoleRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetUserRoleRequest, SetUserRoleResponse>(serviceUri, setUserRoleRequest, securityHeader);
        }

        public Task<SetZeroConfigurationResponse> SetZeroConfiguration(SetZeroConfigurationRequest setZeroConfigurationRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SetZeroConfigurationRequest, SetZeroConfigurationResponse>(serviceUri, setZeroConfigurationRequest, securityHeader);
        }

        public Task<StartFirmwareUpgradeResponse> StartFirmwareUpgrade(StartFirmwareUpgradeRequest startFirmwareUpgradeRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<StartFirmwareUpgradeRequest, StartFirmwareUpgradeResponse>(serviceUri, startFirmwareUpgradeRequest, securityHeader);
        }

        public Task<StartSystemRestoreResponse> StartSystemRestore(StartSystemRestoreRequest startSystemRestoreRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<StartSystemRestoreRequest, StartSystemRestoreResponse>(serviceUri, startSystemRestoreRequest, securityHeader);
        }

        public Task<SystemRebootResponse> SystemReboot(SystemRebootRequest systemRebootRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<SystemRebootRequest, SystemRebootResponse>(serviceUri, systemRebootRequest, securityHeader);
        }

        public Task<UpgradeFirmwareResponse> UpgradeFirmware(UpgradeFirmwareRequest upgradeFirmwareRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<UpgradeFirmwareRequest, UpgradeFirmwareResponse>(serviceUri, upgradeFirmwareRequest, securityHeader);
        }

        public Task<UpgradeSystemFirmwareResponse> UpgradeSystemFirmware(UpgradeSystemFirmwareRequest upgradeSystemFirmwareRequest)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<UpgradeSystemFirmwareRequest, UpgradeSystemFirmwareResponse>(serviceUri, upgradeSystemFirmwareRequest, securityHeader);
        }
    }
}

