using System.Threading.Tasks;

namespace OnvifStandard.Events;

public interface IEventsClient: IOnvifSoapClient
{
    Task<GetServiceCapabilitiesResponse> GetServiceCapabilities();

    Task<CreatePullPointSubscriptionResponse> CreatePullPointSubscription(FilterType                 filter                 = null,
                                                                          AbsoluteOrRelativeTimeType initialTerminationTime = null,
                                                                          SubscriptionPolicy         subscriptionPolicy     = null);

    Task<GetEventPropertiesResponse> GetEventProperties();

    Task<SubscribeResponse> Subscribe(EndpointReferenceType      consumerReference,
                                      FilterType                 filter                 = null,
                                      AbsoluteOrRelativeTimeType initialTerminationTime = null,
                                      SubscriptionPolicy         subscriptionPolicy     = null);

    Task<AddEventBrokerResponse>    AddEventBroker(EventBrokerConfig eventBroker);
    Task<DeleteEventBrokerResponse> DeleteEventBroker(string         address);
    Task<GetEventBrokersResponse>   GetEventBrokers(string           address = null);
}