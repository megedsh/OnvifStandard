[![License](https://img.shields.io/github/license/megedsh/OnvifStandard.svg)](https://github.com/megedsh/OnvifStandard/blob/master/LICENSE.txt)
[![NuGet](https://img.shields.io/nuget/v/OnvifStandard.svg)](https://nuget.org/packages/OnvifStandard)

<img src="Icon.png" width="300">

# 🌐 OnvifStandard — Modern ONVIF for .NET (No WCF)

A **.NET Standard 2.0** library for interacting with ONVIF‑compliant devices (IP cameras, NVRs, encoders) using **SOAP over HTTP** — **without WCF bindings**.  
Built for modern .NET, lightweight, and easy to extend.

---

## ✨ Features
- Pure **.NET Standard 2.0** implementation  
- **No WCF**, no generated bindings  
- Uses the excellent [`SoapHttpClient`](https://github.com/pmorelli92/SoapHttpClient)  
- Supports:
  - Device Service  
  - Media Service  
  - Imaging Service  
  - PTZ Service
  - Events Service  

---

### 📘 Short Example — Get RTSP Stream + PTZ Control

```csharp
using OnvifStandard;
using OnvifStandard.Media;
using OnvifStandard.Ptz;

// 1. Connect to the device. Init synchronizes device time, reads capabilities,
//    and creates clients for the services advertised by the device.
var device = new OnvifDevice(
    new Uri("http://camera-ip/onvif/device_service"),
    "username",
    "password");

await device.Init();

// 2. Use the initialized Device client.
var deviceInfo = await device.DeviceClient.GetDeviceInformation();
Console.WriteLine($"{deviceInfo.Manufacturer} {deviceInfo.Model}");

// 3. Get an available media profile.
if (!device.MediaAvailable)
{
    throw new InvalidOperationException("The device does not advertise the Media service.");
}

var profilesResponse = await device.MediaClient.GetProfiles();
var profile = profilesResponse.Profiles.First();

// 4. Get the RTSP stream URI
var streamSetup = new StreamSetup
{
    Stream = StreamType.RTPUnicast,
    Transport = new Transport { Protocol = TransportProtocol.RTSP }
};
var streamUriResponse = await device.MediaClient.GetStreamUri(streamSetup, profile.Token);
Console.WriteLine($"RTSP URI: {streamUriResponse.MediaUri.Uri}");

// 5. Use the initialized PTZ client when the service is available.
if (device.PtzAvailable)
{
    var velocity = new PTZSpeed
    {
        PanTilt = new Vector2D { X = 0.5f, Y = 0 }, // pan right
        Zoom = new Vector1D { X = 0.2f }            // zoom in
    };

    await device.PtzClient.ContinuousMove(profile.Token, velocity);
}

```
---
## 💡 Why This Library Exists
I couldn’t find a modern, lightweight ONVIF library for .NET that didn’t rely on WCF.
Most ONVIF libraries rely on WCF bindings generated via `svcutil` or `dotnet-svcutil`.  
With modern tooling (including AI-assisted code generation), ONVIF services can be implemented **cleanly**, **manually**, and **without WCF**.  
This project aims to be a **modern, lightweight alternative** for developers who want ONVIF support without legacy baggage.

---

## 🛠️ Support & Compatibility
ONVIF devices vary widely — many implement only parts of the spec, and some behave… creatively.

If your device:
- fails on a specific call  
- returns unexpected SOAP responses  
- needs a custom quirk or extension  

👉 **Open an issue!**  
I’ll help add support, and contributions are very welcome.

Most of the code is AI‑generated, and only the features I needed are fully tested.  
If something doesn’t work, report it — or send a PR.

---

## ⚠️ Known Limitations
- **Not a video streaming library.**  
  ONVIF provides RTSP URLs; you’ll need another library to decode or display video.
- Some devices use **non‑standard ONVIF implementations**, which may require special handling.

---

## 🙏 Acknowledgements
- Inspired by the ONVIF standard and existing ONVIF libraries.  
- SOAP communication powered by [`SoapHttpClient`](https://github.com/pmorelli92/SoapHttpClient).  
  Go give that project a star — it deserves it.

---

## 🤝 Want to Contribute?
This project is intentionally simple and approachable — perfect for contributors.

Ways you can help:
- Add support for more ONVIF services  
- Improve device compatibility  
- Fix or refine AI‑generated DTOs  
- Add tests  
- Improve documentation  
- Share device logs or quirks  

A `CONTRIBUTING.md` will be added soon, but until then feel free to open issues or PRs.

---

## 🚀 Coming Soon (Community Roadmap)

- More ONVIF services
- Discovery 
