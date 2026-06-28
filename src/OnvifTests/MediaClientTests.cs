using OnvifStandard.Media;

using SoapHttpClient;

namespace OnvifTests
{
    public class MediaClientTests
    {
        [Test] public async Task GetServiceCapabilities() => Assert.That(await getSubject().GetServiceCapabilities(), Is.Not.Null);
        [Test] public async Task GetVideoSources() => Assert.That((await getSubject().GetVideoSources()).VideoSources, Is.Not.Null);
        [Test] public async Task GetAudioSources() => Assert.That((await getSubject().GetAudioSources()).AudioSources, Is.Not.Null);
        [Test] public async Task GetAudioOutputs() => Assert.That((await getSubject().GetAudioOutputs()).AudioOutputs, Is.Not.Null);
        [Test] public async Task GetProfiles() => Assert.That((await getSubject().GetProfiles()).Profiles, Is.Not.Null);

        [Test]
        public async Task GetProfile()
        {
            MediaClient mc = getSubject();
            string profileToken = await getProfileToken(mc);
            Assert.That((await mc.GetProfile(profileToken)).Profile, Is.Not.Null);
        }

        [Test] public async Task GetVideoSourceConfigurations() => Assert.That((await getSubject().GetVideoSourceConfigurations()).Configurations, Is.Not.Null);
        [Test] public async Task GetVideoEncoderConfigurations() => Assert.That((await getSubject().GetVideoEncoderConfigurations()).Configurations, Is.Not.Null);
        [Test] public async Task GetAudioSourceConfigurations() => Assert.That((await getSubject().GetAudioSourceConfigurations()).Configurations, Is.Not.Null);
        [Test] public async Task GetAudioEncoderConfigurations() => Assert.That((await getSubject().GetAudioEncoderConfigurations()).Configurations, Is.Not.Null);
        [Test] public async Task GetVideoAnalyticsConfigurations() => Assert.That((await getSubject().GetVideoAnalyticsConfigurations()).Configurations, Is.Not.Null);
        [Test] public async Task GetMetadataConfigurations() => Assert.That((await getSubject().GetMetadataConfigurations()).Configurations, Is.Not.Null);
        [Test] public async Task GetAudioOutputConfigurations() => Assert.That((await getSubject().GetAudioOutputConfigurations()).Configurations, Is.Not.Null);
        [Test] public async Task GetAudioDecoderConfigurations() => Assert.That((await getSubject().GetAudioDecoderConfigurations()).Configurations, Is.Not.Null);

        [Test]
        public async Task GetVideoSourceConfiguration()
        {
            MediaClient mc = getSubject();
            string token = await getVideoSourceConfigurationToken(mc);
            Assert.That((await mc.GetVideoSourceConfiguration(token)).Configuration, Is.Not.Null);
        }

        [Test]
        public async Task GetVideoEncoderConfiguration()
        {
            MediaClient mc = getSubject();
            string token = await getVideoEncoderConfigurationToken(mc);
            Assert.That((await mc.GetVideoEncoderConfiguration(token)).Configuration, Is.Not.Null);
        }

        [Test]
        public async Task GetAudioSourceConfiguration()
        {
            MediaClient mc = getSubject();
            string token = await getAudioSourceConfigurationToken(mc);
            Assert.That((await mc.GetAudioSourceConfiguration(token)).Configuration, Is.Not.Null);
        }

        [Test]
        public async Task GetAudioEncoderConfiguration()
        {
            MediaClient mc = getSubject();
            string token = await getAudioEncoderConfigurationToken(mc);
            Assert.That((await mc.GetAudioEncoderConfiguration(token)).Configuration, Is.Not.Null);
        }

        [Test]
        public async Task GetVideoAnalyticsConfiguration()
        {
            MediaClient mc = getSubject();
            string token = await getVideoAnalyticsConfigurationToken(mc);
            Assert.That((await mc.GetVideoAnalyticsConfiguration(token)).Configuration, Is.Not.Null);
        }

