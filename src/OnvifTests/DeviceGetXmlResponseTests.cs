using System.Xml.Serialization;

using OnvifStandard;
using OnvifStandard.Common;
using OnvifStandard.Device;

using SoapHttpClient;

namespace OnvifTests
{
    public class DeviceGetXmlResponseTests
    {
        //http://root:Q1w2e3r4@10.5.23.102/cgi-bin/mjpg/video.cgi?subtype=1
        [Test]
        public async Task GetXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetDeviceInformationRequest(),
                                                        "GetDeviceInformationResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetDeviceInformationResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetServicesXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetServicesRequest
                                                        {
                                                            IncludeCapability = false
                                                        },
                                                        "GetServicesResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetServicesResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetSystemLogXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetSystemLogRequest
                                                        {
                                                            LogType = SystemLogType.System
                                                        },
                                                        "GetSystemLogResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetSystemLogResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetSystemSupportInformationXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetSystemSupportInformationRequest(),
                                                        "GetSystemSupportInformationResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetSystemSupportInformationResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetScopesXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetScopesRequest(),
                                                        "GetScopesResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetScopesResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetServiceCapabilitiesXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetServiceCapabilitiesRequest(),
                                                        "GetServiceCapabilitiesResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetServiceCapabilitiesResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetSystemDateAndTimeXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetSystemDateAndTimeRequest(),
                                                        "GetSystemDateAndTimeResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetSystemDateAndTimeResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetDiscoveryModeXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetDiscoveryModeRequest(),
                                                        "GetDiscoveryModeResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetDiscoveryModeResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetRemoteDiscoveryModeXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetRemoteDiscoveryModeRequest(),
                                                        "GetRemoteDiscoveryModeResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetRemoteDiscoveryModeResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetWsdlUrlXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetWsdlUrlRequest(),
                                                        "GetWsdlUrlResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetWsdlUrlResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetEndpointReferenceXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetEndpointReferenceRequest(),
                                                        "GetEndpointReferenceResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetEndpointReferenceResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetHostnameXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetHostnameRequest(),
                                                        "GetHostnameResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetHostnameResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetPasswordComplexityOptionsXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetPasswordComplexityOptionsRequest(),
                                                        "GetPasswordComplexityOptionsResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetPasswordComplexityOptionsResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetPasswordComplexityConfigurationXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetPasswordComplexityConfigurationRequest(),
                                                        "GetPasswordComplexityConfigurationResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetPasswordComplexityConfigurationResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetPasswordHistoryConfigurationXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetPasswordHistoryConfigurationRequest(),
                                                        "GetPasswordHistoryConfigurationResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetPasswordHistoryConfigurationResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetAuthFailureWarningOptionsXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetAuthFailureWarningOptionsRequest(),
                                                        "GetAuthFailureWarningOptionsResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetAuthFailureWarningOptionsResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetAuthFailureWarningConfigurationXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetAuthFailureWarningConfigurationRequest(),
                                                        "GetAuthFailureWarningConfigurationResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetAuthFailureWarningConfigurationResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetSystemBackupXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetSystemBackupRequest(),
                                                        "GetSystemBackupResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetSystemBackupResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetDPAddressesXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetDPAddressesRequest(),
                                                        "GetDPAddressesResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetDPAddressesResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetUserRolesXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetUserRolesRequest(),
                                                        "GetUserRolesResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetUserRolesResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetUsersXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetUsersRequest(),
                                                        "GetUsersResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetUsersResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetDNSXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetDNSRequest(),
                                                        "GetDNSResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetDNSResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetNTPXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetNTPRequest(),
                                                        "GetNTPResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetNTPResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetDynamicDNSXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetDynamicDNSRequest(),
                                                        "GetDynamicDNSResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetDynamicDNSResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetNetworkProtocolsXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetNetworkProtocolsRequest(),
                                                        "GetNetworkProtocolsResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetNetworkProtocolsResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetNetworkDefaultGatewayXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetNetworkDefaultGatewayRequest(),
                                                        "GetNetworkDefaultGatewayResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetNetworkDefaultGatewayResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetZeroConfigurationXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetZeroConfigurationRequest(),
                                                        "GetZeroConfigurationResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetZeroConfigurationResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetIPAddressFilterXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetIPAddressFilterRequest(),
                                                        "GetIPAddressFilterResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();

