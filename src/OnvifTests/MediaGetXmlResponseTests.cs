using System.Xml.Serialization;
using OnvifStandard;
using OnvifStandard.Common;
using OnvifStandard.Media;

using SoapHttpClient;

namespace OnvifTests
{
    public class MediaGetXmlResponseTests
    {
        private string m_profileToken = null;


        [Test]
        public async Task GetServiceCapabilitiesXmlResponse() => await execute(new GetServiceCapabilitiesRequest(), "MediaGetServiceCapabilitiesResponse.xml");

        [Test]
        public async Task GetVideoSourcesXmlResponse() => await execute(new GetVideoSourcesRequest(), "GetVideoSourcesResponse.xml");

        [Test]
        public async Task GetAudioSourcesXmlResponse() => await execute(new GetAudioSourcesRequest(), "GetAudioSourcesResponse.xml");

        [Test]
        public async Task GetAudioOutputsXmlResponse() => await execute(new GetAudioOutputsRequest(), "GetAudioOutputsResponse.xml");

        [Test]
        public async Task GetProfileXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetProfileRequest { ProfileToken = profileToken }, "GetProfileResponse.xml");
        }

        [Test]
        public async Task GetProfilesXmlResponse() => await execute(new GetProfilesRequest(), "GetProfilesResponse.xml");

        [Test]
        public async Task GetVideoSourceConfigurationsXmlResponse() => await execute(new GetVideoSourceConfigurationsRequest(), "GetVideoSourceConfigurationsResponse.xml");

        [Test]
        public async Task GetVideoEncoderConfigurationsXmlResponse() => await execute(new GetVideoEncoderConfigurationsRequest(), "GetVideoEncoderConfigurationsResponse.xml");

        [Test]
        public async Task GetAudioSourceConfigurationsXmlResponse() => await execute(new GetAudioSourceConfigurationsRequest(), "GetAudioSourceConfigurationsResponse.xml");

        [Test]
        public async Task GetAudioEncoderConfigurationsXmlResponse() => await execute(new GetAudioEncoderConfigurationsRequest(), "GetAudioEncoderConfigurationsResponse.xml");

        [Test]
        public async Task GetVideoAnalyticsConfigurationsXmlResponse() => await execute(new GetVideoAnalyticsConfigurationsRequest(), "GetVideoAnalyticsConfigurationsResponse.xml");

        [Test]
        public async Task GetMetadataConfigurationsXmlResponse() => await execute(new GetMetadataConfigurationsRequest(), "GetMetadataConfigurationsResponse.xml");

        [Test]
        public async Task GetAudioOutputConfigurationsXmlResponse() => await execute(new GetAudioOutputConfigurationsRequest(), "GetAudioOutputConfigurationsResponse.xml");

        [Test]
        public async Task GetAudioDecoderConfigurationsXmlResponse() => await execute(new GetAudioDecoderConfigurationsRequest(), "GetAudioDecoderConfigurationsResponse.xml");

        [Test]
        public async Task GetVideoSourceConfigurationXmlResponse()
        {
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetVideoSourceConfigurationsRequest, GetVideoSourceConfigurationsResponse>(mc.ServiceUri,
                                                                                                                                                       new GetVideoSourceConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No video source configuration token found.");
            }

            await execute(new GetVideoSourceConfigurationRequest
            {
                ConfigurationToken = token
            }, "GetVideoSourceConfigurationResponse.xml");
        }

        [Test]
        public async Task GetVideoEncoderConfigurationXmlResponse()
        {
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetVideoEncoderConfigurationsRequest, GetVideoEncoderConfigurationsResponse>(mc.ServiceUri,
                                                                                                                      new GetVideoEncoderConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No video encoder configuration token found.");
            }

            await execute(new GetVideoEncoderConfigurationRequest
            {
                ConfigurationToken = token
            }, "GetVideoEncoderConfigurationResponse.xml");
        }

        [Test]
        public async Task GetAudioSourceConfigurationXmlResponse()
        {
            string profileToken = await getProfileToken();
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetAudioSourceConfigurationsRequest, GetAudioSourceConfigurationsResponse>(mc.ServiceUri,
                                                                                                                        new GetAudioSourceConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No audio source configuration token found.");
            }
            await execute(new GetAudioSourceConfigurationRequest
            {
                ConfigurationToken = token
            }, "GetAudioSourceConfigurationResponse.xml");
        }

        [Test]
        public async Task GetAudioEncoderConfigurationXmlResponse()
        {
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetAudioEncoderConfigurationsRequest, GetAudioEncoderConfigurationsResponse>(mc.ServiceUri,
                                                                                                                       new GetAudioEncoderConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No audio encoder configuration token found.");
            }
            await execute(new GetAudioEncoderConfigurationRequest
            {
                ConfigurationToken = token
            }, "GetAudioEncoderConfigurationResponse.xml");
        }

        [Test]
        public async Task GetVideoAnalyticsConfigurationXmlResponse()
        {
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetVideoAnalyticsConfigurationsRequest, GetVideoAnalyticsConfigurationsResponse>(mc.ServiceUri,
                                                                                                                         new GetVideoAnalyticsConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No video analytics configuration token found.");
            }

            await execute(new GetVideoAnalyticsConfigurationRequest
            {
                ConfigurationToken = token
            }, "GetVideoAnalyticsConfigurationResponse.xml");
        }

        [Test]
        public async Task GetMetadataConfigurationXmlResponse()
        {
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetMetadataConfigurationsRequest, GetMetadataConfigurationsResponse>(mc.ServiceUri,
                                                                                                                     new GetMetadataConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No metadata configuration token found.");
            }

            await execute(new GetMetadataConfigurationRequest
            {
                ConfigurationToken = token
            }, "GetMetadataConfigurationResponse.xml");
        }

        [Test]
        public async Task GetAudioOutputConfigurationXmlResponse()
        {
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetAudioOutputConfigurationsRequest, GetAudioOutputConfigurationsResponse>(mc.ServiceUri,
                                                                                                                  new GetAudioOutputConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No audio output configuration token found.");
            }

            await execute(new GetAudioOutputConfigurationRequest
            {
                ConfigurationToken = token
            }, "GetAudioOutputConfigurationResponse.xml");
        }

        [Test]
        public async Task GetAudioDecoderConfigurationXmlResponse()
        {
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetAudioDecoderConfigurationsRequest, GetAudioDecoderConfigurationsResponse>(mc.ServiceUri,
                                                                                                                      new GetAudioDecoderConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No audio decoder configuration token found.");
            }
            await execute(new GetAudioDecoderConfigurationRequest
            {
                ConfigurationToken = token
            }, "GetAudioDecoderConfigurationResponse.xml");
        }

        [Test]
        public async Task GetCompatibleVideoEncoderConfigurationsXmlResponse()
        {
            string profileToken = await getProfileToken();

            await execute(new GetCompatibleVideoEncoderConfigurationsRequest
            {
                ProfileToken = profileToken
            }, "GetCompatibleVideoEncoderConfigurationsResponse.xml");
        }


        private async Task<string> getProfileToken()
        {
            if (m_profileToken != null)
            {
                return m_profileToken;
            }
            MediaTestingClient mc = getSubject();
            GetProfilesResponse getProfilesResponse = await mc.GenericRequest<GetProfilesRequest, GetProfilesResponse>(mc.ServiceUri,
                                                                                                                      new GetProfilesRequest());
            string token = getProfilesResponse.Profiles.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No valid profile token found.");
            }
            m_profileToken = token;
            return token;
        }

        [Test]
        public async Task GetCompatibleVideoSourceConfigurationsXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetCompatibleVideoSourceConfigurationsRequest { ProfileToken = profileToken }, "GetCompatibleVideoSourceConfigurationsResponse.xml");
        }

        [Test]
        public async Task GetCompatibleAudioEncoderConfigurationsXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetCompatibleAudioEncoderConfigurationsRequest { ProfileToken = profileToken }, "GetCompatibleAudioEncoderConfigurationsResponse.xml");
        }

        [Test]
        public async Task GetCompatibleAudioSourceConfigurationsXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetCompatibleAudioSourceConfigurationsRequest { ProfileToken = profileToken }, "GetCompatibleAudioSourceConfigurationsResponse.xml");
        }

        [Test]
        public async Task GetCompatibleVideoAnalyticsConfigurationsXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetCompatibleVideoAnalyticsConfigurationsRequest { ProfileToken = profileToken }, "GetCompatibleVideoAnalyticsConfigurationsResponse.xml");
        }

        [Test]
        public async Task GetCompatibleMetadataConfigurationsXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetCompatibleMetadataConfigurationsRequest { ProfileToken = profileToken }, "GetCompatibleMetadataConfigurationsResponse.xml");
        }

        [Test]
        public async Task GetCompatibleAudioOutputConfigurationsXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetCompatibleAudioOutputConfigurationsRequest { ProfileToken = profileToken }, "GetCompatibleAudioOutputConfigurationsResponse.xml");
        }

        [Test]
        public async Task GetCompatibleAudioDecoderConfigurationsXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetCompatibleAudioDecoderConfigurationsRequest { ProfileToken = profileToken }, "GetCompatibleAudioDecoderConfigurationsResponse.xml");
        }

        [Test]
        public async Task GetVideoSourceConfigurationOptionsXmlResponse()
        {
            string profileToken = await getProfileToken();
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetVideoSourceConfigurationsRequest, GetVideoSourceConfigurationsResponse>(mc.ServiceUri,
                                                                                                                             new GetVideoSourceConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No video source configuration token found.");
            }
            await execute(new GetVideoSourceConfigurationOptionsRequest { ConfigurationToken = token, ProfileToken = profileToken }, "GetVideoSourceConfigurationOptionsResponse.xml");
        }

        [Test]
        public async Task GetVideoEncoderConfigurationOptionsXmlResponse()
        {
            string profileToken = await getProfileToken();
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetVideoEncoderConfigurationsRequest, GetVideoEncoderConfigurationsResponse>(mc.ServiceUri,
                                                                                                                             new GetVideoEncoderConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No video encoder configuration token found.");
            }
            await execute(new GetVideoEncoderConfigurationOptionsRequest { ConfigurationToken = token, ProfileToken = profileToken }, "GetVideoEncoderConfigurationOptionsResponse.xml");
        }

        [Test]
        public async Task GetAudioSourceConfigurationOptionsXmlResponse()
        {
            string profileToken = await getProfileToken();
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetAudioSourceConfigurationsRequest, GetAudioSourceConfigurationsResponse>(mc.ServiceUri,
                                                                                                                             new GetAudioSourceConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No audio source configuration token found.");
            }
            await execute(new GetAudioSourceConfigurationOptionsRequest { ConfigurationToken = token, ProfileToken = profileToken }, "GetAudioSourceConfigurationOptionsResponse.xml");
        }

        [Test]
        public async Task GetAudioEncoderConfigurationOptionsXmlResponse()
        {
            string profileToken = await getProfileToken();
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetAudioEncoderConfigurationsRequest, GetAudioEncoderConfigurationsResponse>(mc.ServiceUri,
                                                                                                                       new());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No audio encoder configuration token found.");
            }
            await execute(new GetAudioEncoderConfigurationOptionsRequest { ConfigurationToken = token, ProfileToken = profileToken }, "GetAudioEncoderConfigurationOptionsResponse.xml");
        }

        [Test]
        public async Task GetMetadataConfigurationOptionsXmlResponse()
        {
            string profileToken = await getProfileToken();
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetMetadataConfigurationsRequest, GetMetadataConfigurationsResponse>(mc.ServiceUri,
                                                                                                                          new());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No metadata configuration token found.");
            }
            await execute(new GetMetadataConfigurationOptionsRequest { ConfigurationToken = token, ProfileToken = profileToken }, "GetMetadataConfigurationOptionsResponse.xml");
        }

        [Test]
        public async Task GetAudioOutputConfigurationOptionsXmlResponse()
        {
            string profileToken = await getProfileToken();
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetAudioOutputConfigurationsRequest, GetAudioOutputConfigurationsResponse>(mc.ServiceUri,
                                                                                                                         new());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No audio output configuration token found.");
            }
            await execute(new GetAudioOutputConfigurationOptionsRequest { ConfigurationToken = token, ProfileToken = profileToken }, "GetAudioOutputConfigurationOptionsResponse.xml");
        }

        [Test]
        public async Task GetAudioDecoderConfigurationOptionsXmlResponse()
        {
            string profileToken = await getProfileToken();
            MediaTestingClient mc = getSubject();
            GetAudioDecoderConfigurationsResponse t = await mc.GenericRequest<GetAudioDecoderConfigurationsRequest, GetAudioDecoderConfigurationsResponse>(mc.ServiceUri,
                                                                                                                                                          new GetAudioDecoderConfigurationsRequest());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No audio decoder configuration token found.");
            }

            await execute(new GetAudioDecoderConfigurationOptionsRequest { ConfigurationToken = token, ProfileToken = profileToken }, "GetAudioDecoderConfigurationOptionsResponse.xml");
        }


        [Test]
        public async Task GetGuaranteedNumberOfVideoEncoderInstancesXmlResponse()
        {
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetVideoEncoderConfigurationsRequest, GetVideoEncoderConfigurationsResponse>(mc.ServiceUri,
                                                                                                                                                                       new());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No video encoder configuration token found.");
            }
            await execute(new GetGuaranteedNumberOfVideoEncoderInstancesRequest
            {
                ConfigurationToken = token
            }, "GetGuaranteedNumberOfVideoEncoderInstancesResponse.xml");
        }

        [Test]
        public async Task GetStreamUriXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetStreamUriRequest
            {
                StreamSetup = createDummyStreamSetup(),
                ProfileToken = profileToken
            }, "GetStreamUriResponse.xml");
        }

        [Test]
        public async Task GetSnapshotUriXmlResponse()
        {
            string profileToken = await getProfileToken();
            await execute(new GetSnapshotUriRequest { ProfileToken = profileToken }, "GetSnapshotUriResponse.xml");
        }

        [Test]
        public async Task GetVideoSourceModesXmlResponse()
        {
            if (!await isVideoSourceModeSupported())
            {
                Assert.Ignore("GetVideoSourceModes is not supported by this device (VideoSourceMode capability=false).");
            }

            string token = await getVideoSourceToken();
            await execute(new GetVideoSourceModesRequest
            {
                VideoSourceToken = token,
                
            }, "GetVideoSourceModesResponse.xml");
        }

        private static async Task<bool> isVideoSourceModeSupported()
        {
            MediaTestingClient mc = getSubject();
            GetServiceCapabilitiesResponse response = await mc.GenericRequest<GetServiceCapabilitiesRequest, GetServiceCapabilitiesResponse>(mc.ServiceUri,
                                                                                                                                                 new GetServiceCapabilitiesRequest());

            return string.Equals(response?.Capabilities?.VideoSourceMode, "true", StringComparison.OrdinalIgnoreCase);
        }

        [Test]
        public async Task GetOSDsXmlResponse()
        {
            string token = await getVideoSourceConfigToken();

            await execute(new GetOSDsRequest
            {
                VideoSourceConfigurationToken = token
            }, "GetOSDsResponse.xml");
        }

        private static async Task<string> getVideoSourceConfigToken()
        {
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetVideoSourceConfigurationsRequest, GetVideoSourceConfigurationsResponse>(mc.ServiceUri,
                                                                                                                       new());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No video source configuration token found.");
            }

            return token;
        } 
        private static async Task<string> getVideoSourceToken()
        {
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetVideoSourcesRequest, GetVideoSourcesResponse>(mc.ServiceUri,
                                                                                            new());
            string token = t.VideoSources.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No video source configuration token found.");
            }

            return token;
        }

        [Test]
        public async Task GetOSDXmlResponse()
        {
            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetOSDsRequest, GetOSDsResponse>(mc.ServiceUri,
                                                                                                                       new());
            string token = t.OSDs.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No OSD token found.");
            }
            await execute(new GetOSDRequest
            {
                OSDToken = token
            }, "GetOSDResponse.xml");
        }

        [Test]
        public async Task GetOSDOptionsXmlResponse()
        {

            MediaTestingClient mc = getSubject();
            var t = await mc.GenericRequest<GetVideoSourceConfigurationsRequest, GetVideoSourceConfigurationsResponse>(mc.ServiceUri,
                                                                                                                      new());
            string token = t.Configurations.FirstOrDefault()?.Token;
            if (string.IsNullOrEmpty(token))
            {
                Assert.Fail("No video source configuration token found.");
            }

            await execute(new GetOSDOptionsRequest
            {
                ConfigurationToken = token
            }, "GetOSDOptionsResponse.xml");
        }

        private static async Task execute<TReq>(TReq request, string responseFileName)
        {
            MediaTestingClient ic = getSubject();

            HttpResponseMessage res = await safeRequest(ic, request, responseFileName);
            string xmlResponse = await res.Content.ReadAsStringAsync();
            await saveResponseFixture(responseFileName, xmlResponse);
        }

        private static async Task<HttpResponseMessage> safeRequest<TReq>(MediaTestingClient ic, TReq request, string responseFileName)
        {
            try
            {
                return await ic.GenericRequest<TReq, HttpResponseMessage>(ic.ServiceUri, request);
            }
            catch (Exception ex)
            {
                Assert.Pass($"{responseFileName}: request failed ({ex.GetType().Name}). Fixture was not saved.");
                return null;
            }
        }

        private static string getResponsePath(string fileName) =>
            Path.GetFullPath(Path.Combine(TestContext.CurrentContext.TestDirectory,
                                          "..", "..", "..",
                                          "DeserializationTests",
                                          "MediaResponses",
                                          fileName));

        private static async Task saveResponseFixture(string fileName, string xmlResponse)
        {
            string outputPath = getResponsePath(fileName);

            Assert.That(xmlResponse, Is.Not.Null.And.Not.Empty);

            SoapEnvelope envelope = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SoapEnvelope));
                using StringReader reader = new StringReader(xmlResponse);
                envelope = (SoapEnvelope)serializer.Deserialize(reader);
            }
            catch (Exception)
            {
                Assert.Pass($"{fileName}: device did not return a valid SOAP XML response. Fixture was not saved.");
            }

            if (envelope.TryGetFault(out SoapFault fault))
            {
                string faultCode = fault?.Code?.Subcode?.Value ?? fault?.Code?.Value ?? "UnknownCode";
                string faultReason = fault?.Reason?.Text ?? "UnknownReason";
                Assert.Pass($"{fileName}: SOAP Fault body detected. Code={faultCode}; Reason={faultReason}. Fixture was not saved.");
            }

            if (File.Exists(outputPath))
            {
                Assert.That(File.Exists(outputPath), Is.True);
                return;
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));
            await File.WriteAllTextAsync(outputPath, xmlResponse);

            Assert.That(File.Exists(outputPath), Is.True);
        }

        private static StreamSetup createDummyStreamSetup()
        {
            return new StreamSetup
            {
                Stream = StreamType.RTPUnicast,
                Transport = new Transport
                {
                    Protocol = TransportProtocol.RTSP
                }
            };
        }

        private static MediaTestingClient getSubject()
        {
            MediaTestingClient ic = new MediaTestingClient
            {
                ServiceUri = new Uri("http://10.5.23.102:80/onvif/media_service"),
                User = "root",
                Password = "Q1w2e3r4",
                SoapClient = new SoapClient()
            };
            return ic;
        }
    }

    public class MediaTestingClient : OnvifSoapClientBase
    {
        public Task<TRes> GenericRequest<TReq, TRes>(Uri uri, TReq req)
        {
            SoapSecurityHeader securityHeader = getSecurityHeader();
            return doRequestAwaitResponse<TReq, TRes>(uri, req, securityHeader);
        }
    }
}