        [Test]
        public async Task GetMetadataConfiguration()
        {
            MediaClient mc = getSubject();
            string token = await getMetadataConfigurationToken(mc);
            Assert.That((await mc.GetMetadataConfiguration(token)).Configuration, Is.Not.Null);
        }

        [Test]
        public async Task GetAudioOutputConfiguration()
        {
            MediaClient mc = getSubject();
            string token = await getAudioOutputConfigurationToken(mc);
            Assert.That((await mc.GetAudioOutputConfiguration(token)).Configuration, Is.Not.Null);
        }

        [Test]
        public async Task GetAudioDecoderConfiguration()
        {
            MediaClient mc = getSubject();
            string token = await getAudioDecoderConfigurationToken(mc);
            Assert.That((await mc.GetAudioDecoderConfiguration(token)).Configuration, Is.Not.Null);
        }

        [Test] public async Task GetCompatibleVideoEncoderConfigurations() { MediaClient mc = getSubject(); string token = await getProfileToken(mc); Assert.That((await mc.GetCompatibleVideoEncoderConfigurations(token)).Configurations, Is.Not.Null); }
        [Test] public async Task GetCompatibleVideoSourceConfigurations() { MediaClient mc = getSubject(); string token = await getProfileToken(mc); Assert.That((await mc.GetCompatibleVideoSourceConfigurations(token)).Configurations, Is.Not.Null); }
        [Test] public async Task GetCompatibleAudioEncoderConfigurations() { MediaClient mc = getSubject(); string token = await getProfileToken(mc); Assert.That((await mc.GetCompatibleAudioEncoderConfigurations(token)).Configurations, Is.Not.Null); }
        [Test] public async Task GetCompatibleAudioSourceConfigurations() { MediaClient mc = getSubject(); string token = await getProfileToken(mc); Assert.That((await mc.GetCompatibleAudioSourceConfigurations(token)).Configurations, Is.Not.Null); }
        [Test] public async Task GetCompatibleVideoAnalyticsConfigurations() { MediaClient mc = getSubject(); string token = await getProfileToken(mc); Assert.That((await mc.GetCompatibleVideoAnalyticsConfigurations(token)).Configurations, Is.Not.Null); }
        [Test] public async Task GetCompatibleMetadataConfigurations() { MediaClient mc = getSubject(); string token = await getProfileToken(mc); Assert.That((await mc.GetCompatibleMetadataConfigurations(token)).Configurations, Is.Not.Null); }
        [Test] public async Task GetCompatibleAudioOutputConfigurations() { MediaClient mc = getSubject(); string token = await getProfileToken(mc); Assert.That((await mc.GetCompatibleAudioOutputConfigurations(token)).Configurations, Is.Not.Null); }
        [Test] public async Task GetCompatibleAudioDecoderConfigurations() { MediaClient mc = getSubject(); string token = await getProfileToken(mc); Assert.That((await mc.GetCompatibleAudioDecoderConfigurations(token)).Configurations, Is.Not.Null); }

