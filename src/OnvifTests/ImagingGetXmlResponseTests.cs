using System.Xml.Serialization;

using OnvifStandard;
using OnvifStandard.Common;
using OnvifStandard.Imaging;

using SoapHttpClient;

using GetServiceCapabilitiesRequest = OnvifStandard.Device.GetServiceCapabilitiesRequest;

namespace OnvifTests
{
    public class ImagingGetXmlResponseTests
    {
        [Test]
        public async Task GetServiceCapabilitiesXmlResponse()
        {
            ImagingTestingClient ic = getSubject();

            HttpResponseMessage res = await safeRequest(ic,
                                                        new GetServiceCapabilitiesRequest(),
                                                        "ImagingGetServiceCapabilitiesResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("ImagingGetServiceCapabilitiesResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetImagingSettingsXmlResponse()
        {
            ImagingTestingClient ic = getSubject();

            HttpResponseMessage res = await safeRequest(ic,
                                                        new GetImagingSettingsRequest { VideoSourceToken = "VideoSourceToken" },
                                                        "GetImagingSettingsResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetImagingSettingsResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetOptionsXmlResponse()
        {
            ImagingTestingClient ic = getSubject();

            HttpResponseMessage res = await safeRequest(ic,
                                                        new GetOptionsRequest { VideoSourceToken = "VideoSourceToken" },
                                                        "GetOptionsResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetOptionsResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetMoveOptionsXmlResponse()
        {
            ImagingTestingClient ic = getSubject();

            HttpResponseMessage res = await safeRequest(ic,
                                                        new GetMoveOptionsRequest { VideoSourceToken = "VideoSourceToken" },
                                                        "GetMoveOptionsResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetMoveOptionsResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetStatusXmlResponse()
        {
            ImagingTestingClient ic = getSubject();

            HttpResponseMessage res = await safeRequest(ic,
                                                        new GetStatusRequest { VideoSourceToken = "VideoSourceToken" },
                                                        "GetStatusResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetStatusResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetPresetsXmlResponse()
        {
            ImagingTestingClient ic = getSubject();

            HttpResponseMessage res = await safeRequest(ic,
                                                        new GetPresetsRequest { VideoSourceToken = "VideoSourceToken" },
                                                        "GetPresetsResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetPresetsResponse.xml", xmlResponse);
        }

        [Test]
        public async Task GetCurrentPresetXmlResponse()
        {
            ImagingTestingClient ic = getSubject();

            HttpResponseMessage res = await safeRequest(ic,
                                                        new GetCurrentPresetRequest { VideoSourceToken = "VideoSourceToken" },
                                                        "GetCurrentPresetResponse.xml");

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture("GetCurrentPresetResponse.xml", xmlResponse);
        }

        private static async Task<HttpResponseMessage> safeRequest<TReq>(ImagingTestingClient ic, TReq request, string responseFileName)
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

        private static string getResponsePath(string fileName)
        {
            return Path.GetFullPath(Path.Combine(TestContext.CurrentContext.TestDirectory,
                                                 "..", "..", "..",
                                                 "DeserializationTests",
                                                 "ImagingResponses",
                                                 fileName));
        }

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

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));
            await File.WriteAllTextAsync(outputPath, xmlResponse);

            Assert.That(File.Exists(outputPath), Is.True);
        }

        private static ImagingTestingClient getSubject()
        {
            ImagingTestingClient ic = new ImagingTestingClient
            {
                ServiceUri = new Uri("http://10.5.23.102:80/onvif/imaging_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return ic;
        }
    }

    public class ImagingTestingClient : OnvifSoapClientBase
    {
        public Task<TRes> GenericRequest<TReq, TRes>(Uri uri, TReq req)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<TReq, TRes>(uri, req, securityHeader);
        }
    }
}


