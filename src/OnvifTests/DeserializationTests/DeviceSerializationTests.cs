using System.Xml.Serialization;

using OnvifStandard;
using OnvifStandard.Common;
using OnvifStandard.Device;

namespace OnvifTests.DeserializationTests
{
    public class DeviceSerializationTests
    {
        [Test]
        public void DeviceResponsesSerializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetCapabilitiesResponse.xml");

            Assert.That(envelope,                                                                         Is.Not.Null);
            Assert.That(envelope.Body,                                                                    Is.Not.Null);
            GetCapabilitiesResponse response = envelope.GetFromEnvelope<GetCapabilitiesResponse>();
            Assert.That(response, Is.Not.Null);

            
            Assert.That(response.Capabilities, Is.Not.Null);

            Assert.That(response.Capabilities.Device.XAddr,    Is.EqualTo("http://10.5.23.102/onvif/device_service"));
            Assert.That(response.Capabilities.Media.XAddr,     Is.EqualTo("http://10.5.23.102/onvif/media_service"));
            Assert.That(response.Capabilities.PTZ.XAddr,       Is.EqualTo("http://10.5.23.102/onvif/ptz_service"));
            Assert.That(response.Capabilities.Events.XAddr,    Is.EqualTo("http://10.5.23.102/onvif/event_service"));
            Assert.That(response.Capabilities.Imaging.XAddr,   Is.EqualTo("http://10.5.23.102/onvif/imaging_service"));
            Assert.That(response.Capabilities.Analytics.XAddr, Is.EqualTo("http://10.5.23.102/onvif/analytics_service"));

            Assert.That(response.Capabilities.Analytics.RuleSupport,            Is.True);
            Assert.That(response.Capabilities.Analytics.AnalyticsModuleSupport, Is.True);

            Assert.That(response.Capabilities.Device.Network,                              Is.Not.Null);
            Assert.That(response.Capabilities.Device.Network.IPVersion6,                   Is.False);
            Assert.That(response.Capabilities.Device.Network.Extension.Dot11Configuration, Is.False);

            Assert.That(response.Capabilities.Device.System,                               Is.Not.Null);
            Assert.That(response.Capabilities.Device.System.FirmwareUpgrade,               Is.True);
            Assert.That(response.Capabilities.Device.System.SupportedVersions,             Is.Not.Null);
            Assert.That(response.Capabilities.Device.System.SupportedVersions.Length,      Is.EqualTo(9));
            Assert.That(response.Capabilities.Device.System.Extension.HttpFirmwareUpgrade, Is.True);

            Assert.That(response.Capabilities.Device.IO,                 Is.Not.Null);
            Assert.That(response.Capabilities.Device.IO.InputConnectors, Is.EqualTo(2));
            Assert.That(response.Capabilities.Device.IO.RelayOutputs,    Is.EqualTo(1));

            Assert.That(response.Capabilities.Device.Security,                           Is.Not.Null);
            Assert.That(response.Capabilities.Device.Security.TLS11,                     Is.False);
            Assert.That(response.Capabilities.Device.Security.Extension.TLS10,           Is.False);
            Assert.That(response.Capabilities.Device.Security.Extension.Extension.Dot1X, Is.False);

            Assert.That(response.Capabilities.Extension,                       Is.Not.Null);
            Assert.That(response.Capabilities.Extension.DeviceIO,              Is.Not.Null);
            Assert.That(response.Capabilities.Extension.DeviceIO.XAddr,        Is.EqualTo("http://10.5.23.102/onvif/deviceIO_service"));
            Assert.That(response.Capabilities.Extension.DeviceIO.VideoSources, Is.EqualTo(1));
        }

        [Test]
        public void GetDeviceInformationResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetDeviceInformationResponse.xml");

