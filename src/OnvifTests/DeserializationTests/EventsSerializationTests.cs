using System.Xml.Serialization;

using OnvifStandard;
using OnvifStandard.Common;
using OnvifStandard.Events;

namespace OnvifTests.DeserializationTests
{
    public class EventsSerializationTests
    {
        [Test]
        public void GetServiceCapabilitiesResponseDeserializationTests()
        {
            GetServiceCapabilitiesResponse response = assertDeserialization<GetServiceCapabilitiesResponse>("GetServiceCapabilitiesResponse.xml");
            Assert.That(response.Capabilities, Is.Not.Null);
        }

        [Test]
        public void CreatePullPointSubscriptionResponseDeserializationTests()
        {
            CreatePullPointSubscriptionResponse response = assertDeserialization<CreatePullPointSubscriptionResponse>("CreatePullPointSubscriptionResponse.xml");
            Assert.That(response.SubscriptionReference, Is.Not.Null);
        }

        [Test]
        public void PullMessagesResponseDeserializationTests()
        {
            PullMessagesResponse response = assertDeserialization<PullMessagesResponse>("PullMessagesResponse.xml");
            Assert.That(response.CurrentTime, Is.Not.EqualTo(default(DateTime)));
        }

        [Test]
        public void SeekResponseDeserializationTests()
        {
            SeekResponse response = assertDeserialization<SeekResponse>("SeekResponse.xml");
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void SetSynchronizationPointResponseDeserializationTests()
        {
            SetSynchronizationPointResponse response = assertDeserialization<SetSynchronizationPointResponse>("SetSynchronizationPointResponse.xml");
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void GetEventPropertiesResponseDeserializationTests()
        {
            GetEventPropertiesResponse response = assertDeserialization<GetEventPropertiesResponse>("GetEventPropertiesResponse.xml");
            Assert.That(response.TopicNamespaceLocation, Is.Not.Null);
            Assert.That(response.TopicExpressionDialect, Is.Not.Null);
        }

        [Test]
        public void AddEventBrokerResponseDeserializationTests()
        {
            AddEventBrokerResponse response = assertDeserialization<AddEventBrokerResponse>("AddEventBrokerResponse.xml");
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void DeleteEventBrokerResponseDeserializationTests()
        {
            DeleteEventBrokerResponse response = assertDeserialization<DeleteEventBrokerResponse>("DeleteEventBrokerResponse.xml");
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public void GetEventBrokersResponseDeserializationTests()
        {
            GetEventBrokersResponse response = assertDeserialization<GetEventBrokersResponse>("GetEventBrokersResponse.xml");
            Assert.That(response.EventBroker, Is.Not.Null);
        }

        [Test]
        public void SubscribeResponseDeserializationTests()
        {
            SubscribeResponse response = assertDeserialization<SubscribeResponse>("SubscribeResponse.xml");
            Assert.That(response.SubscriptionReference, Is.Not.Null);
        }

        [Test]
        public void RenewResponseDeserializationTests()
        {
            RenewResponse response = assertDeserialization<RenewResponse>("RenewResponse.xml");
            Assert.That(response.TerminationTime, Is.Not.EqualTo(default(DateTime)));
        }

        [Test]
        public void UnsubscribeResponseDeserializationTests()
        {
            UnsubscribeResponse response = assertDeserialization<UnsubscribeResponse>("UnsubscribeResponse.xml");
            Assert.That(response, Is.Not.Null);
        }

        private static T assertDeserialization<T>(string fileName)
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile(fileName);

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);

            T response = envelope.GetFromEnvelope<T>();
            Assert.That(response, Is.Not.Null);
            return response;
        }

        private static SoapEnvelope getSoapEnvelopeForFile(string fileName)
        {
            string xmlPath = getXmlPath(fileName);

            if (!File.Exists(xmlPath))
            {
                Assert.Ignore($"Fixture file not found: {xmlPath}");
            }

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
                                                           "..", "..", "..", "DeserializationTests", "EventsResponses", fileName));
            return xmlPath;
        }
    }
}