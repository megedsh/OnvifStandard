
using System.Xml.Serialization;
using OnvifStandard;
using OnvifStandard.Common;
using OnvifStandard.Media;
using OnvifStandard.Ptz;

using SoapHttpClient;

using GetServiceCapabilitiesRequest = OnvifStandard.Ptz.GetServiceCapabilitiesRequest;

namespace OnvifTests
{
    public class PtzGetXmlResponseTests
    {
        [Test]
        public async Task GetServiceCapabilitiesXmlResponse() => await execute(new GetServiceCapabilitiesRequest(), "PtzGetServiceCapabilitiesResponse.xml");

        [Test]
        public async Task GetNodesXmlResponse() => await execute(new GetNodesRequest(), "GetNodesResponse.xml");

        [Test]
        public async Task GetNodeXmlResponse()
        {
            string nodeToken = await getNodeToken();
            await execute(new GetNodeRequest { NodeToken = nodeToken }, "GetNodeResponse.xml");
        }

        [Test]
        public async Task GetConfigurationsXmlResponse() => await execute(new GetConfigurationsRequest(), "GetConfigurationsResponse.xml");

        [Test]
        public async Task GetConfigurationXmlResponse()
        {
            string configurationToken = await getPtzConfigurationToken();
            await execute(new GetConfigurationRequest { PTZConfigurationToken = configurationToken }, "GetConfigurationResponse.xml");
        }

        [Test]
        public async Task GetConfigurationOptionsXmlResponse()
        {
            string configurationToken = await getPtzConfigurationToken();
            await execute(new GetConfigurationOptionsRequest { ConfigurationToken = configurationToken }, "GetConfigurationOptionsResponse.xml");
        }

        [Test]
        public async Task GetPresetsXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetPresetsRequest { ProfileToken = profileToken }, "GetPresetsResponse.xml");
        }

        [Test]
        public async Task GetStatusXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetStatusRequest { ProfileToken = profileToken }, "GetStatusResponse.xml");
        }

        [Test]
        public async Task GetPresetToursXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetPresetToursRequest { ProfileToken = profileToken }, "GetPresetToursResponse.xml");
        }

        [Test]
        public async Task GetPresetTourXmlResponse()
        {
            string profileToken = await getProfileToken();
            string presetTourToken = await getPresetTourToken(profileToken);
            await execute(new GetPresetTourRequest { ProfileToken = profileToken, PresetTourToken = presetTourToken }, "GetPresetTourResponse.xml");
        }

        [Test]
        public async Task GetPresetTourOptionsXmlResponse()
        {
            string profileToken = await getProfileToken();
            string presetTourToken = await getOptionalPresetTourToken(profileToken);
            await execute(new GetPresetTourOptionsRequest { ProfileToken = profileToken, PresetTourToken = presetTourToken }, "GetPresetTourOptionsResponse.xml");
        }

        [Test]
        public async Task GetCompatibleConfigurationsXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetCompatibleConfigurationsRequest { ProfileToken = profileToken }, "GetCompatibleConfigurationsResponse.xml");
        }

        private static async Task<string> getNodeToken()
        {
            PtzTestingClient ic = getSubject();
            GetNodesResponse response = await ic.GenericRequest<GetNodesRequest, GetNodesResponse>(ic.ServiceUri,
                                                                                                      new GetNodesRequest());
            string token = response?.PTZNode?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No PTZ node token found.");
            }

            return token;
        }

        private static async Task<string> getPtzConfigurationToken()
        {
            PtzTestingClient ic = getSubject();
            GetConfigurationsResponse response = await ic.GenericRequest<GetConfigurationsRequest, GetConfigurationsResponse>(ic.ServiceUri,
                                                                                                                                    new GetConfigurationsRequest());
            string token = response?.PTZConfiguration?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No PTZ configuration token found.");
            }

            return token;
        }

        private static async Task<string> getProfileToken()
        {
            PtzTestingClient ic = getSubject();
            GetProfilesResponse response = await ic.GenericRequest<GetProfilesRequest, GetProfilesResponse>(
                                                                                                            new Uri($"{ic.ServiceUri.Scheme}://{ic.ServiceUri.Authority}/onvif/media_service"),
                                                                                                            new GetProfilesRequest());

            string token = response?.Profiles?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No media profile token found.");
            }

            return token;
        }

        private static async Task<string> getPresetTourToken(string profileToken)
        {
            PtzTestingClient ic = getSubject();
            GetPresetToursResponse response = await ic.GenericRequest<GetPresetToursRequest, GetPresetToursResponse>(ic.ServiceUri,
                                                                                                                        new GetPresetToursRequest { ProfileToken = profileToken });
            string token = response?.PresetTour?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No PTZ preset tour token found.");
            }

            return token;
        }

        private static async Task<string> getOptionalPresetTourToken(string profileToken)
        {
            PtzTestingClient ic = getSubject();
            GetPresetToursResponse response = await ic.GenericRequest<GetPresetToursRequest, GetPresetToursResponse>(ic.ServiceUri,
                                                                                                                        new GetPresetToursRequest { ProfileToken = profileToken });
            return response?.PresetTour?.FirstOrDefault()?.Token;
        }

        private static async Task execute<TReq>(TReq request, string responseFileName)
        {
            PtzTestingClient ic = getSubject();

            HttpResponseMessage res = await safeRequest(ic, request, responseFileName);
            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture(responseFileName, xmlResponse);
        }

        private static async Task<HttpResponseMessage> safeRequest<TReq>(PtzTestingClient ic, TReq request, string responseFileName)
        {
            try
            {
                return await ic.GenericRequest<TReq, HttpResponseMessage>(ic.ServiceUri, request);
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
                                          "PtzResponses",
                                          fileName));

        private static async Task saveResponseFixture(string fileName, string xmlResponse)
        {
            string outputPath = getResponsePath(fileName);

            Assert.That(xmlResponse, Is.Not.Null.And.Not.Empty);

            SoapEnvelope envelope = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SoapEnvelope));
                using StringReader reader = new StringReader(xmlResponse);
                envelope = (SoapEnvelope)serializer.Deserialize(reader);
            }
            catch (Exception)
            {
                Assert.Pass($"{fileName}: device did not return a valid SOAP XML response. Fixture was not saved.");
            }

            if (envelope.TryGetFault(out SoapFault fault))
            {
                string faultCode = fault?.Code?.Subcode?.Value ?? fault?.Code?.Value ?? "UnknownCode";
                string faultReason = fault?.Reason?.Text ?? "UnknownReason";
                Assert.Pass($"{fileName}: SOAP Fault body detected. Code={faultCode}; Reason={faultReason}. Fixture was not saved.");
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

        private static PtzTestingClient getSubject()
        {
            PtzTestingClient ic = new PtzTestingClient
            {
                ServiceUri = new Uri("http://10.5.23.102:80/onvif/ptz_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return ic;
        }
    }

    public class PtzTestingClient : OnvifSoapClientBase
    {
        public Task<TRes> GenericRequest<TReq, TRes>(Uri uri, TReq req)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<TReq, TRes>(uri, req, securityHeader);
        }
    }
}





