[![License](https://img.shields.io/github/license/megedsh/OnvifStandard.svg)](https://github.com/megedsh/OnvifStandard/blob/master/LICENSE.txt) 
[![NuGet](https://img.shields.io/nuget/v/OnvifStandard.svg)](https://nuget.org/packages/OnvifStandard) 

<img src="Icon.png" width="300">

# OnvifStandard

A .NET Standard 2.0 library for interacting with ONVIF-compliant devices (such as IP cameras) using SOAP over HTTP.  
**This library does not use WCF bindings** and instead leverages the [`SoapHttpClient`](https://github.com/pmorelli92/SoapHttpClient) package for SOAP communication.

## Features

- Pure .NET Standard 2.0 implementation
- No WCF dependencies or bindings
- Supports ONVIF Device, Media, Imaging, and PTZ services

## Reasons
- The reason for creating this library is that all other libs that I tried all used generated WCF bindings that started having compatibility issues with latest .net components.
- Most use WSDL code generation done by `svcutil` or `dotnet-svcutil` which creates WCF clients and Dtos.
- Using AI I can now generate the code for the ONVIF services and messages without WCF bindings.
- This library provides a modern, lightweight alternative for developers who need to interact with ONVIF devices without relying on outdated WCF bindings.

## Support
- Not every ONVIF device implements all services, so if you have a device that is not working with this library please open an issue and I will try to add support for it.
- Most of the code is AI generated, some functions might not work out of the box, I tested just the features I needed. report any issues and I will try to fix them.

## Known Issues
- This is not a video streaming lib - it is a library for interacting with ONVIF devices using SOAP over HTTP. If you need to stream video, you will need to use another library or implement the streaming functionality yourself.
- Some ONVIF devices have non-standard implementations of the ONVIF protocol, which may cause compatibility issues. If you encounter any issues, please report them and I will try to address them.

## Acknowledgements
- This library is inspired by the work of other ONVIF libraries and the ONVIF standard itself.
- The [`SoapHttpClient`](https://github.com/pmorelli92/SoapHttpClient) package is used for SOAP communication, which is a lightweight alternative to WCF bindings. go give him a star.
