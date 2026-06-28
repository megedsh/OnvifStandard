using System.Threading.Tasks;

namespace OnvifStandard.Device
{
    public class DeviceClient : OnvifSoapClientBase
    {
        public Task<GetServicesResponse> GetServices(bool includeCapability)
        {
            GetServicesRequest getServicesRequest = new GetServicesRequest
            {
                IncludeCapability = includeCapability
            };

            return send<GetServicesRequest, GetServicesResponse>(getServicesRequest);
        }

        public Task<GetDeviceInformationResponse> GetDeviceInformation()
        {
            GetDeviceInformationRequest getDeviceInformationRequest = new GetDeviceInformationRequest();

            return send<GetDeviceInformationRequest, GetDeviceInformationResponse>(getDeviceInformationRequest);
        }

        public Task<GetServiceCapabilitiesResponse> GetServiceCapabilities()
        {
            GetServiceCapabilitiesRequest getServiceCapabilitiesRequest = new GetServiceCapabilitiesRequest();

            return send<GetServiceCapabilitiesRequest, GetServiceCapabilitiesResponse>(getServiceCapabilitiesRequest);
        }

        public Task<GetSystemDateAndTimeResponse> GetSystemDateAndTime()
        {
            GetSystemDateAndTimeRequest getSystemDateAndTimeRequest = new GetSystemDateAndTimeRequest();

            return send<GetSystemDateAndTimeRequest, GetSystemDateAndTimeResponse>(getSystemDateAndTimeRequest);
        }

        public Task<GetSystemLogResponse> GetSystemLog(SystemLogType logType)
        {
            GetSystemLogRequest getSystemLogRequest = new GetSystemLogRequest
            {
                LogType = logType
            };

            return send<GetSystemLogRequest, GetSystemLogResponse>(getSystemLogRequest);
        }

        public Task<GetSystemSupportInformationResponse> GetSystemSupportInformation()
        {
            GetSystemSupportInformationRequest getSystemSupportInformationRequest = new GetSystemSupportInformationRequest();

            return send<GetSystemSupportInformationRequest, GetSystemSupportInformationResponse>(getSystemSupportInformationRequest);
        }

        public Task<GetScopesResponse> GetScopes()
        {
            GetScopesRequest getScopesRequest = new GetScopesRequest();

            return send<GetScopesRequest, GetScopesResponse>(getScopesRequest);
        }

        public Task<GetDiscoveryModeResponse> GetDiscoveryMode()
        {
            GetDiscoveryModeRequest getDiscoveryModeRequest = new GetDiscoveryModeRequest();

            return send<GetDiscoveryModeRequest, GetDiscoveryModeResponse>(getDiscoveryModeRequest);
        }

        public Task<GetRemoteDiscoveryModeResponse> GetRemoteDiscoveryMode()
        {
            GetRemoteDiscoveryModeRequest getRemoteDiscoveryModeRequest = new GetRemoteDiscoveryModeRequest();

            return send<GetRemoteDiscoveryModeRequest, GetRemoteDiscoveryModeResponse>(getRemoteDiscoveryModeRequest);
        }

        public Task<GetWsdlUrlResponse> GetWsdlUrl()
        {
            GetWsdlUrlRequest getWsdlUrlRequest = new GetWsdlUrlRequest();

            return send<GetWsdlUrlRequest, GetWsdlUrlResponse>(getWsdlUrlRequest);
        }

        public Task<GetEndpointReferenceResponse> GetEndpointReference()
        {
            GetEndpointReferenceRequest getEndpointReferenceRequest = new GetEndpointReferenceRequest();

            return send<GetEndpointReferenceRequest, GetEndpointReferenceResponse>(getEndpointReferenceRequest);
        }

        public Task<GetHostnameResponse> GetHostname()
        {
            GetHostnameRequest getHostnameRequest = new GetHostnameRequest();

            return send<GetHostnameRequest, GetHostnameResponse>(getHostnameRequest);
        }

        public Task<GetPasswordComplexityOptionsResponse> GetPasswordComplexityOptions()
        {
            GetPasswordComplexityOptionsRequest getPasswordComplexityOptionsRequest = new GetPasswordComplexityOptionsRequest();

            return send<GetPasswordComplexityOptionsRequest, GetPasswordComplexityOptionsResponse>(getPasswordComplexityOptionsRequest);
        }

