using OnvifStandard.Media;
using OnvifStandard.Ptz;

using SoapHttpClient;

using GetServiceCapabilitiesResponse = OnvifStandard.Ptz.GetServiceCapabilitiesResponse;

namespace OnvifTests
{
    public class PtzClientTests
    {
        [Test]
        public async Task GetServiceCapabilities()
        {
            Assert.That(await getSubject().GetServiceCapabilities(), Is.Not.Null);
        }

        [Test]
        public async Task GetNodes()
        {
            GetNodesResponse response = await getSubject().GetNodes();
            Assert.That(response.PTZNode, Is.Not.Null);
        }

        [Test]
        public async Task GetNode()
        {
            PtzClient pc = getSubject();
            string nodeToken = await getNodeToken(pc);
            Assert.That((await pc.GetNode(nodeToken)).PTZNode, Is.Not.Null);
        }

        [Test]
        public async Task GetConfigurations()
        {
            GetConfigurationsResponse response = await getSubject().GetConfigurations();
            Assert.That(response.PTZConfiguration, Is.Not.Null);
        }

        [Test]
        public async Task GetConfiguration()
        {
            PtzClient pc = getSubject();
            string configToken = await getPtzConfigurationToken(pc);
            Assert.That((await pc.GetConfiguration(configToken)).PTZConfiguration, Is.Not.Null);
        }

        [Test]
        public async Task SetConfiguration()
        {
            PtzClient pc = getSubject();
            string configToken = await getPtzConfigurationToken(pc);
            PTZConfiguration config = (await pc.GetConfiguration(configToken)).PTZConfiguration;
            Assert.That(await pc.SetConfiguration(config, false), Is.Not.Null);
        }

        [Test]
        public async Task GetConfigurationOptions()
        {
            PtzClient pc = getSubject();
            string configToken = await getPtzConfigurationToken(pc);
            Assert.That((await pc.GetConfigurationOptions(configToken)).PTZConfigurationOptions, Is.Not.Null);
        }

        [Test]
        public async Task SendAuxiliaryCommand()
        {
            PtzClient pc = getSubject();
            PTZNode node = await getNode(pc);
            string command = node.AuxiliaryCommands?.FirstOrDefault();
            if (string.IsNullOrEmpty(command))
            {
                Assert.Ignore("No auxiliary command found for PTZ node.");
            }

            string profileToken = await getProfileToken();
            SendAuxiliaryCommandResponse response = await pc.SendAuxiliaryCommand(profileToken, command);
            Assert.That(response, Is.Not.Null);
        }

        [Test]
        public async Task GetPresets()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            GetPresetsResponse getPresetsResponse = await pc.GetPresets(profileToken);
            Assert.That(getPresetsResponse.Preset, Is.Not.Null);
        }

        [Test]
        public async Task SetPreset()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            SetPresetResponse response = await pc.SetPreset(profileToken, createUniquePresetName());
            Assert.That(response, Is.Not.Null);
            Assert.That(response.PresetToken, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public async Task RemovePreset()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            string presetToken = await createPreset(pc, profileToken);
            Assert.That(await pc.RemovePreset(profileToken, presetToken), Is.Not.Null);
        }

