using System;
using System.Net;
using System.Net.Http;

namespace OnvifStandard;

/// <summary>
/// Creates <see cref="HttpClient"/> instances configured as close as possible to the
/// transport behavior of the WCF <c>CustomBinding</c> commonly used for ONVIF
/// (TextMessageEncoding SOAP 1.2 + HttpTransportBindingElement with
/// <c>AllowCookies = true</c>, <c>MaxBufferSize</c> / <c>MaxReceivedMessageSize = int.MaxValue</c>):
/// 1 minute send/receive timeout, cookies enabled, keep-alive connections,
/// no Expect: 100-continue, optional credentials with pre-authentication and
/// automatic decompression.
/// </summary>
public class DefaultSoapHttpClientFactory : IHttpClientFactory
{
    // WCF defaults
    private static readonly TimeSpan DefaultTimeout                = TimeSpan.FromMinutes(1);
    private const           long     DefaultMaxReceivedMessageSize = int.MaxValue;

    private readonly ICredentials m_credentials;
    private readonly TimeSpan     m_timeout;
    private readonly long         m_maxReceivedMessageSize;
    private readonly bool         m_allowAutoRedirect;

    public DefaultSoapHttpClientFactory() : this(null)
    {
    }

    public DefaultSoapHttpClientFactory(ICredentials credentials,
                                        TimeSpan?    timeout                = null,
                                        long?        maxReceivedMessageSize = null,
                                        bool         allowAutoRedirect      = false)
    {
        m_credentials = credentials;
        m_timeout = timeout ?? DefaultTimeout;
        m_maxReceivedMessageSize = maxReceivedMessageSize ?? DefaultMaxReceivedMessageSize;
        m_allowAutoRedirect = allowAutoRedirect;
    }

    public HttpClient CreateClient(string name)
    {
        HttpClientHandler handler = new HttpClientHandler
        {
            AllowAutoRedirect = m_allowAutoRedirect,
            // HttpTransportBindingElement.AllowCookies = true
            UseCookies = true,
            CookieContainer = new CookieContainer(),
            UseProxy = true,
            Proxy = WebRequest.DefaultWebProxy,
            UseDefaultCredentials = m_credentials == null,
            Credentials = m_credentials,
            PreAuthenticate = m_credentials != null,
            // WCF enables decompression on the http transport by default
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
        };

        HttpClient client = new HttpClient(handler, true)
        {
            // WCF SendTimeout / ReceiveTimeout default
            Timeout = m_timeout,
            // HttpTransportBindingElement.MaxReceivedMessageSize
            MaxResponseContentBufferSize = m_maxReceivedMessageSize
        };

        // WCF keeps connections alive and does not use the 100-continue handshake
        client.DefaultRequestHeaders.ExpectContinue = false;
        client.DefaultRequestHeaders.ConnectionClose = false;

        return client;
    }
}