        public Task<GetPasswordComplexityConfigurationResponse> GetPasswordComplexityConfiguration()
        {
            GetPasswordComplexityConfigurationRequest getPasswordComplexityConfigurationRequest = new GetPasswordComplexityConfigurationRequest();

            return send<GetPasswordComplexityConfigurationRequest, GetPasswordComplexityConfigurationResponse>(getPasswordComplexityConfigurationRequest);
        }

        public Task<GetPasswordHistoryConfigurationResponse> GetPasswordHistoryConfiguration()
        {
            GetPasswordHistoryConfigurationRequest getPasswordHistoryConfigurationRequest = new GetPasswordHistoryConfigurationRequest();

            return send<GetPasswordHistoryConfigurationRequest, GetPasswordHistoryConfigurationResponse>(getPasswordHistoryConfigurationRequest);
        }

        public Task<GetAuthFailureWarningOptionsResponse> GetAuthFailureWarningOptions()
        {
            GetAuthFailureWarningOptionsRequest getAuthFailureWarningOptionsRequest = new GetAuthFailureWarningOptionsRequest();

            return send<GetAuthFailureWarningOptionsRequest, GetAuthFailureWarningOptionsResponse>(getAuthFailureWarningOptionsRequest);
        }

        public Task<GetAuthFailureWarningConfigurationResponse> GetAuthFailureWarningConfiguration()
        {
            GetAuthFailureWarningConfigurationRequest getAuthFailureWarningConfigurationRequest = new GetAuthFailureWarningConfigurationRequest();

            return send<GetAuthFailureWarningConfigurationRequest, GetAuthFailureWarningConfigurationResponse>(getAuthFailureWarningConfigurationRequest);
        }

        public Task<GetSystemBackupResponse> GetSystemBackup()
        {
            GetSystemBackupRequest getSystemBackupRequest = new GetSystemBackupRequest();

            return send<GetSystemBackupRequest, GetSystemBackupResponse>(getSystemBackupRequest);
        }

        public Task<GetDPAddressesResponse> GetDPAddresses()
        {
            GetDPAddressesRequest getDPAddressesRequest = new GetDPAddressesRequest();

            return send<GetDPAddressesRequest, GetDPAddressesResponse>(getDPAddressesRequest);
        }

        public Task<GetUserRolesResponse> GetUserRoles(string userRole = null)
        {
            GetUserRolesRequest getUserRolesRequest = new GetUserRolesRequest
            {
                UserRole = userRole
            };

            return send<GetUserRolesRequest, GetUserRolesResponse>(getUserRolesRequest);
        }

        public Task<GetUsersResponse> GetUsers()
        {
            GetUsersRequest getUsersRequest = new GetUsersRequest();

            return send<GetUsersRequest, GetUsersResponse>(getUsersRequest);
        }

        public Task<GetDNSResponse> GetDNS()
        {
            GetDNSRequest getDNSRequest = new GetDNSRequest();

            return send<GetDNSRequest, GetDNSResponse>(getDNSRequest);
        }

        public Task<GetNTPResponse> GetNTP()
        {
            GetNTPRequest getNTPRequest = new GetNTPRequest();

            return send<GetNTPRequest, GetNTPResponse>(getNTPRequest);
        }

        public Task<GetDynamicDNSResponse> GetDynamicDNS()
        {
            GetDynamicDNSRequest getDynamicDNSRequest = new GetDynamicDNSRequest();

            return send<GetDynamicDNSRequest, GetDynamicDNSResponse>(getDynamicDNSRequest);
        }

        public Task<GetNetworkProtocolsResponse> GetNetworkProtocols()
        {
            GetNetworkProtocolsRequest getNetworkProtocolsRequest = new GetNetworkProtocolsRequest();

            return send<GetNetworkProtocolsRequest, GetNetworkProtocolsResponse>(getNetworkProtocolsRequest);
        }

        public Task<GetNetworkDefaultGatewayResponse> GetNetworkDefaultGateway()
        {
            GetNetworkDefaultGatewayRequest getNetworkDefaultGatewayRequest = new GetNetworkDefaultGatewayRequest();

            return send<GetNetworkDefaultGatewayRequest, GetNetworkDefaultGatewayResponse>(getNetworkDefaultGatewayRequest);
        }

