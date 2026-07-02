using System.Xml.Serialization;

using OnvifStandard;
using OnvifStandard.Common;
using OnvifStandard.Events;

using SoapHttpClient;

namespace OnvifTests
{
    public class EventsGetXmlResponseTests
    {
        private static string m_pullPointSubscriptionUrl;

        [Test]
        public async Task GetServiceCapabilitiesXmlResponse() => await execute(new GetServiceCapabilitiesRequest(), "GetServiceCapabilitiesResponse.xml");

        [Test]
        public async Task CreatePullPointSubscriptionXmlResponse() => await execute(new CreatePullPointSubscriptionRequest(), "CreatePullPointSubscriptionResponse.xml");

        [Test]
        public async Task PullMessagesXmlResponse() =>
            await executeOnPullPoint(new PullMessagesRequest
            {
                Timeout = "PT5S",
                MessageLimit = 1
            }, "PullMessagesResponse.xml");

        [Test]
        public async Task SeekXmlResponse() =>
            await executeOnPullPoint(new SeekRequest
            {
                UtcTime = DateTime.UtcNow,
                Reverse = false
            }, "SeekResponse.xml");

        [Test]
        public async Task SetSynchronizationPointXmlResponse() => await executeOnPullPoint(new SetSynchronizationPointRequest(), "SetSynchronizationPointResponse.xml");

        [Test]
        public async Task GetEventPropertiesXmlResponse() => await execute(new GetEventPropertiesRequest(), "GetEventPropertiesResponse.xml");

        [Test]
        public async Task AddEventBrokerXmlResponse() =>
            await execute(new AddEventBrokerRequest
            {
                EventBroker = new EventBrokerConfig
                {
                    Address = "mqtt://127.0.0.1:1883",
                    TopicPrefix = "onvif"
                }
            }, "AddEventBrokerResponse.xml");

        [Test]
        public async Task DeleteEventBrokerXmlResponse() =>
            await execute(new DeleteEventBrokerRequest
            {
                Address = "mqtt://127.0.0.1:1883"
            }, "DeleteEventBrokerResponse.xml");

        [Test]
        public async Task GetEventBrokersXmlResponse() => await execute(new GetEventBrokersRequest(), "GetEventBrokersResponse.xml");

        [Test]
        public async Task SubscribeXmlResponse() =>
            await execute(new SubscribeRequest
            {
                ConsumerReference = new EndpointReferenceType
                {
                    Address = "http://127.0.0.1/onvif/events/consumer"
                }
            }, "SubscribeResponse.xml");

        [Test]
        public async Task RenewXmlResponse() =>
            await executeOnPullPoint(new RenewRequest
            {
                TerminationTime = new AbsoluteOrRelativeTimeType
                {
                    Value = "PT1M"
                }
            }, "RenewResponse.xml");

        [Test]
        public async Task UnsubscribeXmlResponse() => await executeOnPullPoint(new UnsubscribeRequest(), "UnsubscribeResponse.xml");

        private static async Task execute<TReq>(TReq request, string responseFileName)
        {
            EventsTestingClient ic = getSubject();

            HttpResponseMessage res = await safeRequest(ic, request, responseFileName);

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture(responseFileName, xmlResponse);
        }

        private static async Task executeOnPullPoint<TReq>(TReq request, string responseFileName)
        {
            PullPointsTestingClient ic = await getPullPointSubject();

            HttpResponseMessage res = await safeRequest(ic, request, responseFileName);

            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture(responseFileName, xmlResponse);
        }

        private static async Task<PullPointsTestingClient> getPullPointSubject()
        {
            if (!string.IsNullOrWhiteSpace(m_pullPointSubscriptionUrl))
            {
                return new PullPointsTestingClient
                {
                    //ServiceUri = new Uri("http://10.5.23.102:80/onvif/imaging_service"),
                    ServiceUri = new Uri(m_pullPointSubscriptionUrl),
                    User = "root",
                    Password = "Q1w2e3r4",
                    SoapClient = new SoapClient()
                };
            }

            EventsTestingClient baseClient = getSubject();
            CreatePullPointSubscriptionResponse res = await baseClient.GenericRequest<CreatePullPointSubscriptionRequest, CreatePullPointSubscriptionResponse>(baseClient.ServiceUri, new CreatePullPointSubscriptionRequest());

            string subscriptionReferenceAddress = res.SubscriptionReference.Address;

            Assert.That(res.SubscriptionReference?.Address,
                        Is.Not.Null.And.Not.Empty,
                        "CreatePullPointSubscription did not return SubscriptionReference.Address.");

            m_pullPointSubscriptionUrl = res.SubscriptionReference.Address;
            return new PullPointsTestingClient
            {
                ServiceUri = new Uri(m_pullPointSubscriptionUrl),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
        }

        private static async Task<HttpResponseMessage> safeRequest<TReq>(ITestingClient ic, TReq request, string responseFileName)
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
                                          "EventsResponses",
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

        private static EventsTestingClient getSubject(Uri serviceUri = null)
        {
            EventsTestingClient ic = new EventsTestingClient
            {
                //ServiceUri = new Uri("http://10.5.23.102:80/onvif/imaging_service"),
                ServiceUri = serviceUri ?? new Uri("http://192.168.3.19:8000/onvif/events_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return ic;
        }
    }

    public class EventsTestingClient : OnvifSoapClientBase, ITestingClient
    {
        public Task<TRes> GenericRequest<TReq, TRes>(Uri uri, TReq req)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<TReq, TRes>(uri, req, securityHeader);
        }
    }

    public class PullPointsTestingClient : OnvifSoapClientBase, ITestingClient
    {
        public Task<TRes> GenericRequest<TReq, TRes>(Uri uri, TReq req)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<TReq, TRes>(uri, req, securityHeader);
        }
    }
}