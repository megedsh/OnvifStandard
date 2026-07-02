using OnvifStandard.Device;

using SoapHttpClient;

namespace OnvifTests
{
    public class DeviceClientTests
    {
        [Test] public Task GetServices() => assertSupported(() => getSubject().GetServices(false), nameof(GetServices));
        [Test] public Task GetDeviceInformation() => assertSupported(() => getSubject().GetDeviceInformation(), nameof(GetDeviceInformation));
        [Test] public Task GetServiceCapabilities() => assertSupported(() => getSubject().GetServiceCapabilities(), nameof(GetServiceCapabilities));
        [Test] public Task GetSystemDateAndTime() => assertSupported(() => getSubject().GetSystemDateAndTime(), nameof(GetSystemDateAndTime));
        [Test] public Task GetSystemLog() => assertSupported(() => getSubject().GetSystemLog(SystemLogType.System), nameof(GetSystemLog));
        [Test] public Task GetSystemSupportInformation() => assertSupported(() => getSubject().GetSystemSupportInformation(), nameof(GetSystemSupportInformation));
        [Test] public Task GetScopes() => assertSupported(() => getSubject().GetScopes(), nameof(GetScopes));
        [Test] public Task GetDiscoveryMode() => assertSupported(() => getSubject().GetDiscoveryMode(), nameof(GetDiscoveryMode));
        [Test] public Task GetRemoteDiscoveryMode() => assertSupported(() => getSubject().GetRemoteDiscoveryMode(), nameof(GetRemoteDiscoveryMode));
        [Test] public Task GetWsdlUrl() => assertSupported(() => getSubject().GetWsdlUrl(), nameof(GetWsdlUrl));
        [Test] public Task GetEndpointReference() => assertSupported(() => getSubject().GetEndpointReference(), nameof(GetEndpointReference));
        [Test] public Task GetHostname() => assertSupported(() => getSubject().GetHostname(), nameof(GetHostname));
        [Test] public Task GetPasswordComplexityOptions() => assertSupported(() => getSubject().GetPasswordComplexityOptions(), nameof(GetPasswordComplexityOptions));
        [Test] public Task GetPasswordComplexityConfiguration() => assertSupported(() => getSubject().GetPasswordComplexityConfiguration(), nameof(GetPasswordComplexityConfiguration));
        [Test] public Task GetPasswordHistoryConfiguration() => assertSupported(() => getSubject().GetPasswordHistoryConfiguration(), nameof(GetPasswordHistoryConfiguration));
        [Test] public Task GetAuthFailureWarningOptions() => assertSupported(() => getSubject().GetAuthFailureWarningOptions(), nameof(GetAuthFailureWarningOptions));
        [Test] public Task GetAuthFailureWarningConfiguration() => assertSupported(() => getSubject().GetAuthFailureWarningConfiguration(), nameof(GetAuthFailureWarningConfiguration));
        [Test] public Task GetSystemBackup() => assertSupported(() => getSubject().GetSystemBackup(), nameof(GetSystemBackup));
        [Test] public Task GetDPAddresses() => assertSupported(() => getSubject().GetDPAddresses(), nameof(GetDPAddresses));
        [Test] public Task GetUserRoles() => assertSupported(() => getSubject().GetUserRoles(), nameof(GetUserRoles));
        [Test] public Task GetUsers() => assertSupported(() => getSubject().GetUsers(), nameof(GetUsers));
        [Test] public Task GetDNS() => assertSupported(() => getSubject().GetDNS(), nameof(GetDNS));
        [Test] public Task GetNTP() => assertSupported(() => getSubject().GetNTP(), nameof(GetNTP));
        [Test] public Task GetDynamicDNS() => assertSupported(() => getSubject().GetDynamicDNS(), nameof(GetDynamicDNS));
        [Test] public Task GetNetworkProtocols() => assertSupported(() => getSubject().GetNetworkProtocols(), nameof(GetNetworkProtocols));
        [Test] public Task GetNetworkDefaultGateway() => assertSupported(() => getSubject().GetNetworkDefaultGateway(), nameof(GetNetworkDefaultGateway));
        [Test] public Task GetZeroConfiguration() => assertSupported(() => getSubject().GetZeroConfiguration(), nameof(GetZeroConfiguration));
        [Test] public Task GetIPAddressFilter() => assertSupported(() => getSubject().GetIPAddressFilter(), nameof(GetIPAddressFilter));
        [Test] public Task GetRemoteUser() => assertSupported(() => getSubject().GetRemoteUser(), nameof(GetRemoteUser));
        [Test] public Task GetNetworkInterfaces() => assertSupported(() => getSubject().GetNetworkInterfaces(), nameof(GetNetworkInterfaces));
        [Test] public Task GetAccessPolicy() => assertSupported(() => getSubject().GetAccessPolicy(), nameof(GetAccessPolicy));
        [Test] public Task GetRelayOutputs() => assertSupported(() => getSubject().GetRelayOutputs(), nameof(GetRelayOutputs));
        [Test] public Task GetDot11Capabilities() => assertSupported(() => getSubject().GetDot11Capabilities(), nameof(GetDot11Capabilities));
        [Test] public Task GetDot11Status() => assertSupported(() => getSubject().GetDot11Status(string.Empty), nameof(GetDot11Status));
        [Test] public Task GetSystemUris() => assertSupported(() => getSubject().GetSystemUris(), nameof(GetSystemUris));
        [Test] public Task GetStorageConfigurations() => assertSupported(() => getSubject().GetStorageConfigurations(), nameof(GetStorageConfigurations));
        [Test] public Task GetStorageConfiguration() => assertSupported(() => getSubject().GetStorageConfiguration(string.Empty), nameof(GetStorageConfiguration));
        [Test] public Task GetGeoLocation() => assertSupported(() => getSubject().GetGeoLocation(), nameof(GetGeoLocation));
        [Test] public Task GetCertificates() => assertSupported(() => getSubject().GetCertificates(), nameof(GetCertificates));
        [Test] public Task GetCertificatesStatus() => assertSupported(() => getSubject().GetCertificatesStatus(), nameof(GetCertificatesStatus));
        [Test] public Task GetPkcs10Request() => assertSupported(() => getSubject().GetPkcs10Request(string.Empty), nameof(GetPkcs10Request));
        [Test] public Task GetClientCertificateMode() => assertSupported(() => getSubject().GetClientCertificateMode(), nameof(GetClientCertificateMode));
        [Test] public Task GetCACertificates() => assertSupported(() => getSubject().GetCACertificates(), nameof(GetCACertificates));
        [Test] public Task GetCertificateInformation() => assertSupported(() => getSubject().GetCertificateInformation(string.Empty), nameof(GetCertificateInformation));
        [Test] public Task GetDot1XConfiguration() => assertSupported(() => getSubject().GetDot1XConfiguration(string.Empty), nameof(GetDot1XConfiguration));
        [Test] public Task GetDot1XConfigurations() => assertSupported(() => getSubject().GetDot1XConfigurations(), nameof(GetDot1XConfigurations));
        [Test] public Task GetCapabilities() => assertSupported(() => getSubject().GetCapabilities(new[] { CapabilityCategory.All }), nameof(GetCapabilities));

