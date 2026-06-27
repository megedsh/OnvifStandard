using System.Xml.Serialization;
using OnvifStandard;
using OnvifStandard.Common;
using OnvifStandard.Media;

using GetServiceCapabilitiesResponse = OnvifStandard.Device.GetServiceCapabilitiesResponse;

namespace OnvifTests.DeserializationTests
{
    public class MediaSerializationTests
    {
        [Test]
        public void GetServiceCapabilitiesResponseDeserializationTests()
        {
            GetServiceCapabilitiesResponse r = assertDeserialization<GetServiceCapabilitiesResponse>("MediaGetServiceCapabilitiesResponse.xml");
            Assert.That(r.Capabilities, Is.Not.Null);
        }

        [Test]
        public void GetVideoSourcesResponseDeserializationTests()
        {
            GetVideoSourcesResponse r = assertDeserialization<GetVideoSourcesResponse>("GetVideoSourcesResponse.xml");
            Assert.That(r.VideoSources, Is.Not.Null);
        }

        [Test]
        public void GetAudioSourcesResponseDeserializationTests()
        {
            GetAudioSourcesResponse r = assertDeserialization<GetAudioSourcesResponse>("GetAudioSourcesResponse.xml");
            Assert.That(r.AudioSources, Is.Not.Null);
        }

        [Test]
        public void GetAudioOutputsResponseDeserializationTests()
        {
            GetAudioOutputsResponse r = assertDeserialization<GetAudioOutputsResponse>("GetAudioOutputsResponse.xml");
            Assert.That(r.AudioOutputs, Is.Not.Null);
        }

        [Test]
        public void GetProfileResponseDeserializationTests()
        {
            GetProfileResponse r = assertDeserialization<GetProfileResponse>("GetProfileResponse.xml");
            Assert.That(r.Profile, Is.Not.Null);
        }

        [Test]
        public void GetProfilesResponseDeserializationTests()
        {
            GetProfilesResponse r = assertDeserialization<GetProfilesResponse>("GetProfilesResponse.xml");
            Assert.That(r.Profiles, Is.Not.Null);
        }

