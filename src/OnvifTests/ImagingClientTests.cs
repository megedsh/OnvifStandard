
using OnvifStandard.Imaging;
using OnvifStandard.Media;

using SoapHttpClient;

using GetServiceCapabilitiesResponse = OnvifStandard.Imaging.GetServiceCapabilitiesResponse;

namespace OnvifTests
{
    public class ImagingClientTests
    {
        [Test]
        public async Task GetServiceCapabilities()
        {
            ImagingClient ic = getSubject();
            Assert.That(await ic.GetServiceCapabilities(), Is.Not.Null);
        }

        [Test]
        public async Task GetImagingSettings()
        {
            ImagingClient ic = getSubject();
            string videoSourceToken = await getVideoSourceToken();
            Assert.That(await ic.GetImagingSettings(videoSourceToken), Is.Not.Null);
        }

        [Test]
        public async Task GetOptions()
        {
            ImagingClient ic = getSubject();
            string videoSourceToken = await getVideoSourceToken();
            Assert.That(await ic.GetOptions(videoSourceToken), Is.Not.Null);
        }

        [Test]
        public async Task GetMoveOptions()
        {
            ImagingClient ic = getSubject();
            string videoSourceToken = await getVideoSourceToken();
            Assert.That(await ic.GetMoveOptions(videoSourceToken), Is.Not.Null);
        }

        [Test]
        public async Task GetStatus()
        {
            ImagingClient ic = getSubject();
            string videoSourceToken = await getVideoSourceToken();
            Assert.That(await ic.GetStatus(videoSourceToken), Is.Not.Null);
        }

        [Test]
        public async Task GetPresets()
        {
            ImagingClient ic = getSubject();
            GetServiceCapabilitiesResponse capabilities = await ic.GetServiceCapabilities();
            if (!string.Equals(capabilities?.Capabilities?.Presets, "true", StringComparison.OrdinalIgnoreCase))
            {
                Assert.Ignore("Imaging presets are not supported by this device.");
            }

            string videoSourceToken = await getVideoSourceToken();
            Assert.That(await ic.GetPresets(videoSourceToken), Is.Not.Null);
        }

        [Test]
        public async Task GetCurrentPreset()
        {
            ImagingClient ic = getSubject();
            GetServiceCapabilitiesResponse capabilities = await ic.GetServiceCapabilities();
            if (!string.Equals(capabilities?.Capabilities?.Presets, "true", StringComparison.OrdinalIgnoreCase))
            {
                Assert.Ignore("Imaging presets are not supported by this device.");
            }

            string videoSourceToken = await getVideoSourceToken();
            Assert.That(await ic.GetCurrentPreset(videoSourceToken), Is.Not.Null);
        }

        private static async Task<string> getVideoSourceToken()
        {
            MediaClient mc = getMediaSubject();
            GetVideoSourcesResponse response = await mc.GetVideoSources();
            string token = response.VideoSources?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No video source token found on this device.");
            }
            return token;
        }

        private static ImagingClient getSubject()
        {
            ImagingClient ic = new ImagingClient()
            {
                ServiceUri = new Uri("http://10.5.23.102:80/onvif/imaging_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return ic;
        }

        private static MediaClient getMediaSubject()
        {
            MediaClient mc = new MediaClient
            {
                ServiceUri = new Uri("http://10.5.23.102:80/onvif/media_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return mc;
        }
    }
}