            Assert.That(envelope,                                   Is.Not.Null);
            Assert.That(envelope.Body,                              Is.Not.Null);
            GetDeviceInformationResponse response = envelope.GetFromEnvelope<GetDeviceInformationResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Manufacturer,    Is.EqualTo("Dahua"));
            Assert.That(response.Model,           Is.EqualTo("DH-SD42212T-HN"));
            Assert.That(response.FirmwareVersion, Is.EqualTo("2.800.0000000.4.R, Build Date 2019-11-05"));
            Assert.That(response.SerialNumber,    Is.EqualTo("6F027CAPANBB8C4"));
            Assert.That(response.HardwareId,      Is.EqualTo("1.00"));
        }

        [Test]
        public void GetServicesResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetServicesResponse.xml");

            Assert.That(envelope,                          Is.Not.Null);
            Assert.That(envelope.Body,                     Is.Not.Null);
            GetServicesResponse response = envelope.GetFromEnvelope<GetServicesResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Service,        Is.Not.Null);
            Assert.That(response.Service.Length, Is.GreaterThan(0));

            Assert.That(response.Service[0].Namespace, Is.Not.Null.And.Not.Empty);
            Assert.That(response.Service[0].XAddr,     Is.Not.Null.And.Not.Empty);
            Assert.That(response.Service[0].Version,   Is.Not.Null);
        }

        [Test]
        public void GetServiceCapabilitiesResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetServiceCapabilitiesResponse.xml");

            Assert.That(envelope,                                     Is.Not.Null);
            Assert.That(envelope.Body,                                Is.Not.Null);
            GetServiceCapabilitiesResponse response = envelope.GetFromEnvelope<GetServiceCapabilitiesResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Capabilities,          Is.Not.Null);
            Assert.That(response.Capabilities.Network,  Is.Not.Null);
            Assert.That(response.Capabilities.Security, Is.Not.Null);
            Assert.That(response.Capabilities.System,   Is.Not.Null);
        }

        [Test]
        public void GetSystemDateAndTimeResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetSystemDateAndTimeResponse.xml");

            Assert.That(envelope,                                   Is.Not.Null);
            Assert.That(envelope.Body,                              Is.Not.Null);
            GetSystemDateAndTimeResponse response = envelope.GetFromEnvelope<GetSystemDateAndTimeResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.SystemDateAndTime,                  Is.Not.Null);
            Assert.That(response.SystemDateAndTime.DateTimeType,     Is.AnyOf(SetDateTimeType.Manual, SetDateTimeType.NTP));
            Assert.That(response.SystemDateAndTime.UTCDateTime,      Is.Not.Null);
            Assert.That(response.SystemDateAndTime.UTCDateTime.Date, Is.Not.Null);
            Assert.That(response.SystemDateAndTime.UTCDateTime.Time, Is.Not.Null);
        }

        [Test]
        public void GetSystemLogResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetSystemLogResponse.xml");

            Assert.That(envelope,                           Is.Not.Null);
            Assert.That(envelope.Body,                      Is.Not.Null);
            GetSystemLogResponse response = envelope.GetFromEnvelope<GetSystemLogResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.SystemLog,        Is.Not.Null);
            Assert.That(response.SystemLog.String, Is.Not.Null.Or.Not.Empty);
        }

        [Test]
        [Ignore("Device returns SOAP Fault for optional GetSystemSupportInformation; success response fixture is intentionally not saved.")]
        public void GetSystemSupportInformationResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetSystemSupportInformationResponse.xml");

            Assert.That(envelope,                                          Is.Not.Null);
            Assert.That(envelope.Body,                                     Is.Not.Null);
            GetSystemSupportInformationResponse response = envelope.GetFromEnvelope<GetSystemSupportInformationResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.SupportInformation, Is.Not.Null);
        }

        [Test]
        public void GetScopesResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetScopesResponse.xml");

            Assert.That(envelope,                        Is.Not.Null);
            Assert.That(envelope.Body,                   Is.Not.Null);
            GetScopesResponse response = envelope.GetFromEnvelope<GetScopesResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Scopes,              Is.Not.Null);
            Assert.That(response.Scopes.Length,       Is.GreaterThan(0));
            Assert.That(response.Scopes[0].ScopeItem, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void GetDiscoveryModeResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetDiscoveryModeResponse.xml");

            Assert.That(envelope,                               Is.Not.Null);
            Assert.That(envelope.Body,                          Is.Not.Null);
            GetDiscoveryModeResponse response = envelope.GetFromEnvelope<GetDiscoveryModeResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.DiscoveryMode, Is.AnyOf(DiscoveryMode.Discoverable, DiscoveryMode.NonDiscoverable));
        }

        [Test]
        [Ignore("Device does not return valid SOAP XML for GetRemoteDiscoveryMode on this target; fixture is intentionally not saved.")]
        public void GetRemoteDiscoveryModeResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetRemoteDiscoveryModeResponse.xml");

            Assert.That(envelope,                                     Is.Not.Null);
            Assert.That(envelope.Body,                                Is.Not.Null);
            GetRemoteDiscoveryModeResponse response = envelope.GetFromEnvelope<GetRemoteDiscoveryModeResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.RemoteDiscoveryMode, Is.AnyOf(DiscoveryMode.Discoverable, DiscoveryMode.NonDiscoverable));
        }

        [Test]
        [Ignore("Device returns SOAP Fault for optional GetEndpointReference; success response fixture is intentionally not saved.")]
        public void GetEndpointReferenceResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetEndpointReferenceResponse.xml");

            Assert.That(envelope,                                       Is.Not.Null);
            Assert.That(envelope.Body,                                  Is.Not.Null);
            GetEndpointReferenceResponse response = envelope.GetFromEnvelope<GetEndpointReferenceResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.GUID, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void GetWsdlUrlResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetWsdlUrlResponse.xml");

            Assert.That(envelope,                             Is.Not.Null);
            Assert.That(envelope.Body,                        Is.Not.Null);
            GetWsdlUrlResponse response = envelope.GetFromEnvelope<GetWsdlUrlResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.WsdlUrl, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void GetHostnameResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetHostnameResponse.xml");

            Assert.That(envelope,                              Is.Not.Null);
            Assert.That(envelope.Body,                         Is.Not.Null);
            GetHostnameResponse response = envelope.GetFromEnvelope<GetHostnameResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.HostnameInformation,      Is.Not.Null);
            Assert.That(response.HostnameInformation.Name, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        [Ignore("Device does not return valid SOAP XML for GetPasswordComplexityOptions on this target; fixture is intentionally not saved.")]
        public void GetPasswordComplexityOptionsResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetPasswordComplexityOptionsResponse.xml");

            Assert.That(envelope,                                             Is.Not.Null);
            Assert.That(envelope.Body,                                        Is.Not.Null);
            GetPasswordComplexityOptionsResponse response = envelope.GetFromEnvelope<GetPasswordComplexityOptionsResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.MinLenRange,                                Is.Not.Null);
            Assert.That(response.MinLenRange.Min,                            Is.GreaterThanOrEqualTo(0));
            Assert.That(response.MinLenRange.Max,                            Is.GreaterThanOrEqualTo(response.MinLenRange.Min));
        }

        [Test]
        [Ignore("Device does not return valid SOAP XML for GetPasswordComplexityConfiguration on this target; fixture is intentionally not saved.")]
        public void GetPasswordComplexityConfigurationResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetPasswordComplexityConfigurationResponse.xml");

            Assert.That(envelope,                                                   Is.Not.Null);
            Assert.That(envelope.Body,                                              Is.Not.Null);
            GetPasswordComplexityConfigurationResponse response = envelope.GetFromEnvelope<GetPasswordComplexityConfigurationResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device does not return valid SOAP XML for GetPasswordHistoryConfiguration on this target; fixture is intentionally not saved.")]
        public void GetPasswordHistoryConfigurationResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetPasswordHistoryConfigurationResponse.xml");

            Assert.That(envelope,                                               Is.Not.Null);
            Assert.That(envelope.Body,                                          Is.Not.Null);
            GetPasswordHistoryConfigurationResponse response = envelope.GetFromEnvelope<GetPasswordHistoryConfigurationResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Length, Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        [Ignore("Device does not return valid SOAP XML for GetAuthFailureWarningOptions on this target; fixture is intentionally not saved.")]
        public void GetAuthFailureWarningOptionsResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetAuthFailureWarningOptionsResponse.xml");

            Assert.That(envelope,                                               Is.Not.Null);
            Assert.That(envelope.Body,                                          Is.Not.Null);
            GetAuthFailureWarningOptionsResponse response = envelope.GetFromEnvelope<GetAuthFailureWarningOptionsResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.MonitorPeriodRange, Is.Not.Null);
            Assert.That(response.AuthFailureRange,   Is.Not.Null);
        }

        [Test]
        [Ignore("Device does not return valid SOAP XML for GetAuthFailureWarningConfiguration on this target; fixture is intentionally not saved.")]
        public void GetAuthFailureWarningConfigurationResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetAuthFailureWarningConfigurationResponse.xml");

            Assert.That(envelope,                                                     Is.Not.Null);
            Assert.That(envelope.Body,                                                Is.Not.Null);
            GetAuthFailureWarningConfigurationResponse response = envelope.GetFromEnvelope<GetAuthFailureWarningConfigurationResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.MonitorPeriod,   Is.GreaterThanOrEqualTo(0));
            Assert.That(response.MaxAuthFailures, Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetSystemBackup on this target; fixture is intentionally not saved.")]
        public void GetSystemBackupResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetSystemBackupResponse.xml");

            Assert.That(envelope,                              Is.Not.Null);
            Assert.That(envelope.Body,                         Is.Not.Null);
            GetSystemBackupResponse response = envelope.GetFromEnvelope<GetSystemBackupResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetDPAddresses on this target; fixture is intentionally not saved.")]
        public void GetDPAddressesResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetDPAddressesResponse.xml");

            Assert.That(envelope,                             Is.Not.Null);
            Assert.That(envelope.Body,                        Is.Not.Null);
            GetDPAddressesResponse response = envelope.GetFromEnvelope<GetDPAddressesResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetUserRoles on this target; fixture is intentionally not saved.")]
        public void GetUserRolesResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetUserRolesResponse.xml");

            Assert.That(envelope,                           Is.Not.Null);
            Assert.That(envelope.Body,                      Is.Not.Null);
            GetUserRolesResponse response = envelope.GetFromEnvelope<GetUserRolesResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void GetUsersResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetUsersResponse.xml");

            Assert.That(envelope,                       Is.Not.Null);
            Assert.That(envelope.Body,                  Is.Not.Null);
            GetUsersResponse response = envelope.GetFromEnvelope<GetUsersResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void GetDNSResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetDNSResponse.xml");

            Assert.That(envelope,                     Is.Not.Null);
            Assert.That(envelope.Body,                Is.Not.Null);
            GetDNSResponse response = envelope.GetFromEnvelope<GetDNSResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void GetNTPResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetNTPResponse.xml");

            Assert.That(envelope,                     Is.Not.Null);
            Assert.That(envelope.Body,                Is.Not.Null);
            GetNTPResponse response = envelope.GetFromEnvelope<GetNTPResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetDynamicDNS on this target; fixture is intentionally not saved.")]
        public void GetDynamicDNSResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetDynamicDNSResponse.xml");

            Assert.That(envelope,                            Is.Not.Null);
            Assert.That(envelope.Body,                       Is.Not.Null);
            GetDynamicDNSResponse response = envelope.GetFromEnvelope<GetDynamicDNSResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void GetNetworkProtocolsResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetNetworkProtocolsResponse.xml");

            Assert.That(envelope,                                  Is.Not.Null);
            Assert.That(envelope.Body,                             Is.Not.Null);
            GetNetworkProtocolsResponse response = envelope.GetFromEnvelope<GetNetworkProtocolsResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void GetNetworkDefaultGatewayResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetNetworkDefaultGatewayResponse.xml");

            Assert.That(envelope,                                       Is.Not.Null);
            Assert.That(envelope.Body,                                  Is.Not.Null);
            GetNetworkDefaultGatewayResponse response = envelope.GetFromEnvelope<GetNetworkDefaultGatewayResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void GetZeroConfigurationResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetZeroConfigurationResponse.xml");

            Assert.That(envelope,                                   Is.Not.Null);
            Assert.That(envelope.Body,                              Is.Not.Null);
            GetZeroConfigurationResponse response = envelope.GetFromEnvelope<GetZeroConfigurationResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetIPAddressFilter on this target; fixture is intentionally not saved.")]
        public void GetIPAddressFilterResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetIPAddressFilterResponse.xml");

            Assert.That(envelope,                               Is.Not.Null);
            Assert.That(envelope.Body,                          Is.Not.Null);
            GetIPAddressFilterResponse response = envelope.GetFromEnvelope<GetIPAddressFilterResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.IPAddressFilter, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetRemoteUser on this target; fixture is intentionally not saved.")]
        public void GetRemoteUserResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetRemoteUserResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetRemoteUserResponse response = envelope.GetFromEnvelope<GetRemoteUserResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void GetNetworkInterfacesResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetNetworkInterfacesResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetNetworkInterfacesResponse response = envelope.GetFromEnvelope<GetNetworkInterfacesResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetAccessPolicy on this target; fixture is intentionally not saved.")]
        public void GetAccessPolicyResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetAccessPolicyResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetAccessPolicyResponse response = envelope.GetFromEnvelope<GetAccessPolicyResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void GetRelayOutputsResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetRelayOutputsResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetRelayOutputsResponse response = envelope.GetFromEnvelope<GetRelayOutputsResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetDot11Capabilities on this target; fixture is intentionally not saved.")]
        public void GetDot11CapabilitiesResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetDot11CapabilitiesResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetDot11CapabilitiesResponse response = envelope.GetFromEnvelope<GetDot11CapabilitiesResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetDot11Status on this target; fixture is intentionally not saved.")]
        public void GetDot11StatusResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetDot11StatusResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetDot11StatusResponse response = envelope.GetFromEnvelope<GetDot11StatusResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetSystemUris on this target; fixture is intentionally not saved.")]
        public void GetSystemUrisResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetSystemUrisResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetSystemUrisResponse response = envelope.GetFromEnvelope<GetSystemUrisResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetStorageConfigurations on this target; fixture is intentionally not saved.")]
        public void GetStorageConfigurationsResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetStorageConfigurationsResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetStorageConfigurationsResponse response = envelope.GetFromEnvelope<GetStorageConfigurationsResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetStorageConfiguration on this target; fixture is intentionally not saved.")]
        public void GetStorageConfigurationResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetStorageConfigurationResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetStorageConfigurationResponse response = envelope.GetFromEnvelope<GetStorageConfigurationResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetGeoLocation on this target; fixture is intentionally not saved.")]
        public void GetGeoLocationResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetGeoLocationResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetGeoLocationResponse response = envelope.GetFromEnvelope<GetGeoLocationResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetCertificates on this target; fixture is intentionally not saved.")]
        public void GetCertificatesResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetCertificatesResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetCertificatesResponse response = envelope.GetFromEnvelope<GetCertificatesResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetCertificatesStatus on this target; fixture is intentionally not saved.")]
        public void GetCertificatesStatusResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetCertificatesStatusResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetCertificatesStatusResponse response = envelope.GetFromEnvelope<GetCertificatesStatusResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetPkcs10Request on this target; fixture is intentionally not saved.")]
        public void GetPkcs10RequestResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetPkcs10RequestResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetPkcs10RequestResponse response = envelope.GetFromEnvelope<GetPkcs10RequestResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetClientCertificateMode on this target; fixture is intentionally not saved.")]
        public void GetClientCertificateModeResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetClientCertificateModeResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetClientCertificateModeResponse response = envelope.GetFromEnvelope<GetClientCertificateModeResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetCACertificates on this target; fixture is intentionally not saved.")]
        public void GetCACertificatesResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetCACertificatesResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetCACertificatesResponse response = envelope.GetFromEnvelope<GetCACertificatesResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetCertificateInformation on this target; fixture is intentionally not saved.")]
        public void GetCertificateInformationResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetCertificateInformationResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetCertificateInformationResponse response = envelope.GetFromEnvelope<GetCertificateInformationResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetDot1XConfiguration on this target; fixture is intentionally not saved.")]
        public void GetDot1XConfigurationResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetDot1XConfigurationResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetDot1XConfigurationResponse response = envelope.GetFromEnvelope<GetDot1XConfigurationResponse>();
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetDot1XConfigurations on this target; fixture is intentionally not saved.")]
        public void GetDot1XConfigurationsResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetDot1XConfigurationsResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetDot1XConfigurationsResponse response = envelope.GetFromEnvelope<GetDot1XConfigurationsResponse>();
            Assert.That(response, Is.Not.Null);
        }

        private static SoapEnvelope getSoapEnvelopeForFile(string fileName)
        {
            string xmlPath = getXmlPath(fileName);

            Assert.That(File.Exists(xmlPath), Is.True, $"Fixture file not found: {xmlPath}");

            XmlSerializer serializer = new XmlSerializer(typeof(SoapEnvelope));

            SoapEnvelope envelope;
            using (StreamReader reader = new StreamReader(xmlPath))
            {
                envelope = (SoapEnvelope)serializer.Deserialize(reader);
            }

            return envelope;
        }

        private static string getXmlPath(string fileName)
        {
            string xmlPath = Path.GetFullPath(Path.Combine(TestContext.CurrentContext.TestDirectory,
                                                           "..", "..", "..", "DeserializationTests", "DeviceResponses", fileName));
            return xmlPath;
        }
    }
}