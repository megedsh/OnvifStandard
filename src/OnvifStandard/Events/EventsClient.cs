using System.Threading.Tasks;

namespace OnvifStandard.Events
{
    public class EventsClient : OnvifSoapClientBase, IEventsClient
    {
        public Task<GetServiceCapabilitiesResponse> GetServiceCapabilities() => send<GetServiceCapabilitiesRequest, GetServiceCapabilitiesResponse>(new GetServiceCapabilitiesRequest());

        public Task<CreatePullPointSubscriptionResponse> CreatePullPointSubscription(FilterType                 filter                 = null,
                                                                                     AbsoluteOrRelativeTimeType initialTerminationTime = null,
                                                                                     SubscriptionPolicy         subscriptionPolicy     = null) =>
            send<CreatePullPointSubscriptionRequest, CreatePullPointSubscriptionResponse>(new CreatePullPointSubscriptionRequest
            {
                Filter = filter,
                InitialTerminationTime = initialTerminationTime,
                SubscriptionPolicy = subscriptionPolicy
            });

        public Task<GetEventPropertiesResponse> GetEventProperties() => send<GetEventPropertiesRequest, GetEventPropertiesResponse>(new GetEventPropertiesRequest());

        public Task<SubscribeResponse> Subscribe(EndpointReferenceType      consumerReference,
                                                 FilterType                 filter                 = null,
                                                 AbsoluteOrRelativeTimeType initialTerminationTime = null,
                                                 SubscriptionPolicy         subscriptionPolicy     = null) =>
            send<SubscribeRequest, SubscribeResponse>(new SubscribeRequest
            {
                ConsumerReference = consumerReference,
                Filter = filter,
                InitialTerminationTime = initialTerminationTime,
                SubscriptionPolicy = subscriptionPolicy
            });

        public Task<AddEventBrokerResponse> AddEventBroker(EventBrokerConfig eventBroker) =>
            send<AddEventBrokerRequest, AddEventBrokerResponse>(new AddEventBrokerRequest
            {
                EventBroker = eventBroker
            });

        public Task<DeleteEventBrokerResponse> DeleteEventBroker(string address) =>
            send<DeleteEventBrokerRequest, DeleteEventBrokerResponse>(new DeleteEventBrokerRequest
            {
                Address = address
            });

        public Task<GetEventBrokersResponse> GetEventBrokers(string address = null) =>
            send<GetEventBrokersRequest, GetEventBrokersResponse>(new GetEventBrokersRequest
            {
                Address = address
            });
    }
}