        public Task<GetZeroConfigurationResponse> GetZeroConfiguration()
        {
            GetZeroConfigurationRequest getZeroConfigurationRequest = new GetZeroConfigurationRequest();

            return send<GetZeroConfigurationRequest, GetZeroConfigurationResponse>(getZeroConfigurationRequest);
        }

        public Task<GetIPAddressFilterResponse> GetIPAddressFilter()
        {
            GetIPAddressFilterRequest getIPAddressFilterRequest = new GetIPAddressFilterRequest();

            return send<GetIPAddressFilterRequest, GetIPAddressFilterResponse>(getIPAddressFilterRequest);
        }

        public Task<GetRemoteUserResponse> GetRemoteUser()
        {
            GetRemoteUserRequest getRemoteUserRequest = new GetRemoteUserRequest();

            return send<GetRemoteUserRequest, GetRemoteUserResponse>(getRemoteUserRequest);
        }

        public Task<GetNetworkInterfacesResponse> GetNetworkInterfaces()
        {
            GetNetworkInterfacesRequest getNetworkInterfacesRequest = new GetNetworkInterfacesRequest();

            return send<GetNetworkInterfacesRequest, GetNetworkInterfacesResponse>(getNetworkInterfacesRequest);
        }

        public Task<GetAccessPolicyResponse> GetAccessPolicy()
        {
            GetAccessPolicyRequest getAccessPolicyRequest = new GetAccessPolicyRequest();

            return send<GetAccessPolicyRequest, GetAccessPolicyResponse>(getAccessPolicyRequest);
        }

        public Task<GetRelayOutputsResponse> GetRelayOutputs()
        {
            GetRelayOutputsRequest getRelayOutputsRequest = new GetRelayOutputsRequest();

            return send<GetRelayOutputsRequest, GetRelayOutputsResponse>(getRelayOutputsRequest);
        }

        public Task<GetDot11CapabilitiesResponse> GetDot11Capabilities()
        {
            GetDot11CapabilitiesRequest getDot11CapabilitiesRequest = new GetDot11CapabilitiesRequest();

            return send<GetDot11CapabilitiesRequest, GetDot11CapabilitiesResponse>(getDot11CapabilitiesRequest);
        }

        public Task<GetDot11StatusResponse> GetDot11Status(string interfaceToken)
        {
            GetDot11StatusRequest getDot11StatusRequest = new GetDot11StatusRequest
            {
                InterfaceToken = interfaceToken
            };

            return send<GetDot11StatusRequest, GetDot11StatusResponse>(getDot11StatusRequest);
        }

        public Task<GetSystemUrisResponse> GetSystemUris()
        {
            GetSystemUrisRequest getSystemUrisRequest = new GetSystemUrisRequest();

            return send<GetSystemUrisRequest, GetSystemUrisResponse>(getSystemUrisRequest);
        }

        public Task<GetStorageConfigurationsResponse> GetStorageConfigurations()
        {
            GetStorageConfigurationsRequest getStorageConfigurationsRequest = new GetStorageConfigurationsRequest();

            return send<GetStorageConfigurationsRequest, GetStorageConfigurationsResponse>(getStorageConfigurationsRequest);
        }

        public Task<GetStorageConfigurationResponse> GetStorageConfiguration(string token)
        {
            GetStorageConfigurationRequest getStorageConfigurationRequest = new GetStorageConfigurationRequest
            {
                Token = token
            };

            return send<GetStorageConfigurationRequest, GetStorageConfigurationResponse>(getStorageConfigurationRequest);
        }

        public Task<GetGeoLocationResponse> GetGeoLocation()
        {
            GetGeoLocationRequest getGeoLocationRequest = new GetGeoLocationRequest();

            return send<GetGeoLocationRequest, GetGeoLocationResponse>(getGeoLocationRequest);
        }

        public Task<GetCertificatesResponse> GetCertificates()
        {
            GetCertificatesRequest getCertificatesRequest = new GetCertificatesRequest();

            return send<GetCertificatesRequest, GetCertificatesResponse>(getCertificatesRequest);
        }