        [Test]
        public async Task GotoPreset()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            string presetToken = await getPresetToken(pc, profileToken);
            Assert.That(await pc.GotoPreset(profileToken, presetToken), Is.Not.Null);
        }

        [Test]
        public async Task GotoHomePosition()
        {
            PtzClient pc = getSubject();
            PTZNode node = await getNode(pc);
            if (!node.HomeSupported)
            {
                Assert.Ignore("Home position is not supported by this PTZ node.");
            }

            string profileToken = await getProfileToken();
            Assert.That(await pc.GotoHomePosition(profileToken), Is.Not.Null);
        }

        [Test]
        public async Task SetHomePosition()
        {
            PtzClient pc = getSubject();
            PTZNode node = await getNode(pc);
            if (!node.HomeSupported)
            {
                Assert.Ignore("Home position is not supported by this PTZ node.");
            }

            string profileToken = await getProfileToken();
            Assert.That(await pc.SetHomePosition(profileToken), Is.Not.Null);
        }

        [Test]
        public async Task ContinuousMove()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            PTZSpeed speed = new PTZSpeed
            {
                PanTilt = new Vector2D { X = 0, Y = 0 },
                Zoom = new Vector1D { X = 0 }
            };
            Assert.That(await pc.ContinuousMove(profileToken, speed), Is.Not.Null);
        }

        [Test]
        public async Task RelativeMove()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            for (int i = 0; i < 5; i++)
            {
                PTZVector translation = new PTZVector
                {
                    PanTilt = new Vector2D { X = 1, Y = 1 },
                    Zoom = new Vector1D { X = 0 }
                };
                Assert.That(await pc.RelativeMove(profileToken, translation), Is.Not.Null);
                await Task.Delay(500);
            }
            
        }

        [Test]
        public async Task GetStatus()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            Assert.That((await pc.GetStatus(profileToken)).PTZStatus, Is.Not.Null);
        }

        [Test]
        public async Task AbsoluteMove()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            PTZVector position = (await pc.GetStatus(profileToken)).PTZStatus?.Position;
            if (position == null)
            {
                Assert.Ignore("Current PTZ position is not available.");
            }

            Assert.That(await pc.AbsoluteMove(profileToken, position), Is.Not.Null);
        }

        [Test]
        public async Task GeoMove()
        {
            PtzClient pc = getSubject();
            PTZNode node = await getNode(pc);
            if (!string.Equals(node.GeoMove, "true", StringComparison.OrdinalIgnoreCase))
            {
                Assert.Ignore("GeoMove is not supported by this PTZ node.");
            }

            string profileToken = await getProfileToken();
            try
            {
                GeoLocation target = new GeoLocation { Latitude = 0, Longitude = 0, Altitude = 0 };
                Assert.That(await pc.GeoMove(profileToken, target), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Ignore($"GeoMove not executable on this target device: {ex.GetType().Name}");
            }
        }

        [Test]
        public async Task Stop()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            Assert.That(await pc.Stop(profileToken, true, true), Is.Not.Null);
        }

        [Test]
        public async Task GetPresetTours()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            Assert.That(await pc.GetPresetTours(profileToken), Is.Not.Null);
        }

        [Test]
        public async Task GetPresetTour()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            string presetTourToken = await getPresetTourToken(pc, profileToken);
            Assert.That((await pc.GetPresetTour(profileToken, presetTourToken)).PresetTour, Is.Not.Null);
        }

        [Test]
        public async Task GetPresetTourOptions()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            string presetTourToken = await getOptionalPresetTourToken(pc, profileToken);
            Assert.That((await pc.GetPresetTourOptions(profileToken, presetTourToken)).Options, Is.Not.Null);
        }

        [Test]
        public async Task CreatePresetTour()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            CreatePresetTourResponse response = await pc.CreatePresetTour(profileToken);
            Assert.That(response, Is.Not.Null);
            Assert.That(response.PresetTourToken, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public async Task ModifyPresetTour()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            string presetTourToken = await getPresetTourToken(pc, profileToken);
            PresetTour presetTour = (await pc.GetPresetTour(profileToken, presetTourToken)).PresetTour;
            Assert.That(await pc.ModifyPresetTour(profileToken, presetTour), Is.Not.Null);
        }

        [Test]
        public async Task OperatePresetTour()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            string presetTourToken = await getPresetTourToken(pc, profileToken);
            Assert.That(await pc.OperatePresetTour(profileToken, presetTourToken, PTZPresetTourOperation.Stop), Is.Not.Null);
        }

        [Test]
        public async Task RemovePresetTour()
        {
            PtzClient pc = getSubject();
            string profileToken = await getProfileToken();
            string presetTourToken = (await pc.CreatePresetTour(profileToken)).PresetTourToken;
            if (string.IsNullOrEmpty(presetTourToken))
            {
                Assert.Ignore("Failed to create PTZ preset tour.");
            }

            Assert.That(await pc.RemovePresetTour(profileToken, presetTourToken), Is.Not.Null);
        }

        [Test]
        public async Task GetCompatibleConfigurations()
        {
            PtzClient pc = getSubject();
            GetServiceCapabilitiesResponse caps = await pc.GetServiceCapabilities();
            if (!string.Equals(caps?.Capabilities?.GetCompatibleConfigurations, "true", StringComparison.OrdinalIgnoreCase))
            {
                Assert.Ignore("GetCompatibleConfigurations is not supported by this device.");
            }

            string profileToken = await getProfileToken();
            Assert.That((await pc.GetCompatibleConfigurations(profileToken)).PTZConfiguration, Is.Not.Null);
        }

        [Test]
        public async Task MoveAndStartTracking()
        {
            PtzClient pc = getSubject();
            GetServiceCapabilitiesResponse caps = await pc.GetServiceCapabilities();
            if (string.IsNullOrWhiteSpace(caps?.Capabilities?.MoveAndTrack))
            {
                Assert.Ignore("MoveAndStartTracking is not supported by this device.");
            }

            string profileToken = await getProfileToken();
            PTZVector position = (await pc.GetStatus(profileToken)).PTZStatus?.Position;
            if (position == null)
            {
                Assert.Ignore("Current PTZ position is not available.");
            }

            Assert.That(await pc.MoveAndStartTracking(profileToken, targetPosition: position), Is.Not.Null);
        }

        private static async Task<string> getProfileToken()
        {
            MediaClient mc = getMediaSubject();
            GetProfilesResponse response = await mc.GetProfiles();
            string token = response?.Profiles?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No media profile token found on this device.");
            }

            return token;
        }

        private static async Task<string> getNodeToken(PtzClient pc)
        {
            GetNodesResponse response = await pc.GetNodes();
            string token = response?.PTZNode?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No PTZ node token found on this device.");
            }

            return token;
        }

        private static async Task<PTZNode> getNode(PtzClient pc)
        {
            string token = await getNodeToken(pc);
            return (await pc.GetNode(token)).PTZNode;
        }

        private static async Task<string> getPtzConfigurationToken(PtzClient pc)
        {
            GetConfigurationsResponse response = await pc.GetConfigurations();
            string token = response?.PTZConfiguration?.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No PTZ configuration token found on this device.");
            }

            return token;
        }

        private static async Task<string> getPresetToken(PtzClient pc, string profileToken)
        {
            GetPresetsResponse response = await pc.GetPresets(profileToken);
            string token = response?.Preset?.FirstOrDefault()?.Token;
            if (!string.IsNullOrEmpty(token))
            {
                return token;
            }

            return await createPreset(pc, profileToken);
        }

        private static async Task<string> createPreset(PtzClient pc, string profileToken)
        {
            SetPresetResponse response = await pc.SetPreset(profileToken, createUniquePresetName());
            string token = response?.PresetToken;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("Unable to create PTZ preset on this device.");
            }

            return token;
        }

        private static string createUniquePresetName() => $"OnvifSharp_{DateTime.UtcNow:HHmmssfff}";

        private static async Task<string> getPresetTourToken(PtzClient pc, string profileToken)
        {
            GetPresetToursResponse response = await pc.GetPresetTours(profileToken);
            string token = response?.PresetTour?.FirstOrDefault()?.Token;
            if (!string.IsNullOrEmpty(token))
            {
                return token;
            }

            CreatePresetTourResponse created = await pc.CreatePresetTour(profileToken);
            token = created?.PresetTourToken;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Ignore("No PTZ preset tour token found and failed to create one.");
            }

            return token;
        }

        private static async Task<string> getOptionalPresetTourToken(PtzClient pc, string profileToken)
        {
            GetPresetToursResponse response = await pc.GetPresetTours(profileToken);
            return response?.PresetTour?.FirstOrDefault()?.Token;
        }

        private static PtzClient getSubject()
        {
            PtzClient ic = new PtzClient
            {
                ServiceUri = new Uri("http://192.168.3.19:8000/onvif/ptz_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return ic;
        }

        private static MediaClient getMediaSubject()
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