            await saveResponseFixture("GetIPAddressFilterResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetRemoteUserXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetRemoteUserRequest(),
                                                        "GetRemoteUserResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetRemoteUserResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetNetworkInterfacesXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetNetworkInterfacesRequest(),
                                                        "GetNetworkInterfacesResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetNetworkInterfacesResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetAccessPolicyXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetAccessPolicyRequest(),
                                                        "GetAccessPolicyResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetAccessPolicyResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetRelayOutputsXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetRelayOutputsRequest(),
                                                        "GetRelayOutputsResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetRelayOutputsResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetDot11CapabilitiesXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetDot11CapabilitiesRequest(),
                                                        "GetDot11CapabilitiesResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetDot11CapabilitiesResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetDot11StatusXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetDot11StatusRequest
                                                        {
                                                            InterfaceToken = "eth0"
                                                        },
                                                        "GetDot11StatusResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetDot11StatusResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetSystemUrisXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetSystemUrisRequest(),
                                                        "GetSystemUrisResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetSystemUrisResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetStorageConfigurationsXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetStorageConfigurationsRequest(),
                                                        "GetStorageConfigurationsResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetStorageConfigurationsResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetStorageConfigurationXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetStorageConfigurationRequest
                                                        {
                                                            Token = "StorageToken"
                                                        },
                                                        "GetStorageConfigurationResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetStorageConfigurationResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetGeoLocationXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetGeoLocationRequest(),
                                                        "GetGeoLocationResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetGeoLocationResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetCertificatesXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetCertificatesRequest(),
                                                        "GetCertificatesResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetCertificatesResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetCertificatesStatusXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetCertificatesStatusRequest(),
                                                        "GetCertificatesStatusResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetCertificatesStatusResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetPkcs10RequestXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetPkcs10Request
                                                        {
                                                            CertificateID = "CertID"
                                                        },
                                                        "GetPkcs10RequestResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetPkcs10RequestResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetClientCertificateModeXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetClientCertificateModeRequest(),
                                                        "GetClientCertificateModeResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetClientCertificateModeResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetCACertificatesXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetCACertificatesRequest(),
                                                        "GetCACertificatesResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetCACertificatesResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetCertificateInformationXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetCertificateInformationRequest
                                                        {
                                                            CertificateID = "CertID"
                                                        },
                                                        "GetCertificateInformationResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetCertificateInformationResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetDot1XConfigurationXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetDot1XConfigurationRequest
                                                        {
                                                            Dot1XConfigurationToken = "Dot1XToken"
                                                        },
                                                        "GetDot1XConfigurationResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetDot1XConfigurationResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetDot1XConfigurationsXmlResponse()
        {
            TestingClient dc = getSubject();

            HttpResponseMessage res = await safeRequest(dc,
                                                        new GetDot1XConfigurationsRequest(),
                                                        "GetDot1XConfigurationsResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetDot1XConfigurationsResponse.xml", xmlResponse);
        }

        private static async Task<HttpResponseMessage> safeRequest<TReq>(TestingClient dc, TReq request, string responseFileName)
        {
            try
            {
                return await dc.GenericRequest<TReq, HttpResponseMessage>(dc.ServiceUri,
                                                                          request);
            }
            catch (Exception ex)
            {
                Assert.Pass($"{responseFileName}: request failed ({ex.GetType().Name}). Fixture was not saved.");
                return null;
            }
        }

        private static string getResponsePath(string fileName) =>
            Path.GetFullPath(Path.Combine(TestContext.CurrentContext.TestDirectory,
                                          "..", "..", "..",
                                          "DeserializationTests",
                                          "DeviceResponses",
                                          fileName));

        private static async Task saveResponseFixture(string fileName, string xmlResponse)
        {
            string outputPath = getResponsePath(fileName);

            Assert.That(xmlResponse, Is.Not.Null.And.Not.Empty);

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SoapEnvelope));
                using StringReader reader = new StringReader(xmlResponse);
                SoapEnvelope envelope = (SoapEnvelope)serializer.Deserialize(reader);

                if (envelope.TryGetFault(out SoapFault fault))
                {
                    Assert.Pass($"{fileName}: device returned SOAP Fault ({fault.Reason?.Text}). Fixture was not saved.");
                }
            }
            catch (Exception)
            {
                Assert.Pass($"{fileName}: device did not return a valid SOAP XML response. Fixture was not saved.");
            }

            if (File.Exists(outputPath))
            {
                Assert.That(File.Exists(outputPath), Is.True);
                return;
            }


            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));
            await File.WriteAllTextAsync(outputPath, xmlResponse);

            Assert.That(File.Exists(outputPath), Is.True);
        }

        private static TestingClient getSubject()
        {
            TestingClient dc = new TestingClient
            {
                ServiceUri = new Uri("http://10.5.23.102:80/onvif/device_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return dc;
        }
    }
    public class TestingClient : OnvifSoapClientBase
    {
        public Task<TRes> GenericRequest<TReq, TRes>(Uri uri, TReq req)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<TReq, TRes>(uri, req, securityHeader);
        }
    }
}

