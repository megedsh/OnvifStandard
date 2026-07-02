
namespace OnvifTests;

public interface ITestingClient
{
    Task<TRes> GenericRequest<TReq, TRes>(Uri uri, TReq req);
    Uri ServiceUri { get; }
}