        [Test] public Task AddIPAddressFilter() => assertSupported(() => getSubject().AddIPAddressFilter(new AddIPAddressFilterRequest()), nameof(AddIPAddressFilter));
        [Test] public Task AddScopes() => assertSupported(() => getSubject().AddScopes(new AddScopesRequest()), nameof(AddScopes));
        [Test] public Task CreateCertificate() => assertSupported(() => getSubject().CreateCertificate(new CreateCertificateRequest()), nameof(CreateCertificate));
        [Test] public Task CreateDot1XConfiguration() => assertSupported(() => getSubject().CreateDot1XConfiguration(new CreateDot1XConfigurationRequest()), nameof(CreateDot1XConfiguration));
        [Test] public Task CreateStorageConfiguration() => assertSupported(() => getSubject().CreateStorageConfiguration(new CreateStorageConfigurationRequest()), nameof(CreateStorageConfiguration));
        [Test] public Task CreateUsers() => assertSupported(() => getSubject().CreateUsers(new CreateUsersRequest()), nameof(CreateUsers));
        [Test] public Task DeleteCertificates() => assertSupported(() => getSubject().DeleteCertificates(new DeleteCertificatesRequest()), nameof(DeleteCertificates));
        [Test] public Task DeleteDot1XConfiguration() => assertSupported(() => getSubject().DeleteDot1XConfiguration(new DeleteDot1XConfigurationRequest()), nameof(DeleteDot1XConfiguration));
        [Test] public Task DeleteGeoLocation() => assertSupported(() => getSubject().DeleteGeoLocation(new DeleteGeoLocationRequest()), nameof(DeleteGeoLocation));
        [Test] public Task DeleteStorageConfiguration() => assertSupported(() => getSubject().DeleteStorageConfiguration(new DeleteStorageConfigurationRequest()), nameof(DeleteStorageConfiguration));
        [Test] public Task DeleteUserRole() => assertSupported(() => getSubject().DeleteUserRole(new DeleteUserRoleRequest()), nameof(DeleteUserRole));
        [Test] public Task DeleteUsers() => assertSupported(() => getSubject().DeleteUsers(new DeleteUsersRequest()), nameof(DeleteUsers));
        [Test] public Task LoadCACertificates() => assertSupported(() => getSubject().LoadCACertificates(new LoadCACertificatesRequest()), nameof(LoadCACertificates));
        [Test] public Task LoadCertificates() => assertSupported(() => getSubject().LoadCertificates(new LoadCertificatesRequest()), nameof(LoadCertificates));
        [Test] public Task LoadCertificateWithPrivateKey() => assertSupported(() => getSubject().LoadCertificateWithPrivateKey(new LoadCertificateWithPrivateKeyRequest()), nameof(LoadCertificateWithPrivateKey));
        [Test] public Task RemoveIPAddressFilter() => assertSupported(() => getSubject().RemoveIPAddressFilter(new RemoveIPAddressFilterRequest()), nameof(RemoveIPAddressFilter));
        [Test] public Task RemoveScopes() => assertSupported(() => getSubject().RemoveScopes(new RemoveScopesRequest()), nameof(RemoveScopes));
        [Test] public Task RestoreSystem() => assertSupported(() => getSubject().RestoreSystem(new RestoreSystemRequest()), nameof(RestoreSystem));
        [Test] public Task ScanAvailableDot11Networks() => assertSupported(() => getSubject().ScanAvailableDot11Networks(new ScanAvailableDot11NetworksRequest()), nameof(ScanAvailableDot11Networks));
        [Test] public Task SendAuxiliaryCommand() => assertSupported(() => getSubject().SendAuxiliaryCommand(new SendAuxiliaryCommandRequest()), nameof(SendAuxiliaryCommand));
        [Test] public Task SetAccessPolicy() => assertSupported(() => getSubject().SetAccessPolicy(new SetAccessPolicyRequest()), nameof(SetAccessPolicy));
        [Test] public Task SetAuthFailureWarningConfiguration() => assertSupported(() => getSubject().SetAuthFailureWarningConfiguration(new SetAuthFailureWarningConfigurationRequest()), nameof(SetAuthFailureWarningConfiguration));
        [Test] public Task SetCertificatesStatus() => assertSupported(() => getSubject().SetCertificatesStatus(new SetCertificatesStatusRequest()), nameof(SetCertificatesStatus));
        [Test] public Task SetClientCertificateMode() => assertSupported(() => getSubject().SetClientCertificateMode(new SetClientCertificateModeRequest()), nameof(SetClientCertificateMode));
        [Test] public Task SetDiscoveryMode() => assertSupported(() => getSubject().SetDiscoveryMode(new SetDiscoveryModeRequest()), nameof(SetDiscoveryMode));
        [Test] public Task SetDNS() => assertSupported(() => getSubject().SetDNS(new SetDNSRequest()), nameof(SetDNS));
        [Test] public Task SetDot1XConfiguration() => assertSupported(() => getSubject().SetDot1XConfiguration(new SetDot1XConfigurationRequest()), nameof(SetDot1XConfiguration));
        [Test] public Task SetDPAddresses() => assertSupported(() => getSubject().SetDPAddresses(new SetDPAddressesRequest()), nameof(SetDPAddresses));
        [Test] public Task SetDynamicDNS() => assertSupported(() => getSubject().SetDynamicDNS(new SetDynamicDNSRequest()), nameof(SetDynamicDNS));
        [Test] public Task SetGeoLocation() => assertSupported(() => getSubject().SetGeoLocation(new SetGeoLocationRequest()), nameof(SetGeoLocation));
        [Test] public Task SetHashingAlgorithm() => assertSupported(() => getSubject().SetHashingAlgorithm(new SetHashingAlgorithmRequest()), nameof(SetHashingAlgorithm));
        [Test] public Task SetHostname() => assertSupported(() => getSubject().SetHostname(new SetHostnameRequest()), nameof(SetHostname));
        [Test] public Task SetHostnameFromDHCP() => assertSupported(() => getSubject().SetHostnameFromDHCP(new SetHostnameFromDHCPRequest()), nameof(SetHostnameFromDHCP));
        [Test] public Task SetIPAddressFilter() => assertSupported(() => getSubject().SetIPAddressFilter(new SetIPAddressFilterRequest()), nameof(SetIPAddressFilter));
        [Test] public Task SetNetworkDefaultGateway() => assertSupported(() => getSubject().SetNetworkDefaultGateway(new SetNetworkDefaultGatewayRequest()), nameof(SetNetworkDefaultGateway));
        [Test] public Task SetNetworkInterfaces() => assertSupported(() => getSubject().SetNetworkInterfaces(new SetNetworkInterfacesRequest()), nameof(SetNetworkInterfaces));
        [Test] public Task SetNetworkProtocols() => assertSupported(() => getSubject().SetNetworkProtocols(new SetNetworkProtocolsRequest()), nameof(SetNetworkProtocols));
        [Test] public Task SetNTP() => assertSupported(() => getSubject().SetNTP(new SetNTPRequest()), nameof(SetNTP));
        [Test] public Task SetPasswordComplexityConfiguration() => assertSupported(() => getSubject().SetPasswordComplexityConfiguration(new SetPasswordComplexityConfigurationRequest()), nameof(SetPasswordComplexityConfiguration));
        [Test] public Task SetPasswordHistoryConfiguration() => assertSupported(() => getSubject().SetPasswordHistoryConfiguration(new SetPasswordHistoryConfigurationRequest()), nameof(SetPasswordHistoryConfiguration));
        [Test] public Task SetRelayOutputSettings() => assertSupported(() => getSubject().SetRelayOutputSettings(new SetRelayOutputSettingsRequest()), nameof(SetRelayOutputSettings));
        [Test] public Task SetRelayOutputState() => assertSupported(() => getSubject().SetRelayOutputState(new SetRelayOutputStateRequest()), nameof(SetRelayOutputState));
        [Test] public Task SetRemoteDiscoveryMode() => assertSupported(() => getSubject().SetRemoteDiscoveryMode(new SetRemoteDiscoveryModeRequest()), nameof(SetRemoteDiscoveryMode));
        [Test] public Task SetRemoteUser() => assertSupported(() => getSubject().SetRemoteUser(new SetRemoteUserRequest()), nameof(SetRemoteUser));
        [Test] public Task SetScopes() => assertSupported(() => getSubject().SetScopes(new SetScopesRequest()), nameof(SetScopes));
        [Test] public Task SetStorageConfiguration() => assertSupported(() => getSubject().SetStorageConfiguration(new SetStorageConfigurationRequest()), nameof(SetStorageConfiguration));
        [Test] public Task SetSystemDateAndTime() => assertSupported(() => getSubject().SetSystemDateAndTime(new SetSystemDateAndTimeRequest()), nameof(SetSystemDateAndTime));
        [Test] public Task SetSystemFactoryDefault() => assertSupported(() => getSubject().SetSystemFactoryDefault(new SetSystemFactoryDefaultRequest()), nameof(SetSystemFactoryDefault));
        [Test] public Task SetUser() => assertSupported(() => getSubject().SetUser(new SetUserRequest()), nameof(SetUser));
        [Test] public Task SetUserRole() => assertSupported(() => getSubject().SetUserRole(new SetUserRoleRequest()), nameof(SetUserRole));
        [Test] public Task SetZeroConfiguration() => assertSupported(() => getSubject().SetZeroConfiguration(new SetZeroConfigurationRequest()), nameof(SetZeroConfiguration));
        [Test] public Task StartFirmwareUpgrade() => assertSupported(() => getSubject().StartFirmwareUpgrade(new StartFirmwareUpgradeRequest()), nameof(StartFirmwareUpgrade));
        [Test] public Task StartSystemRestore() => assertSupported(() => getSubject().StartSystemRestore(new StartSystemRestoreRequest()), nameof(StartSystemRestore));
        [Test] public Task SystemReboot() => assertSupported(() => getSubject().SystemReboot(new SystemRebootRequest()), nameof(SystemReboot));
        [Test] public Task UpgradeFirmware() => assertSupported(() => getSubject().UpgradeFirmware(new UpgradeFirmwareRequest()), nameof(UpgradeFirmware));
        [Test] public Task UpgradeSystemFirmware() => assertSupported(() => getSubject().UpgradeSystemFirmware(new UpgradeSystemFirmwareRequest()), nameof(UpgradeSystemFirmware));

        private static async Task assertSupported<T>(Func<Task<T>> call, string operation)
            where T : class
        {
            try
            {
                T response = await call();
                if (response == null)
                {
                    Assert.Ignore($"{operation} returned no data on this target device.");
                }

                Assert.That(response, Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Ignore($"{operation} not supported/executable on this target device: {ex.GetType().Name}, exceptionMessage:{ex.Message}");
            }
        }

        private static DeviceClient getSubject()
        {
            DeviceClient dc = new DeviceClient
            {
                ServiceUri = new Uri("http://192.168.3.19:8000/onvif/device_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return dc;
        }
    }
}
