using System;
using System.Net.Http;
using System.Threading.Tasks;

using OnvifStandard.Device;
using OnvifStandard.Imaging;
using OnvifStandard.Media;
using OnvifStandard.Ptz;

using SoapHttpClient;

using Capabilities = OnvifStandard.Device.Capabilities;

namespace OnvifStandard
{
    public class OnvifDevice
    {
        public IHttpClientFactory HttpClientFactory { get; }
        private readonly string m_user;
        private readonly string m_password;
        private readonly Uri    m_uri;
        public TimeSpan DeviceTimeShift { get; private set; }
        public Capabilities DeviceCapabilities { get; set; }
        public IDeviceClient DeviceClient { get; private set; }
        public IPtzClient PtzClient { get; private set; }
        public IImagingClient ImagingClient { get; private set; }
        public IMediaClient MediaClient { get; private set; }

        public bool PtzAvailable => PtzClient != null;
        public bool MediaAvailable => MediaClient != null;
        public bool ImagingClientAvailable => ImagingClient != null;

        public OnvifDevice(string host,
                           string user,
                           string password,
                           IHttpClientFactory httpClientFactory = null) : this(new Uri($"http://{host}/onvif/device_service"), user, password,httpClientFactory)
        {
        }

        public OnvifDevice(Uri uri, string user, string password, IHttpClientFactory httpClientFactory = null)
        {
            HttpClientFactory = httpClientFactory?? new DefaultSoapHttpClientFactory();
            m_uri = uri;
            m_user = user;
            m_password = password;
        }

        public async Task Init()
        {
            DeviceClient = new DeviceClient
            {
                ServiceUri = m_uri,
                User = m_user,
                Password = m_password,
                SoapClient = new SoapClient(HttpClientFactory)
            };

            GetSystemDateAndTimeResponse sysDateTime = await DeviceClient.GetSystemDateAndTime();

            DeviceDateTime utc = sysDateTime.SystemDateAndTime.UTCDateTime;
            DateTime dt = new DateTime(utc.Date.Year, utc.Date.Month, utc.Date.Day,
                                       utc.Time.Hour, utc.Time.Minute, utc.Time.Second);
            DeviceTimeShift = dt - DateTime.UtcNow;

            DeviceClient.SetTimeShift(DeviceTimeShift);

            GetCapabilitiesResponse capabilitiesResponse = await DeviceClient.GetCapabilities([CapabilityCategory.All]);
            DeviceCapabilities = capabilitiesResponse.Capabilities;

            if (!string.IsNullOrEmpty(DeviceCapabilities.PTZ?.XAddr))
            {
                PtzClient = new PtzClient
                {
                    ServiceUri = new Uri(DeviceCapabilities.PTZ.XAddr),
                    User = m_user,
                    Password = m_password,
                    DeviceTimeShift = DeviceTimeShift,
                    SoapClient= new SoapClient(HttpClientFactory)
                };
            }

            if (!string.IsNullOrEmpty(DeviceCapabilities.Media?.XAddr))
            {
                MediaClient = new MediaClient
                {
                    ServiceUri = new Uri(DeviceCapabilities.Media.XAddr),
                    User = m_user,
                    Password = m_password,
                    DeviceTimeShift = DeviceTimeShift,
                    SoapClient= new SoapClient(HttpClientFactory)
                };
            }

            if (!string.IsNullOrEmpty(DeviceCapabilities.Imaging?.XAddr))
            {
                ImagingClient = new ImagingClient
                {
                    ServiceUri = new Uri(DeviceCapabilities.Imaging.XAddr),
                    User = m_user,
                    Password = m_password,
                    DeviceTimeShift = DeviceTimeShift,
                    SoapClient= new SoapClient(HttpClientFactory)
                };
            }
        }

        public async Task<bool> TestConnectivity(Action<Exception> exception = null)
        {
            try
            {
                _ = await DeviceClient.GetSystemDateAndTime().ConfigureAwait(false);
                return true;
            }
            catch (Exception ex)
            {
                exception?.Invoke(ex);
                return false;
            }
        }

        public async Task<bool> TestConnectivityAndAuthentication(Action<Exception> exception = null)
        {
            try
            {
                _ = await DeviceClient.GetCapabilities([CapabilityCategory.Device]).ConfigureAwait(false);
                return true;
            }
            catch (Exception ex)
            {
                exception?.Invoke(ex);
                return false;
            }
        }
    }
}