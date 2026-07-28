using System;
using System.Threading.Tasks;

namespace OnvifStandard.Events;

public interface IPullPointSubscriptionClient:IOnvifSoapClient
{
    Task<PullMessagesResponse>            PullMessages(string timeout, int   messageLimit);
    Task<SeekResponse>                    Seek(DateTime       utcTime, bool? reverse = null);
    Task<SetSynchronizationPointResponse> SetSynchronizationPoint();
    Task<RenewResponse>                   Renew(AbsoluteOrRelativeTimeType terminationTime = null);
    Task<UnsubscribeResponse>             Unsubscribe();
}