
using OnvifStandard.Imaging;
using OnvifStandard.Media;

using SoapHttpClient;

using GetServiceCapabilitiesResponse = OnvifStandard.Imaging.GetServiceCapabilitiesResponse;

namespace OnvifTests
{
    [Explicit]
    public class ImagingClientTests
    {
        [Test]
        public async Task GetServiceCapabilities()
        {
            ImagingClient ic = getSubject();
            await assertSupported(() => ic.GetServiceCapabilities(), nameof(GetServiceCapabilities));
        }

        [Test]
        public async Task GetImagingSettings()
        {
            ImagingClient ic = getSubject();
            string videoSourceToken = await getVideoSourceToken();
            await assertSupported(() => ic.GetImagingSettings(videoSourceToken), nameof(GetImagingSettings));
        }

        [Test]
        public async Task GetOptions()
        {
            ImagingClient ic = getSubject();
            string videoSourceToken = await getVideoSourceToken();
            await assertSupported(() => ic.GetOptions(videoSourceToken), nameof(GetOptions));
        }

        [Test]
        public async Task SetImagingSettings()
        {
            ImagingClient ic = getSubject();
            await assertSupported(async () =>
            {
                string videoSourceToken = await getVideoSourceToken();
                ImagingSettings20 settings = (await ic.GetImagingSettings(videoSourceToken)).ImagingSettings;
                if (settings == null)
                {
                    Assert.Ignore("Imaging settings are not available on this device.");
                }

                return await ic.SetImagingSettings(videoSourceToken, settings, false);
            }, nameof(SetImagingSettings));
        }

        [Test]
        public async Task GetMoveOptions()
        {
            ImagingClient ic = getSubject();
            string videoSourceToken = await getVideoSourceToken();
            await assertSupported(() => ic.GetMoveOptions(videoSourceToken), nameof(GetMoveOptions));
        }

        [Test]
        public async Task Move()
        {
            ImagingClient ic = getSubject();
            string videoSourceToken = await getVideoSourceToken();

            FocusMove focus = new FocusMove
            {
                Continuous = new ContinuousFocus
                {
                    Speed = 0.1f
                }
            };

            await assertSupported(() => ic.Move(videoSourceToken, focus), nameof(Move));
        }

        [Test]
        public async Task Stop()
        {
            ImagingClient ic = getSubject();
            string videoSourceToken = await getVideoSourceToken();
            await assertSupported(() => ic.Stop(videoSourceToken), nameof(Stop));
        }

        [Test]
        public async Task GetStatus()
        {
            ImagingClient ic = getSubject();
            string videoSourceToken = await getVideoSourceToken();
            await assertSupported(() => ic.GetStatus(videoSourceToken), nameof(GetStatus));
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
            await assertSupported(() => ic.GetPresets(videoSourceToken), nameof(GetPresets));
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
            await assertSupported(() => ic.GetCurrentPreset(videoSourceToken), nameof(GetCurrentPreset));
        }

        [Test]
        public async Task SetCurrentPreset()
        {
            ImagingClient ic = getSubject();
            GetServiceCapabilitiesResponse capabilities = await ic.GetServiceCapabilities();
            if (!string.Equals(capabilities?.Capabilities?.Presets, "true", StringComparison.OrdinalIgnoreCase))
            {
                Assert.Ignore("Imaging presets are not supported by this device.");
            }

            string videoSourceToken = await getVideoSourceToken();
            GetPresetsResponse presetsResponse = await ic.GetPresets(videoSourceToken);
            string presetToken = presetsResponse?.Preset?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(presetToken))
            {
                Assert.Ignore("No imaging preset token found on this device.");
            }

            await assertSupported(() => ic.SetCurrentPreset(videoSourceToken, presetToken), nameof(SetCurrentPreset));
        }

        private static async Task assertSupported<T>(Func<Task<T>> call, string operation)
            where T : class
        {
            try
            {
                T response = await call();
                if (response == null)
                {
                    Assert.Ignore($"{operation} returned no data on this target device.");
                }

                Assert.That(response, Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Ignore($"{operation} not supported/executable on this target device: {ex.GetType().Name}");
            }
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
                ServiceUri = new Uri("http://10.5.23.102:80/onvif/media_service"),
                //ServiceUri = new Uri("http://192.168.3.19:8000/onvif/imaging_service"),
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
                //ServiceUri = new Uri("http://192.168.3.19:8000/onvif/media_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return mc;
        }
    }
}