        public Task<GetCertificatesStatusResponse> GetCertificatesStatus()
        {
            GetCertificatesStatusRequest getCertificatesStatusRequest = new GetCertificatesStatusRequest();

            return send<GetCertificatesStatusRequest, GetCertificatesStatusResponse>(getCertificatesStatusRequest);
        }

        public Task<GetPkcs10RequestResponse> GetPkcs10Request(string certificateId, string subject = null, BinaryData attributes = null)
        {
            GetPkcs10Request getPkcs10Request = new GetPkcs10Request
            {
                CertificateID = certificateId,
                Subject = subject,
                Attributes = attributes
            };

            return send<GetPkcs10Request, GetPkcs10RequestResponse>(getPkcs10Request);
        }

        public Task<GetClientCertificateModeResponse> GetClientCertificateMode()
        {
            GetClientCertificateModeRequest getClientCertificateModeRequest = new GetClientCertificateModeRequest();

            return send<GetClientCertificateModeRequest, GetClientCertificateModeResponse>(getClientCertificateModeRequest);
        }

        public Task<GetCACertificatesResponse> GetCACertificates()
        {
            GetCACertificatesRequest getCACertificatesRequest = new GetCACertificatesRequest();

            return send<GetCACertificatesRequest, GetCACertificatesResponse>(getCACertificatesRequest);
        }

        public Task<GetCertificateInformationResponse> GetCertificateInformation(string certificateId)
        {
            GetCertificateInformationRequest getCertificateInformationRequest = new GetCertificateInformationRequest
            {
                CertificateID = certificateId
            };

            return send<GetCertificateInformationRequest, GetCertificateInformationResponse>(getCertificateInformationRequest);
        }

        public Task<GetDot1XConfigurationResponse> GetDot1XConfiguration(string dot1XConfigurationToken)
        {
            GetDot1XConfigurationRequest getDot1XConfigurationRequest = new GetDot1XConfigurationRequest
            {
                Dot1XConfigurationToken = dot1XConfigurationToken
            };

            return send<GetDot1XConfigurationRequest, GetDot1XConfigurationResponse>(getDot1XConfigurationRequest);
        }

        public Task<GetDot1XConfigurationsResponse> GetDot1XConfigurations()
        {
            GetDot1XConfigurationsRequest getDot1XConfigurationsRequest = new GetDot1XConfigurationsRequest();

            return send<GetDot1XConfigurationsRequest, GetDot1XConfigurationsResponse>(getDot1XConfigurationsRequest);
        }

        public Task<GetCapabilitiesResponse> GetCapabilities(CapabilityCategory[] categories)
        {
            GetCapabilitiesRequest getCapabilitiesRequest = new GetCapabilitiesRequest
            {
                Category = categories
            };

            return send<GetCapabilitiesRequest, GetCapabilitiesResponse>(getCapabilitiesRequest);
        }

        public Task<AddIPAddressFilterResponse> AddIPAddressFilter(AddIPAddressFilterRequest addIPAddressFilterRequest) => send<AddIPAddressFilterRequest, AddIPAddressFilterResponse>(addIPAddressFilterRequest);

        public Task<AddScopesResponse> AddScopes(AddScopesRequest addScopesRequest) => send<AddScopesRequest, AddScopesResponse>(addScopesRequest);

        public Task<CreateCertificateResponse> CreateCertificate(CreateCertificateRequest createCertificateRequest) => send<CreateCertificateRequest, CreateCertificateResponse>(createCertificateRequest);

        public Task<CreateDot1XConfigurationResponse> CreateDot1XConfiguration(CreateDot1XConfigurationRequest createDot1XConfigurationRequest) => send<CreateDot1XConfigurationRequest, CreateDot1XConfigurationResponse>(createDot1XConfigurationRequest);

        public Task<CreateStorageConfigurationResponse> CreateStorageConfiguration(CreateStorageConfigurationRequest createStorageConfigurationRequest) => send<CreateStorageConfigurationRequest, CreateStorageConfigurationResponse>(createStorageConfigurationRequest);

        public Task<CreateUsersResponse> CreateUsers(CreateUsersRequest createUsersRequest) => send<CreateUsersRequest, CreateUsersResponse>(createUsersRequest);