        [Test] public async Task GetVideoSourceConfigurationOptions() { MediaClient mc = getSubject(); string p = await getProfileToken(mc); string c = await getVideoSourceConfigurationToken(mc); Assert.That((await mc.GetVideoSourceConfigurationOptions(c, p)).Options, Is.Not.Null); }
        [Test] public async Task GetVideoEncoderConfigurationOptions() { MediaClient mc = getSubject(); string p = await getProfileToken(mc); string c = await getVideoEncoderConfigurationToken(mc); Assert.That((await mc.GetVideoEncoderConfigurationOptions(c, p)).Options, Is.Not.Null); }
        [Test] public async Task GetAudioSourceConfigurationOptions() { MediaClient mc = getSubject(); string p = await getProfileToken(mc); string c = await getAudioSourceConfigurationToken(mc); Assert.That((await mc.GetAudioSourceConfigurationOptions(c, p)).Options, Is.Not.Null); }
        [Test] public async Task GetAudioEncoderConfigurationOptions() { MediaClient mc = getSubject(); string p = await getProfileToken(mc); string c = await getAudioEncoderConfigurationToken(mc); Assert.That((await mc.GetAudioEncoderConfigurationOptions(c, p)).Options, Is.Not.Null); }
        [Test] public async Task GetMetadataConfigurationOptions() { MediaClient mc = getSubject(); string p = await getProfileToken(mc); string c = await getMetadataConfigurationToken(mc); Assert.That((await mc.GetMetadataConfigurationOptions(c, p)).Options, Is.Not.Null); }
        [Test] public async Task GetAudioOutputConfigurationOptions() { MediaClient mc = getSubject(); string p = await getProfileToken(mc); string c = await getAudioOutputConfigurationToken(mc); Assert.That((await mc.GetAudioOutputConfigurationOptions(c, p)).Options, Is.Not.Null); }
        [Test] public async Task GetAudioDecoderConfigurationOptions() { MediaClient mc = getSubject(); string p = await getProfileToken(mc); string c = await getAudioDecoderConfigurationToken(mc); Assert.That((await mc.GetAudioDecoderConfigurationOptions(c, p)).Options, Is.Not.Null); }

        [Test]
        public async Task GetGuaranteedNumberOfVideoEncoderInstances()
        {
            MediaClient mc = getSubject();
            string token = await getVideoEncoderConfigurationToken(mc);
            Assert.That((await mc.GetGuaranteedNumberOfVideoEncoderInstances(token)).TotalNumber, Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public async Task GetStreamUri()
        {
            MediaClient mc = getSubject();
            string profileToken = await getProfileToken(mc);
            GetStreamUriResponse response = await mc.GetStreamUri(createStreamSetup(), profileToken);
            Assert.That(response.MediaUri, Is.Not.Null);
            Assert.That(response.MediaUri.Uri, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public async Task GetSnapshotUri()
        {
            MediaClient mc = getSubject();
            string profileToken = await getProfileToken(mc);
            GetSnapshotUriResponse response = await mc.GetSnapshotUri(profileToken);
            Assert.That(response.MediaUri, Is.Not.Null);
            Assert.That(response.MediaUri.Uri, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public async Task GetVideoSourceModes()
        {
            MediaClient mc = getSubject();
            GetServiceCapabilitiesResponse capabilities = await mc.GetServiceCapabilities();
            if (!string.Equals(capabilities?.Capabilities?.VideoSourceMode, "true", StringComparison.OrdinalIgnoreCase))
            {
                Assert.Ignore("GetVideoSourceModes is not supported by this device.");
            }

            string token = await getVideoSourceToken(mc);
            Assert.That((await mc.GetVideoSourceModes(token)).VideoSourceModes, Is.Not.Null);
        }

        [Test]
        public async Task GetOSDs()
        {
            MediaClient mc = getSubject();
            GetServiceCapabilitiesResponse capabilities = await mc.GetServiceCapabilities();
            if (!string.Equals(capabilities?.Capabilities?.OSD, "true", StringComparison.OrdinalIgnoreCase))
            {
                Assert.Ignore("OSD is not supported by this device.");
            }

            string token = await getVideoSourceConfigurationToken(mc);
            Assert.That((await mc.GetOSDs(token)).OSDs, Is.Not.Null);
        }

        [Test]
        public async Task GetOSD()
        {
            MediaClient mc = getSubject();
            GetServiceCapabilitiesResponse capabilities = await mc.GetServiceCapabilities();
            if (!string.Equals(capabilities?.Capabilities?.OSD, "true", StringComparison.OrdinalIgnoreCase))
            {
                Assert.Ignore("OSD is not supported by this device.");
            }

            GetOSDsResponse osds = await mc.GetOSDs(await getVideoSourceConfigurationToken(mc));
            string token = osds.OSDs?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No OSD token found on this device.");
            }

            Assert.That((await mc.GetOSD(token)).OSD, Is.Not.Null);
        }

        [Test]
        public async Task GetOSDOptions()
        {
            MediaClient mc = getSubject();
            GetServiceCapabilitiesResponse capabilities = await mc.GetServiceCapabilities();
            if (!string.Equals(capabilities?.Capabilities?.OSD, "true", StringComparison.OrdinalIgnoreCase))
            {
                Assert.Ignore("OSD is not supported by this device.");
            }

            string token = await getVideoSourceConfigurationToken(mc);
            Assert.That((await mc.GetOSDOptions(token)).OSDOptions, Is.Not.Null);
        }

        private static async Task<string> getProfileToken(MediaClient mc)
        {
            GetProfilesResponse response = await mc.GetProfiles();
            string token = response.Profiles?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No profile token found on this device.");
            }
            return token;
        }

        private static async Task<string> getVideoSourceToken(MediaClient mc)
        {
            GetVideoSourcesResponse response = await mc.GetVideoSources();
            string token = response.VideoSources?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No video source token found on this device.");
            }
            return token;
        }

        private static async Task<string> getVideoSourceConfigurationToken(MediaClient mc)
        {
            GetVideoSourceConfigurationsResponse response = await mc.GetVideoSourceConfigurations();
            string token = response.Configurations?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No video source configuration token found on this device.");
            }
            return token;
        }

        private static async Task<string> getVideoEncoderConfigurationToken(MediaClient mc)
        {
            GetVideoEncoderConfigurationsResponse response = await mc.GetVideoEncoderConfigurations();
            string token = response.Configurations?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No video encoder configuration token found on this device.");
            }
            return token;
        }

        private static async Task<string> getAudioSourceConfigurationToken(MediaClient mc)
        {
            GetAudioSourceConfigurationsResponse response = await mc.GetAudioSourceConfigurations();
            string token = response.Configurations?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No audio source configuration token found on this device.");
            }
            return token;
        }

