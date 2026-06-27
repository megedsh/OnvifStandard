using OnvifStandard.Device;

using SoapHttpClient;

namespace OnvifTests
{
    public class DeviceClientTests
    {
        //http://root:Q1w2e3r4@10.5.23.102/cgi-bin/mjpg/video.cgi?subtype=1
        [Test]
        public void Sanity()
        {
            DeviceClient dc = getSubject();

            GetServicesResponse services = dc.GetServices(false).Result;
            GetServiceCapabilitiesResponse serviceCapabilities = dc.GetServiceCapabilities().Result;
            GetDeviceInformationResponse deviceInformation = dc.GetDeviceInformation().Result;
            GetSystemDateAndTimeResponse systemDateAndTime = dc.GetSystemDateAndTime().Result;
            GetSystemLogResponse systemLog = dc.GetSystemLog(SystemLogType.System).Result;
            GetWsdlUrlResponse wsdlUrl = safeOptionalCall(() => dc.GetWsdlUrl());
            GetScopesResponse scopes = dc.GetScopes().Result;
            GetDiscoveryModeResponse discoveryMode = dc.GetDiscoveryMode().Result;
            GetHostnameResponse hostname = dc.GetHostname().Result;
            GetCapabilitiesResponse capabilities = dc.GetCapabilities(new CapabilityCategory[] { CapabilityCategory.All }).Result;
            GetSystemBackupResponse systemBackup = safeOptionalCall(() => dc.GetSystemBackup());
            GetDPAddressesResponse dpAddresses = safeOptionalCall(() => dc.GetDPAddresses());
            GetUserRolesResponse userRoles = safeOptionalCall(() => dc.GetUserRoles());
            GetUsersResponse users = safeOptionalCall(() => dc.GetUsers());
            GetDNSResponse dns = safeOptionalCall(() => dc.GetDNS());
            GetNTPResponse ntp = safeOptionalCall(() => dc.GetNTP());
            GetDynamicDNSResponse dynamicDns = safeOptionalCall(() => dc.GetDynamicDNS());
            GetNetworkProtocolsResponse networkProtocols = safeOptionalCall(() => dc.GetNetworkProtocols());
            GetNetworkDefaultGatewayResponse networkDefaultGateway = safeOptionalCall(() => dc.GetNetworkDefaultGateway());
            GetZeroConfigurationResponse zeroConfiguration = safeOptionalCall(() => dc.GetZeroConfiguration());
            GetIPAddressFilterResponse ipAddressFilter = safeOptionalCall(() => dc.GetIPAddressFilter());
            GetRemoteUserResponse remoteUser = safeOptionalCall(() => dc.GetRemoteUser());
            GetNetworkInterfacesResponse networkInterfaces = safeOptionalCall(() => dc.GetNetworkInterfaces());
            GetAccessPolicyResponse accessPolicy = safeOptionalCall(() => dc.GetAccessPolicy());
            GetRelayOutputsResponse relayOutputs = safeOptionalCall(() => dc.GetRelayOutputs());
            GetDot11CapabilitiesResponse dot11Capabilities = safeOptionalCall(() => dc.GetDot11Capabilities());
            GetDot11StatusResponse dot11Status = safeOptionalCall(() => dc.GetDot11Status("eth0"));
            GetSystemUrisResponse systemUris = safeOptionalCall(() => dc.GetSystemUris());
            GetStorageConfigurationsResponse storageConfigurations = safeOptionalCall(() => dc.GetStorageConfigurations());
            GetStorageConfigurationResponse storageConfiguration = safeOptionalCall(() => dc.GetStorageConfiguration("StorageToken"));
            GetGeoLocationResponse geoLocation = safeOptionalCall(() => dc.GetGeoLocation());
            GetCertificatesResponse certificates = safeOptionalCall(() => dc.GetCertificates());
            GetCertificatesStatusResponse certificatesStatus = safeOptionalCall(() => dc.GetCertificatesStatus());
            GetPkcs10RequestResponse pkcs10Request = safeOptionalCall(() => dc.GetPkcs10Request("CertID"));
            GetClientCertificateModeResponse clientCertificateMode = safeOptionalCall(() => dc.GetClientCertificateMode());
            GetCACertificatesResponse caCertificates = safeOptionalCall(() => dc.GetCACertificates());
            GetCertificateInformationResponse certificateInformation = safeOptionalCall(() => dc.GetCertificateInformation("CertID"));
            GetDot1XConfigurationResponse dot1XConfiguration = safeOptionalCall(() => dc.GetDot1XConfiguration("Dot1XToken"));
            GetDot1XConfigurationsResponse dot1XConfigurations = safeOptionalCall(() => dc.GetDot1XConfigurations());

            // device not supported - need to validate with a different device
            GetSystemSupportInformationResponse supportInformation = safeOptionalCall(() => dc.GetSystemSupportInformation());
            // device not supported - need to validate with a different device
            GetRemoteDiscoveryModeResponse remoteDiscoveryMode = safeOptionalCall(() => dc.GetRemoteDiscoveryMode());
            // device not supported - need to validate with a different device
            GetEndpointReferenceResponse endpointReference = safeOptionalCall(() => dc.GetEndpointReference());
            // device not supported - need to validate with a different device
            GetPasswordComplexityOptionsResponse passwordComplexityOptions = safeOptionalCall(() => dc.GetPasswordComplexityOptions());
            // device not supported - need to validate with a different device
            GetPasswordComplexityConfigurationResponse passwordComplexityConfiguration = safeOptionalCall(() => dc.GetPasswordComplexityConfiguration());
            // device not supported - need to validate with a different device
            GetPasswordHistoryConfigurationResponse passwordHistoryConfiguration = safeOptionalCall(() => dc.GetPasswordHistoryConfiguration());
            // device not supported - need to validate with a different device
            GetAuthFailureWarningOptionsResponse authFailureWarningOptions = safeOptionalCall(() => dc.GetAuthFailureWarningOptions());
            // device not supported - need to validate with a different device
            GetAuthFailureWarningConfigurationResponse authFailureWarningConfiguration = safeOptionalCall(() => dc.GetAuthFailureWarningConfiguration());

            
        }

        private static T safeOptionalCall<T>(Func<Task<T>> call)
        {
            try
            {
                return call().Result;
            }
            catch
            {
                return default(T);
            }
        }

        private static DeviceClient getSubject()
        {
            DeviceClient dc = new DeviceClient()
            {
                ServiceUri = new Uri("http://10.5.23.102:80/onvif/device_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return dc;
        }
    }
}