        [Test]
        public void GetVideoSourceConfigurationsResponseDeserializationTests()
        {
            GetVideoSourceConfigurationsResponse r = assertDeserialization<GetVideoSourceConfigurationsResponse>("GetVideoSourceConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetVideoEncoderConfigurationsResponseDeserializationTests()
        {
            GetVideoEncoderConfigurationsResponse r = assertDeserialization<GetVideoEncoderConfigurationsResponse>("GetVideoEncoderConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetAudioSourceConfigurationsResponseDeserializationTests()
        {
            GetAudioSourceConfigurationsResponse r = assertDeserialization<GetAudioSourceConfigurationsResponse>("GetAudioSourceConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetAudioEncoderConfigurationsResponseDeserializationTests()
        {
            GetAudioEncoderConfigurationsResponse r = assertDeserialization<GetAudioEncoderConfigurationsResponse>("GetAudioEncoderConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetVideoAnalyticsConfigurationsResponseDeserializationTests()
        {
            GetVideoAnalyticsConfigurationsResponse r = assertDeserialization<GetVideoAnalyticsConfigurationsResponse>("GetVideoAnalyticsConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetMetadataConfigurationsResponseDeserializationTests()
        {
            GetMetadataConfigurationsResponse r = assertDeserialization<GetMetadataConfigurationsResponse>("GetMetadataConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetAudioOutputConfigurationsResponseDeserializationTests()
        {
            GetAudioOutputConfigurationsResponse r = assertDeserialization<GetAudioOutputConfigurationsResponse>("GetAudioOutputConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetAudioDecoderConfigurationsResponseDeserializationTests()
        {
            GetAudioDecoderConfigurationsResponse r = assertDeserialization<GetAudioDecoderConfigurationsResponse>("GetAudioDecoderConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetVideoSourceConfigurationResponseDeserializationTests()
        {
            GetVideoSourceConfigurationResponse r = assertDeserialization<GetVideoSourceConfigurationResponse>("GetVideoSourceConfigurationResponse.xml");
            Assert.That(r.Configuration, Is.Not.Null);
        }

        [Test]
        public void GetVideoEncoderConfigurationResponseDeserializationTests()
        {
            GetVideoEncoderConfigurationResponse r = assertDeserialization<GetVideoEncoderConfigurationResponse>("GetVideoEncoderConfigurationResponse.xml");
            Assert.That(r.Configuration, Is.Not.Null);
        }

        [Test]
        public void GetAudioSourceConfigurationResponseDeserializationTests()
        {
            GetAudioSourceConfigurationResponse r = assertDeserialization<GetAudioSourceConfigurationResponse>("GetAudioSourceConfigurationResponse.xml");
            Assert.That(r.Configuration, Is.Not.Null);
        }

        [Test]
        public void GetAudioEncoderConfigurationResponseDeserializationTests()
        {
            GetAudioEncoderConfigurationResponse r = assertDeserialization<GetAudioEncoderConfigurationResponse>("GetAudioEncoderConfigurationResponse.xml");
            Assert.That(r.Configuration, Is.Not.Null);
        }

        [Test]
        public void GetVideoAnalyticsConfigurationResponseDeserializationTests()
        {
            GetVideoAnalyticsConfigurationResponse r = assertDeserialization<GetVideoAnalyticsConfigurationResponse>("GetVideoAnalyticsConfigurationResponse.xml");
            Assert.That(r.Configuration, Is.Not.Null);
        }

        [Test]
        public void GetMetadataConfigurationResponseDeserializationTests()
        {
            GetMetadataConfigurationResponse r = assertDeserialization<GetMetadataConfigurationResponse>("GetMetadataConfigurationResponse.xml");
            Assert.That(r.Configuration, Is.Not.Null);
        }

        [Test]
        public void GetAudioOutputConfigurationResponseDeserializationTests()
        {
            GetAudioOutputConfigurationResponse r = assertDeserialization<GetAudioOutputConfigurationResponse>("GetAudioOutputConfigurationResponse.xml");
            Assert.That(r.Configuration, Is.Not.Null);
        }

        [Test]
        public void GetAudioDecoderConfigurationResponseDeserializationTests()
        {
            GetAudioDecoderConfigurationResponse r = assertDeserialization<GetAudioDecoderConfigurationResponse>("GetAudioDecoderConfigurationResponse.xml");
            Assert.That(r.Configuration, Is.Not.Null);
        }

        [Test]
        public void GetCompatibleVideoEncoderConfigurationsResponseDeserializationTests()
        {
            GetCompatibleVideoEncoderConfigurationsResponse r = assertDeserialization<GetCompatibleVideoEncoderConfigurationsResponse>("GetCompatibleVideoEncoderConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetCompatibleVideoSourceConfigurationsResponseDeserializationTests()
        {
            GetCompatibleVideoSourceConfigurationsResponse r = assertDeserialization<GetCompatibleVideoSourceConfigurationsResponse>("GetCompatibleVideoSourceConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetCompatibleAudioEncoderConfigurationsResponseDeserializationTests()
        {
            GetCompatibleAudioEncoderConfigurationsResponse r = assertDeserialization<GetCompatibleAudioEncoderConfigurationsResponse>("GetCompatibleAudioEncoderConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetCompatibleAudioSourceConfigurationsResponseDeserializationTests()
        {
            GetCompatibleAudioSourceConfigurationsResponse r = assertDeserialization<GetCompatibleAudioSourceConfigurationsResponse>("GetCompatibleAudioSourceConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetCompatibleVideoAnalyticsConfigurationsResponseDeserializationTests()
        {
            GetCompatibleVideoAnalyticsConfigurationsResponse r = assertDeserialization<GetCompatibleVideoAnalyticsConfigurationsResponse>("GetCompatibleVideoAnalyticsConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetCompatibleMetadataConfigurationsResponseDeserializationTests()
        {
            GetCompatibleMetadataConfigurationsResponse r = assertDeserialization<GetCompatibleMetadataConfigurationsResponse>("GetCompatibleMetadataConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetCompatibleAudioOutputConfigurationsResponseDeserializationTests()
        {
            GetCompatibleAudioOutputConfigurationsResponse r = assertDeserialization<GetCompatibleAudioOutputConfigurationsResponse>("GetCompatibleAudioOutputConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetCompatibleAudioDecoderConfigurationsResponseDeserializationTests()
        {
            GetCompatibleAudioDecoderConfigurationsResponse r = assertDeserialization<GetCompatibleAudioDecoderConfigurationsResponse>("GetCompatibleAudioDecoderConfigurationsResponse.xml");
            Assert.That(r.Configurations, Is.Not.Null);
        }

        [Test]
        public void GetVideoSourceConfigurationOptionsResponseDeserializationTests()
        {
            GetVideoSourceConfigurationOptionsResponse r = assertDeserialization<GetVideoSourceConfigurationOptionsResponse>("GetVideoSourceConfigurationOptionsResponse.xml");
            Assert.That(r.Options, Is.Not.Null);
        }

        [Test]
        public void GetVideoEncoderConfigurationOptionsResponseDeserializationTests()
        {
            GetVideoEncoderConfigurationOptionsResponse r = assertDeserialization<GetVideoEncoderConfigurationOptionsResponse>("GetVideoEncoderConfigurationOptionsResponse.xml");
            Assert.That(r.Options, Is.Not.Null);
        }

        [Test]
        public void GetAudioSourceConfigurationOptionsResponseDeserializationTests()
        {
            GetAudioSourceConfigurationOptionsResponse r = assertDeserialization<GetAudioSourceConfigurationOptionsResponse>("GetAudioSourceConfigurationOptionsResponse.xml");
            Assert.That(r.Options, Is.Not.Null);
        }

        [Test]
        public void GetAudioEncoderConfigurationOptionsResponseDeserializationTests()
        {
            GetAudioEncoderConfigurationOptionsResponse r = assertDeserialization<GetAudioEncoderConfigurationOptionsResponse>("GetAudioEncoderConfigurationOptionsResponse.xml");
            Assert.That(r.Options, Is.Not.Null);
        }

        [Test]
        public void GetMetadataConfigurationOptionsResponseDeserializationTests()
        {
            GetMetadataConfigurationOptionsResponse r = assertDeserialization<GetMetadataConfigurationOptionsResponse>("GetMetadataConfigurationOptionsResponse.xml");
            Assert.That(r.Options, Is.Not.Null);
        }

        [Test]
        public void GetAudioOutputConfigurationOptionsResponseDeserializationTests()
        {
            GetAudioOutputConfigurationOptionsResponse r = assertDeserialization<GetAudioOutputConfigurationOptionsResponse>("GetAudioOutputConfigurationOptionsResponse.xml");
            Assert.That(r.Options, Is.Not.Null);
        }

        [Test]
        public void GetAudioDecoderConfigurationOptionsResponseDeserializationTests()
        {
            GetAudioDecoderConfigurationOptionsResponse r = assertDeserialization<GetAudioDecoderConfigurationOptionsResponse>("GetAudioDecoderConfigurationOptionsResponse.xml");
            Assert.That(r.Options, Is.Not.Null);
        }

        [Test]
        public void GetGuaranteedNumberOfVideoEncoderInstancesResponseDeserializationTests()
        {
            GetGuaranteedNumberOfVideoEncoderInstancesResponse r = assertDeserialization<GetGuaranteedNumberOfVideoEncoderInstancesResponse>("GetGuaranteedNumberOfVideoEncoderInstancesResponse.xml");
            Assert.That(r.TotalNumber, Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void GetStreamUriResponseDeserializationTests()
        {
            GetStreamUriResponse r = assertDeserialization<GetStreamUriResponse>("GetStreamUriResponse.xml");
            Assert.That(r.MediaUri,     Is.Not.Null);
            Assert.That(r.MediaUri.Uri, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void GetSnapshotUriResponseDeserializationTests()
        {
            GetSnapshotUriResponse r = assertDeserialization<GetSnapshotUriResponse>("GetSnapshotUriResponse.xml");
            Assert.That(r.MediaUri,     Is.Not.Null);
            Assert.That(r.MediaUri.Uri, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void GetVideoSourceModesResponseDeserializationTests()
        {
            GetVideoSourceModesResponse r = assertDeserialization<GetVideoSourceModesResponse>("GetVideoSourceModesResponse.xml");
            Assert.That(r.VideoSourceModes, Is.Not.Null);
        }

        [Test]
        public void GetOSDsResponseDeserializationTests()
        {
            GetOSDsResponse r = assertDeserialization<GetOSDsResponse>("GetOSDsResponse.xml");
            Assert.That(r.OSDs, Is.Not.Null);
        }

        [Test]
        public void GetOSDResponseDeserializationTests()
        {
            GetOSDResponse r = assertDeserialization<GetOSDResponse>("GetOSDResponse.xml");
            Assert.That(r.OSD, Is.Not.Null);
        }

        [Test]
        public void GetOSDOptionsResponseDeserializationTests()
        {
            GetOSDOptionsResponse r = assertDeserialization<GetOSDOptionsResponse>("GetOSDOptionsResponse.xml");
            Assert.That(r.OSDOptions, Is.Not.Null);
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
                                                           "..", "..", "..", "DeserializationTests", "MediaResponses", fileName));
            return xmlPath;
        }
    }
}