        public Task<DeleteCertificatesResponse> DeleteCertificates(DeleteCertificatesRequest deleteCertificatesRequest) => send<DeleteCertificatesRequest, DeleteCertificatesResponse>(deleteCertificatesRequest);

        public Task<DeleteDot1XConfigurationResponse> DeleteDot1XConfiguration(DeleteDot1XConfigurationRequest deleteDot1XConfigurationRequest) => send<DeleteDot1XConfigurationRequest, DeleteDot1XConfigurationResponse>(deleteDot1XConfigurationRequest);

        public Task<DeleteGeoLocationResponse> DeleteGeoLocation(DeleteGeoLocationRequest deleteGeoLocationRequest) => send<DeleteGeoLocationRequest, DeleteGeoLocationResponse>(deleteGeoLocationRequest);

        public Task<DeleteStorageConfigurationResponse> DeleteStorageConfiguration(DeleteStorageConfigurationRequest deleteStorageConfigurationRequest) => send<DeleteStorageConfigurationRequest, DeleteStorageConfigurationResponse>(deleteStorageConfigurationRequest);

        public Task<DeleteUserRoleResponse> DeleteUserRole(DeleteUserRoleRequest deleteUserRoleRequest) => send<DeleteUserRoleRequest, DeleteUserRoleResponse>(deleteUserRoleRequest);

        public Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest deleteUsersRequest) => send<DeleteUsersRequest, DeleteUsersResponse>(deleteUsersRequest);

        public Task<LoadCACertificatesResponse> LoadCACertificates(LoadCACertificatesRequest loadCACertificatesRequest) => send<LoadCACertificatesRequest, LoadCACertificatesResponse>(loadCACertificatesRequest);

        public Task<LoadCertificatesResponse> LoadCertificates(LoadCertificatesRequest loadCertificatesRequest) => send<LoadCertificatesRequest, LoadCertificatesResponse>(loadCertificatesRequest);

        public Task<LoadCertificateWithPrivateKeyResponse> LoadCertificateWithPrivateKey(LoadCertificateWithPrivateKeyRequest loadCertificateWithPrivateKeyRequest) => send<LoadCertificateWithPrivateKeyRequest, LoadCertificateWithPrivateKeyResponse>(loadCertificateWithPrivateKeyRequest);

        public Task<RemoveIPAddressFilterResponse> RemoveIPAddressFilter(RemoveIPAddressFilterRequest removeIPAddressFilterRequest) => send<RemoveIPAddressFilterRequest, RemoveIPAddressFilterResponse>(removeIPAddressFilterRequest);

        public Task<RemoveScopesResponse> RemoveScopes(RemoveScopesRequest removeScopesRequest) => send<RemoveScopesRequest, RemoveScopesResponse>(removeScopesRequest);

        public Task<RestoreSystemResponse> RestoreSystem(RestoreSystemRequest restoreSystemRequest) => send<RestoreSystemRequest, RestoreSystemResponse>(restoreSystemRequest);

        public Task<ScanAvailableDot11NetworksResponse> ScanAvailableDot11Networks(ScanAvailableDot11NetworksRequest scanAvailableDot11NetworksRequest) => send<ScanAvailableDot11NetworksRequest, ScanAvailableDot11NetworksResponse>(scanAvailableDot11NetworksRequest);

        public Task<SendAuxiliaryCommandResponse> SendAuxiliaryCommand(SendAuxiliaryCommandRequest sendAuxiliaryCommandRequest) => send<SendAuxiliaryCommandRequest, SendAuxiliaryCommandResponse>(sendAuxiliaryCommandRequest);

        public Task<SetAccessPolicyResponse> SetAccessPolicy(SetAccessPolicyRequest setAccessPolicyRequest) => send<SetAccessPolicyRequest, SetAccessPolicyResponse>(setAccessPolicyRequest);

        public Task<SetAuthFailureWarningConfigurationResponse> SetAuthFailureWarningConfiguration(SetAuthFailureWarningConfigurationRequest setAuthFailureWarningConfigurationRequest) => send<SetAuthFailureWarningConfigurationRequest, SetAuthFailureWarningConfigurationResponse>(setAuthFailureWarningConfigurationRequest);

        public Task<SetCertificatesStatusResponse> SetCertificatesStatus(SetCertificatesStatusRequest setCertificatesStatusRequest) => send<SetCertificatesStatusRequest, SetCertificatesStatusResponse>(setCertificatesStatusRequest);

