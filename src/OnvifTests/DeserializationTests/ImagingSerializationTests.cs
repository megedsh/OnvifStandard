using System.Xml.Serialization;

using OnvifStandard;
using OnvifStandard.Common;
using OnvifStandard.Imaging;

namespace OnvifTests.DeserializationTests
{
    public class ImagingSerializationTests
    {
        [Test]
        public void GetServiceCapabilitiesResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("ImagingGetServiceCapabilitiesResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetServiceCapabilitiesResponse response = envelope.GetFromEnvelope<GetServiceCapabilitiesResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Capabilities, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetImagingSettings on this target; fixture is intentionally not saved.")]
        public void GetImagingSettingsResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetImagingSettingsResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetImagingSettingsResponse response = envelope.GetFromEnvelope<GetImagingSettingsResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.ImagingSettings, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetOptions on this target; fixture is intentionally not saved.")]
        public void GetOptionsResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetOptionsResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetOptionsResponse response = envelope.GetFromEnvelope<GetOptionsResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.ImagingOptions, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetMoveOptions on this target; fixture is intentionally not saved.")]
        public void GetMoveOptionsResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetMoveOptionsResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetMoveOptionsResponse response = envelope.GetFromEnvelope<GetMoveOptionsResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.MoveOptions, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetStatus on this target; fixture is intentionally not saved.")]
        public void GetStatusResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetStatusResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetStatusResponse response = envelope.GetFromEnvelope<GetStatusResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Status, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetPresets on this target; fixture is intentionally not saved.")]
        public void GetPresetsResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetPresetsResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetPresetsResponse response = envelope.GetFromEnvelope<GetPresetsResponse>();
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Preset, Is.Not.Null);
        }

        [Test]
        [Ignore("Device did not return a valid/success response for GetCurrentPreset on this target; fixture is intentionally not saved.")]
        public void GetCurrentPresetResponseDeserializationTests()
        {
            SoapEnvelope envelope = getSoapEnvelopeForFile("GetCurrentPresetResponse.xml");

            Assert.That(envelope, Is.Not.Null);
            Assert.That(envelope.Body, Is.Not.Null);
            GetCurrentPresetResponse response = envelope.GetFromEnvelope<GetCurrentPresetResponse>();
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
                                                           "..", "..", "..", "DeserializationTests", "ImagingResponses", fileName));
            return xmlPath;
        }
    }


}
