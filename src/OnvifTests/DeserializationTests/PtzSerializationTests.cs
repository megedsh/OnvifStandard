using System.Xml.Serialization;

using OnvifStandard;
using OnvifStandard.Common;
using OnvifStandard.Ptz;

namespace OnvifTests.DeserializationTests
{
    public class PtzSerializationTests
    {
        [Test]
        public void GetServiceCapabilitiesResponseDeserializationTests()
        {
            GetServiceCapabilitiesResponse r = assertDeserialization<GetServiceCapabilitiesResponse>("PtzGetServiceCapabilitiesResponse.xml");
            Assert.That(r.Capabilities, Is.Not.Null);
        }

        [Test]
        public void GetNodesResponseDeserializationTests()
        {
            GetNodesResponse r = assertDeserialization<GetNodesResponse>("GetNodesResponse.xml");
            Assert.That(r.PTZNode, Is.Not.Null);
        }

        [Test]
        public void GetNodeResponseDeserializationTests()
        {
            GetNodeResponse r = assertDeserialization<GetNodeResponse>("GetNodeResponse.xml");
            Assert.That(r.PTZNode, Is.Not.Null);
        }

        [Test]
        public void GetConfigurationsResponseDeserializationTests()
        {
            GetConfigurationsResponse r = assertDeserialization<GetConfigurationsResponse>("GetConfigurationsResponse.xml");
            Assert.That(r.PTZConfiguration, Is.Not.Null);
        }

        [Test]
        public void GetConfigurationResponseDeserializationTests()
        {
            GetConfigurationResponse r = assertDeserialization<GetConfigurationResponse>("GetConfigurationResponse.xml");
            Assert.That(r.PTZConfiguration, Is.Not.Null);
        }

        [Test]
        public void GetConfigurationOptionsResponseDeserializationTests()
        {
            GetConfigurationOptionsResponse r = assertDeserialization<GetConfigurationOptionsResponse>("GetConfigurationOptionsResponse.xml");
            Assert.That(r.PTZConfigurationOptions, Is.Not.Null);
        }

        [Test]
        public void GetPresetsResponseDeserializationTests()
        {
            GetPresetsResponse r = assertDeserialization<GetPresetsResponse>("GetPresetsResponse.xml");
        }

        [Test]
        public void GetStatusResponseDeserializationTests()
        {
            GetStatusResponse r = assertDeserialization<GetStatusResponse>("GetStatusResponse.xml");
            Assert.That(r.PTZStatus, Is.Not.Null);
        }

        [Test]
        public void GetPresetToursResponseDeserializationTests()
        {
            GetPresetToursResponse r = assertDeserialization<GetPresetToursResponse>("GetPresetToursResponse.xml");
        }

        [Test]
        public void GetPresetTourResponseDeserializationTests()
        {
            GetPresetTourResponse r = assertDeserialization<GetPresetTourResponse>("GetPresetTourResponse.xml");
            Assert.That(r.PresetTour, Is.Not.Null);
        }

        [Test]
        public void GetPresetTourOptionsResponseDeserializationTests()
        {
            GetPresetTourOptionsResponse r = assertDeserialization<GetPresetTourOptionsResponse>("GetPresetTourOptionsResponse.xml");
            Assert.That(r.Options, Is.Not.Null);
        }

        [Test]
        public void GetCompatibleConfigurationsResponseDeserializationTests()
        {
            GetCompatibleConfigurationsResponse r = assertDeserialization<GetCompatibleConfigurationsResponse>("GetCompatibleConfigurationsResponse.xml");
            Assert.That(r.PTZConfiguration, Is.Not.Null);
        }

        private static T assertDeserialization<T>(string fileName)
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile(fileName);

            Assert.That(envelope,      Is.Not.Null);
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
                                                           "..", "..", "..", "DeserializationTests", "PtzResponses", fileName));
            return xmlPath;
        }
    }
}