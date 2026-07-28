using OnvifStandard;

namespace OnvifTests
{
    [Explicit]
    public class OnvifDeviceTests
    {
        [Test]
        public void ConstructorDoesNotInitializeClients()
        {
            OnvifDevice device = getSubject();

            Assert.That(device.DeviceClient,           Is.Null);
            Assert.That(device.DeviceCapabilities,     Is.Null);
            Assert.That(device.PtzAvailable,           Is.False);
            Assert.That(device.MediaAvailable,         Is.False);
            Assert.That(device.ImagingClientAvailable, Is.False);
        }

        [Test]
        public async Task InitInitializesDeviceClientAndCapabilities()
        {
            OnvifDevice device = getSubject();

            await device.Init();

            Assert.That(device.DeviceClient,       Is.Not.Null);
            Assert.That(device.DeviceCapabilities, Is.Not.Null);
        }

        [Test]
        public async Task InitCalculatesDeviceTimeShift()
        {
            OnvifDevice device = getSubject();

            await device.Init();

            Assert.That(device.DeviceClient.DeviceTimeShift, Is.EqualTo(device.DeviceTimeShift));
            Assert.That(device.DeviceTimeShift.Duration(),   Is.LessThan(TimeSpan.FromDays(1)));
        }

        [Test]
        public async Task InitCreatesClientsForAdvertisedServices()
        {
            OnvifDevice device = getSubject();

            await device.Init();

            Assert.That(device.PtzAvailable,
                        Is.EqualTo(!string.IsNullOrEmpty(device.DeviceCapabilities.PTZ?.XAddr)));
            Assert.That(device.MediaAvailable,
                        Is.EqualTo(!string.IsNullOrEmpty(device.DeviceCapabilities.Media?.XAddr)));
            Assert.That(device.ImagingClientAvailable,
                        Is.EqualTo(!string.IsNullOrEmpty(device.DeviceCapabilities.Imaging?.XAddr)));

            if (device.PtzAvailable)
            {
                Assert.That(device.PtzClient.ServiceUri.AbsoluteUri,
                            Is.EqualTo(device.DeviceCapabilities?.PTZ?.XAddr));
                Assert.That(device.PtzClient.DeviceTimeShift, Is.EqualTo(device.DeviceTimeShift));
            }

            if (device.MediaAvailable)
            {
                Assert.That(device.MediaClient.ServiceUri.AbsoluteUri,
                            Is.EqualTo(device.DeviceCapabilities?.Media?.XAddr));
                Assert.That(device.MediaClient.DeviceTimeShift, Is.EqualTo(device.DeviceTimeShift));
            }

            if (device.ImagingClientAvailable)
            {
                Assert.That(device.ImagingClient.ServiceUri.AbsoluteUri,
                            Is.EqualTo(device.DeviceCapabilities?.Imaging?.XAddr));
                Assert.That(device.ImagingClient.DeviceTimeShift, Is.EqualTo(device.DeviceTimeShift));
            }
        }

        [Test]
        public async Task TestConnectivityReturnsTrueAfterSuccessfulInitialization()
        {
            OnvifDevice device = getSubject();
            await device.Init();

            if (!device.MediaAvailable)
            {
                Assert.Ignore("Media service is not advertised by this device.");
            }

            Exception connectivityException = null;
            bool connected = await device.TestConnectivity(ex => connectivityException = ex);

            Assert.That(connected,             Is.True, connectivityException?.Message);
            Assert.That(connectivityException, Is.Null);
        }

        [Test]
        public async Task TestConnectivityReportsFailureBeforeInitialization()
        {
            OnvifDevice device = getSubject();
            Exception connectivityException = null;

            bool connected = await device.TestConnectivity(ex => connectivityException = ex);

            Assert.That(connected,             Is.False);
            Assert.That(connectivityException, Is.TypeOf<NullReferenceException>());
        }

        private static OnvifDevice getSubject() =>
            new OnvifDevice(new Uri("http://192.168.3.19:8000/onvif/device_service"),
                            "root",
                            "Q1w2e3r4");
    }
}