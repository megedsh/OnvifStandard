using System;
using System.Threading.Tasks;

namespace OnvifStandard.Events
{
    public class PullPointSubscriptionClient : OnvifSoapClientBase, IPullPointSubscriptionClient
    {
        public Task<PullMessagesResponse> PullMessages(string timeout, int messageLimit) =>
            send<PullMessagesRequest, PullMessagesResponse>(new PullMessagesRequest
            {
                Timeout = timeout,
                MessageLimit = messageLimit
            });

        public Task<SeekResponse> Seek(DateTime utcTime, bool? reverse = null)
        {
            SeekRequest request = new SeekRequest
            {
                UtcTime = utcTime,
                Reverse = reverse ?? false
            };

            return send<SeekRequest, SeekResponse>(request);
        }

        public Task<SetSynchronizationPointResponse> SetSynchronizationPoint() => send<SetSynchronizationPointRequest, SetSynchronizationPointResponse>(new SetSynchronizationPointRequest());

        public Task<RenewResponse> Renew(AbsoluteOrRelativeTimeType terminationTime = null) =>
            send<RenewRequest, RenewResponse>(new RenewRequest
            {
                TerminationTime = terminationTime
            });

        public Task<UnsubscribeResponse> Unsubscribe() => send<UnsubscribeRequest, UnsubscribeResponse>(new UnsubscribeRequest());
    }
}