        public Task<SetClientCertificateModeResponse> SetClientCertificateMode(SetClientCertificateModeRequest setClientCertificateModeRequest) => send<SetClientCertificateModeRequest, SetClientCertificateModeResponse>(setClientCertificateModeRequest);

        public Task<SetDiscoveryModeResponse> SetDiscoveryMode(SetDiscoveryModeRequest setDiscoveryModeRequest) => send<SetDiscoveryModeRequest, SetDiscoveryModeResponse>(setDiscoveryModeRequest);

        public Task<SetDNSResponse> SetDNS(SetDNSRequest setDNSRequest) => send<SetDNSRequest, SetDNSResponse>(setDNSRequest);

        public Task<SetDot1XConfigurationResponse> SetDot1XConfiguration(SetDot1XConfigurationRequest setDot1XConfigurationRequest) => send<SetDot1XConfigurationRequest, SetDot1XConfigurationResponse>(setDot1XConfigurationRequest);

        public Task<SetDPAddressesResponse> SetDPAddresses(SetDPAddressesRequest setDPAddressesRequest) => send<SetDPAddressesRequest, SetDPAddressesResponse>(setDPAddressesRequest);

        public Task<SetDynamicDNSResponse> SetDynamicDNS(SetDynamicDNSRequest setDynamicDNSRequest) => send<SetDynamicDNSRequest, SetDynamicDNSResponse>(setDynamicDNSRequest);

        public Task<SetGeoLocationResponse> SetGeoLocation(SetGeoLocationRequest setGeoLocationRequest) => send<SetGeoLocationRequest, SetGeoLocationResponse>(setGeoLocationRequest);

        public Task<SetHashingAlgorithmResponse> SetHashingAlgorithm(SetHashingAlgorithmRequest setHashingAlgorithmRequest) => send<SetHashingAlgorithmRequest, SetHashingAlgorithmResponse>(setHashingAlgorithmRequest);

        public Task<SetHostnameResponse> SetHostname(SetHostnameRequest setHostnameRequest) => send<SetHostnameRequest, SetHostnameResponse>(setHostnameRequest);

        public Task<SetHostnameFromDHCPResponse> SetHostnameFromDHCP(SetHostnameFromDHCPRequest setHostnameFromDHCPRequest) => send<SetHostnameFromDHCPRequest, SetHostnameFromDHCPResponse>(setHostnameFromDHCPRequest);

        public Task<SetIPAddressFilterResponse> SetIPAddressFilter(SetIPAddressFilterRequest setIPAddressFilterRequest) => send<SetIPAddressFilterRequest, SetIPAddressFilterResponse>(setIPAddressFilterRequest);

        public Task<SetNetworkDefaultGatewayResponse> SetNetworkDefaultGateway(SetNetworkDefaultGatewayRequest setNetworkDefaultGatewayRequest) => send<SetNetworkDefaultGatewayRequest, SetNetworkDefaultGatewayResponse>(setNetworkDefaultGatewayRequest);

        public Task<SetNetworkInterfacesResponse> SetNetworkInterfaces(SetNetworkInterfacesRequest setNetworkInterfacesRequest) => send<SetNetworkInterfacesRequest, SetNetworkInterfacesResponse>(setNetworkInterfacesRequest);

        public Task<SetNetworkProtocolsResponse> SetNetworkProtocols(SetNetworkProtocolsRequest setNetworkProtocolsRequest) => send<SetNetworkProtocolsRequest, SetNetworkProtocolsResponse>(setNetworkProtocolsRequest);

        public Task<SetNTPResponse> SetNTP(SetNTPRequest setNTPRequest) => send<SetNTPRequest, SetNTPResponse>(setNTPRequest);

        public Task<SetPasswordComplexityConfigurationResponse> SetPasswordComplexityConfiguration(SetPasswordComplexityConfigurationRequest setPasswordComplexityConfigurationRequest) => send<SetPasswordComplexityConfigurationRequest, SetPasswordComplexityConfigurationResponse>(setPasswordComplexityConfigurationRequest);