        private static async Task<string> getAudioEncoderConfigurationToken(MediaClient mc)
        {
            GetAudioEncoderConfigurationsResponse response = await mc.GetAudioEncoderConfigurations();
            string token = response.Configurations?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No audio encoder configuration token found on this device.");
            }
            return token;
        }

        private static async Task<string> getVideoAnalyticsConfigurationToken(MediaClient mc)
        {
            GetVideoAnalyticsConfigurationsResponse response = await mc.GetVideoAnalyticsConfigurations();
            string token = response.Configurations?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No video analytics configuration token found on this device.");
            }
            return token;
        }

        private static async Task<string> getMetadataConfigurationToken(MediaClient mc)
        {
            GetMetadataConfigurationsResponse response = await mc.GetMetadataConfigurations();
            string token = response.Configurations?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No metadata configuration token found on this device.");
            }
            return token;
        }

        private static async Task<string> getAudioOutputConfigurationToken(MediaClient mc)
        {
            GetAudioOutputConfigurationsResponse response = await mc.GetAudioOutputConfigurations();
            string token = response.Configurations?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No audio output configuration token found on this device.");
            }
            return token;
        }

        private static async Task<string> getAudioDecoderConfigurationToken(MediaClient mc)
        {
            GetAudioDecoderConfigurationsResponse response = await mc.GetAudioDecoderConfigurations();
            string token = response.Configurations?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No audio decoder configuration token found on this device.");
            }
            return token;
        }

        private static StreamSetup createStreamSetup()
        {
            return new StreamSetup
            {
                Stream = StreamType.RTPUnicast,
                Transport = new Transport
                {
                    Protocol = TransportProtocol.RTSP
                }
            };
        }

        private static MediaClient getSubject()
        {
            MediaClient ic = new MediaClient
            {
                ServiceUri = new Uri("http://192.168.3.19:8000/onvif/media_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return ic;
        }
    }
}
