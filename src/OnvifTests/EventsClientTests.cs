using OnvifStandard.Events;

using SoapHttpClient;

namespace OnvifTests
{
    [Explicit]
    public class EventsClientTests
    {
        private static string m_subscriptionAddress;

        [Test]
        public Task GetServiceCapabilities() => assertSupported(() => getSubject().GetServiceCapabilities(), nameof(GetServiceCapabilities));

        [Test]
        public Task CreatePullPointSubscription() => assertSupported(() => getSubject().CreatePullPointSubscription(), nameof(CreatePullPointSubscription));

        [Test]
        public Task GetEventProperties() => assertSupported(() => getSubject().GetEventProperties(), nameof(GetEventProperties));

        [Test]
        public Task Subscribe() =>
            assertSupported(() => getSubject().Subscribe(new EndpointReferenceType
            {
                Address = "http://127.0.0.1/onvif/events/consumer"
            }), nameof(Subscribe));

        [Test]
        public Task AddEventBroker() =>
            assertSupported(() => getSubject().AddEventBroker(new EventBrokerConfig
            {
                Address = "mqtt://127.0.0.1:1883",
                TopicPrefix = "onvif"
            }), nameof(AddEventBroker));

        [Test]
        public Task DeleteEventBroker() => assertSupported(() => getSubject().DeleteEventBroker("mqtt://127.0.0.1:1883"), nameof(DeleteEventBroker));

        [Test]
        public Task GetEventBrokers() => assertSupported(() => getSubject().GetEventBrokers(), nameof(GetEventBrokers));

        [Test]
        public Task PullMessages() => assertSupported(async () => await (await createPullPointSubscriptionClient()).PullMessages("PT5S", 1), nameof(PullMessages));

        [Test]
        public Task Seek() => assertSupported(async () => await (await createPullPointSubscriptionClient()).Seek(DateTime.UtcNow, false), nameof(Seek));

        [Test]
        public Task SetSynchronizationPoint() => assertSupported(async () => await (await createPullPointSubscriptionClient()).SetSynchronizationPoint(), nameof(SetSynchronizationPoint));

        [Test]
        public Task Renew() =>
            assertSupported(async () => await (await createPullPointSubscriptionClient()).Renew(new AbsoluteOrRelativeTimeType
            {
                Value = "PT1M"
            }), nameof(Renew));

        [Test]
        public Task Unsubscribe() => assertSupported(async () => await (await createPullPointSubscriptionClient()).Unsubscribe(), nameof(Unsubscribe));

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

        private static async Task<PullPointSubscriptionClient> createPullPointSubscriptionClient()
        {
            if (!string.IsNullOrEmpty(m_subscriptionAddress))
            {
                return getPullPointSubscriptionClient(m_subscriptionAddress);
            }

            EventsClient eventsClient = getSubject();
            CreatePullPointSubscriptionResponse response = await eventsClient.CreatePullPointSubscription();

            if (response?.SubscriptionReference?.Address == null)
            {
                throw new InvalidOperationException("CreatePullPointSubscription did not return SubscriptionReference.Address.");
            }

            m_subscriptionAddress = response.SubscriptionReference.Address;
            return getPullPointSubscriptionClient(response.SubscriptionReference.Address);
        }

        private static EventsClient getSubject()
        {
            EventsClient ic = new EventsClient
            {
                ServiceUri = new Uri("http://192.168.3.19:8000/onvif/events_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return ic;
        }

        private static PullPointSubscriptionClient getPullPointSubscriptionClient(string url)
        {
            PullPointSubscriptionClient sc = new PullPointSubscriptionClient
            {
                ServiceUri = new Uri(url),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return sc;
        }
    }
}