        public Task<SetPasswordHistoryConfigurationResponse> SetPasswordHistoryConfiguration(SetPasswordHistoryConfigurationRequest setPasswordHistoryConfigurationRequest) => send<SetPasswordHistoryConfigurationRequest, SetPasswordHistoryConfigurationResponse>(setPasswordHistoryConfigurationRequest);

        public Task<SetRelayOutputSettingsResponse> SetRelayOutputSettings(SetRelayOutputSettingsRequest setRelayOutputSettingsRequest) => send<SetRelayOutputSettingsRequest, SetRelayOutputSettingsResponse>(setRelayOutputSettingsRequest);

        public Task<SetRelayOutputStateResponse> SetRelayOutputState(SetRelayOutputStateRequest setRelayOutputStateRequest) => send<SetRelayOutputStateRequest, SetRelayOutputStateResponse>(setRelayOutputStateRequest);

        public Task<SetRemoteDiscoveryModeResponse> SetRemoteDiscoveryMode(SetRemoteDiscoveryModeRequest setRemoteDiscoveryModeRequest) => send<SetRemoteDiscoveryModeRequest, SetRemoteDiscoveryModeResponse>(setRemoteDiscoveryModeRequest);

        public Task<SetRemoteUserResponse> SetRemoteUser(SetRemoteUserRequest setRemoteUserRequest) => send<SetRemoteUserRequest, SetRemoteUserResponse>(setRemoteUserRequest);

        public Task<SetScopesResponse> SetScopes(SetScopesRequest setScopesRequest) => send<SetScopesRequest, SetScopesResponse>(setScopesRequest);

        public Task<SetStorageConfigurationResponse> SetStorageConfiguration(SetStorageConfigurationRequest setStorageConfigurationRequest) => send<SetStorageConfigurationRequest, SetStorageConfigurationResponse>(setStorageConfigurationRequest);

        public Task<SetSystemDateAndTimeResponse> SetSystemDateAndTime(SetSystemDateAndTimeRequest setSystemDateAndTimeRequest) => send<SetSystemDateAndTimeRequest, SetSystemDateAndTimeResponse>(setSystemDateAndTimeRequest);

        public Task<SetSystemFactoryDefaultResponse> SetSystemFactoryDefault(SetSystemFactoryDefaultRequest setSystemFactoryDefaultRequest) => send<SetSystemFactoryDefaultRequest, SetSystemFactoryDefaultResponse>(setSystemFactoryDefaultRequest);

        public Task<SetUserResponse> SetUser(SetUserRequest setUserRequest) => send<SetUserRequest, SetUserResponse>(setUserRequest);

        public Task<SetUserRoleResponse> SetUserRole(SetUserRoleRequest setUserRoleRequest) => send<SetUserRoleRequest, SetUserRoleResponse>(setUserRoleRequest);

        public Task<SetZeroConfigurationResponse> SetZeroConfiguration(SetZeroConfigurationRequest setZeroConfigurationRequest) => send<SetZeroConfigurationRequest, SetZeroConfigurationResponse>(setZeroConfigurationRequest);

        public Task<StartFirmwareUpgradeResponse> StartFirmwareUpgrade(StartFirmwareUpgradeRequest startFirmwareUpgradeRequest) => send<StartFirmwareUpgradeRequest, StartFirmwareUpgradeResponse>(startFirmwareUpgradeRequest);

        public Task<StartSystemRestoreResponse> StartSystemRestore(StartSystemRestoreRequest startSystemRestoreRequest) => send<StartSystemRestoreRequest, StartSystemRestoreResponse>(startSystemRestoreRequest);

        public Task<SystemRebootResponse> SystemReboot(SystemRebootRequest systemRebootRequest) => send<SystemRebootRequest, SystemRebootResponse>(systemRebootRequest);

        public Task<UpgradeFirmwareResponse> UpgradeFirmware(UpgradeFirmwareRequest upgradeFirmwareRequest) => send<UpgradeFirmwareRequest, UpgradeFirmwareResponse>(upgradeFirmwareRequest);

        public Task<UpgradeSystemFirmwareResponse> UpgradeSystemFirmware(UpgradeSystemFirmwareRequest upgradeSystemFirmwareRequest) => send<UpgradeSystemFirmwareRequest, UpgradeSystemFirmwareResponse>(upgradeSystemFirmwareRequest);
    }
}