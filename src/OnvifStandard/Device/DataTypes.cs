using System.Xml;
using System;
using System.Xml.Serialization;

namespace OnvifStandard.Device
{
    [XmlRoot("GetServices", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetServicesRequest
    {
        [XmlElement("IncludeCapability", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool IncludeCapability { get; set; }
    }

    [XmlRoot("GetServicesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetServicesResponse
    {
        [XmlElement("Service", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Service[] Service { get; set; }
    }

    public class Service
    {
        [XmlElement("Namespace", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Namespace { get; set; }

        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string XAddr { get; set; }

        [XmlElement("Capabilities", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public ServiceCapabilities Capabilities { get; set; }

        [XmlElement("Version", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public OnvifVersion Version { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class ServiceCapabilities
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("GetServiceCapabilities", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetServiceCapabilitiesRequest
    {
    }

    [XmlRoot("GetServiceCapabilitiesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetServiceCapabilitiesResponse
    {
        [XmlElement("Capabilities", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DeviceServiceCapabilities Capabilities { get; set; }
    }

    public class DeviceServiceCapabilities
    {
        [XmlElement("Network", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DeviceServiceNetworkCapabilities Network { get; set; }

        [XmlElement("Security", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DeviceServiceSecurityCapabilities Security { get; set; }

        [XmlElement("System", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DeviceServiceSystemCapabilities System { get; set; }

        [XmlElement("Misc", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DeviceServiceMiscCapabilities Misc { get; set; }
    }

    public class DeviceServiceNetworkCapabilities
    {
        [XmlAttribute("IPFilter")]
        public string IPFilter { get; set; }

        [XmlAttribute("ZeroConfiguration")]
        public string ZeroConfiguration { get; set; }

        [XmlAttribute("IPVersion6")]
        public string IPVersion6 { get; set; }

        [XmlAttribute("DynDNS")]
        public string DynDNS { get; set; }

        [XmlAttribute("Dot11Configuration")]
        public string Dot11Configuration { get; set; }

        [XmlAttribute("Dot1XConfigurations")]
        public string Dot1XConfigurations { get; set; }

        [XmlAttribute("HostnameFromDHCP")]
        public string HostnameFromDHCP { get; set; }

        [XmlAttribute("NTP")]
        public string NTP { get; set; }

        [XmlAttribute("DHCPv6")]
        public string DHCPv6 { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class DeviceServiceSecurityCapabilities
    {
        [XmlAttribute("TLS1.0")]
        public string TLS10 { get; set; }

        [XmlAttribute("TLS1.1")]
        public string TLS11 { get; set; }

        [XmlAttribute("TLS1.2")]
        public string TLS12 { get; set; }

        [XmlAttribute("OnboardKeyGeneration")]
        public string OnboardKeyGeneration { get; set; }

        [XmlAttribute("AccessPolicyConfig")]
        public string AccessPolicyConfig { get; set; }

        [XmlAttribute("DefaultAccessPolicy")]
        public string DefaultAccessPolicy { get; set; }

        [XmlAttribute("Dot1X")]
        public string Dot1X { get; set; }

        [XmlAttribute("RemoteUserHandling")]
        public string RemoteUserHandling { get; set; }

        [XmlAttribute("X.509Token")]
        public string X509Token { get; set; }

        [XmlAttribute("SAMLToken")]
        public string SAMLToken { get; set; }

        [XmlAttribute("KerberosToken")]
        public string KerberosToken { get; set; }

        [XmlAttribute("UsernameToken")]
        public string UsernameToken { get; set; }

        [XmlAttribute("HttpDigest")]
        public string HttpDigest { get; set; }

        [XmlAttribute("RELToken")]
        public string RELToken { get; set; }

        [XmlAttribute("JsonWebToken")]
        public string JsonWebToken { get; set; }

        [XmlAttribute("SupportedEAPMethods")]
        public string SupportedEAPMethods { get; set; }

        [XmlAttribute("MaxUsers")]
        public string MaxUsers { get; set; }

        [XmlAttribute("MaxUserNameLength")]
        public string MaxUserNameLength { get; set; }

        [XmlAttribute("MaxPasswordLength")]
        public string MaxPasswordLength { get; set; }

        [XmlAttribute("SecurityPolicies")]
        public string SecurityPolicies { get; set; }

        [XmlAttribute("MaxPasswordHistory")]
        public string MaxPasswordHistory { get; set; }

        [XmlAttribute("HashingAlgorithms")]
        public string HashingAlgorithms { get; set; }

        [XmlAttribute("MaxUserRoles")]
        public string MaxUserRoles { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class DeviceServiceSystemCapabilities
    {
        [XmlAttribute("DiscoveryResolve")]
        public string DiscoveryResolve { get; set; }

        [XmlAttribute("DiscoveryBye")]
        public string DiscoveryBye { get; set; }

        [XmlAttribute("RemoteDiscovery")]
        public string RemoteDiscovery { get; set; }

        [XmlAttribute("SystemBackup")]
        public string SystemBackup { get; set; }

        [XmlAttribute("SystemLogging")]
        public string SystemLogging { get; set; }

        [XmlAttribute("FirmwareUpgrade")]
        public string FirmwareUpgrade { get; set; }

        [XmlAttribute("CloudFirmwareUpgrade")]
        public string CloudFirmwareUpgrade { get; set; }

        [XmlAttribute("HttpFirmwareUpgrade")]
        public string HttpFirmwareUpgrade { get; set; }

        [XmlAttribute("HttpSystemBackup")]
        public string HttpSystemBackup { get; set; }

        [XmlAttribute("HttpSystemLogging")]
        public string HttpSystemLogging { get; set; }

        [XmlAttribute("HttpSupportInformation")]
        public string HttpSupportInformation { get; set; }

        [XmlAttribute("StorageConfiguration")]
        public string StorageConfiguration { get; set; }

        [XmlAttribute("MaxStorageConfigurations")]
        public string MaxStorageConfigurations { get; set; }

        [XmlAttribute("StorageConfigurationRenewal")]
        public string StorageConfigurationRenewal { get; set; }

        [XmlAttribute("GeoLocationEntries")]
        public string GeoLocationEntries { get; set; }

        [XmlAttribute("AutoGeo")]
        public string AutoGeo { get; set; }

        [XmlAttribute("StorageTypesSupported")]
        public string StorageTypesSupported { get; set; }

        [XmlAttribute("DiscoveryNotSupported")]
        public string DiscoveryNotSupported { get; set; }

        [XmlAttribute("NetworkConfigNotSupported")]
        public string NetworkConfigNotSupported { get; set; }

        [XmlAttribute("UserConfigNotSupported")]
        public string UserConfigNotSupported { get; set; }

        [XmlAttribute("Addons")]
        public string Addons { get; set; }

        [XmlAttribute("HardwareType")]
        public string HardwareType { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class DeviceServiceMiscCapabilities
    {
        [XmlAttribute("AuxiliaryCommands")]
        public string AuxiliaryCommands { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetSystemDateAndTime", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetSystemDateAndTimeRequest
    {
    }

    [XmlRoot("GetSystemDateAndTimeResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetSystemDateAndTimeResponse
    {
        [XmlElement("SystemDateAndTime", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public SystemDateTimeInfo SystemDateAndTime { get; set; }
    }

    public class SystemDateTimeInfo
    {
        [XmlElement("DateTimeType", Namespace = "http://www.onvif.org/ver10/schema")]
        public SetDateTimeType DateTimeType { get; set; }

        [XmlElement("DaylightSavings", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool DaylightSavings { get; set; }

        [XmlElement("TimeZone", Namespace = "http://www.onvif.org/ver10/schema")]
        public DeviceTimeZone TimeZone { get; set; }

        [XmlElement("UTCDateTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public DeviceDateTime UTCDateTime { get; set; }

        [XmlElement("LocalDateTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public DeviceDateTime LocalDateTime { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public SystemDateTimeExtension Extension { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class SystemDateTimeExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public enum SetDateTimeType
    {
        Manual,
        NTP,
    }

    public class DeviceTimeZone
    {
        [XmlElement("TZ", Namespace = "http://www.onvif.org/ver10/schema")]
        public string TZ { get; set; }
    }

    public class DeviceDateTime
    {
        [XmlElement("Time", Namespace = "http://www.onvif.org/ver10/schema")]
        public DeviceTime Time { get; set; }

        [XmlElement("Date", Namespace = "http://www.onvif.org/ver10/schema")]
        public DeviceDate Date { get; set; }
    }

    public class DeviceDate
    {
        [XmlElement("Year", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Year { get; set; }

        [XmlElement("Month", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Month { get; set; }

        [XmlElement("Day", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Day { get; set; }
    }

    public class DeviceTime
    {
        [XmlElement("Hour", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Hour { get; set; }

        [XmlElement("Minute", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Minute { get; set; }

        [XmlElement("Second", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Second { get; set; }
    }

    [XmlRoot("GetSystemLog", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetSystemLogRequest
    {
        [XmlElement("LogType", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public SystemLogType LogType { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum SystemLogType
    {
        System,
        Access,
    }

    [XmlRoot("GetSystemLogResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetSystemLogResponse
    {
        [XmlElement("SystemLog", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public SystemLogData SystemLog { get; set; }
    }

    public class SystemLogData
    {
        [XmlElement("Binary", Namespace = "http://www.onvif.org/ver10/schema")]
        public AttachmentData Binary { get; set; }

        [XmlElement("String", Namespace = "http://www.onvif.org/ver10/schema")]
        public string String { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("GetSystemSupportInformation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetSystemSupportInformationRequest
    {
    }

    [XmlRoot("GetSystemSupportInformationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetSystemSupportInformationResponse
    {
        [XmlElement("SupportInformation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public SupportInformationData SupportInformation { get; set; }
    }

    public class SupportInformationData
    {
        [XmlElement("Binary", Namespace = "http://www.onvif.org/ver10/schema")]
        public AttachmentData Binary { get; set; }

        [XmlElement("String", Namespace = "http://www.onvif.org/ver10/schema")]
        public string String { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("GetScopes", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetScopesRequest
    {
    }

    [XmlRoot("GetScopesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetScopesResponse
    {
        [XmlElement("Scopes", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public ScopeInfo[] Scopes { get; set; }
    }

    public class ScopeInfo
    {
        [XmlElement("ScopeDef", Namespace = "http://www.onvif.org/ver10/schema")]
        public ScopeDefinition ScopeDef { get; set; }

        [XmlElement("ScopeItem", Namespace = "http://www.onvif.org/ver10/schema")]
        public string ScopeItem { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum ScopeDefinition
    {
        Fixed,
        Configurable,
    }

    [XmlRoot("GetDiscoveryMode", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDiscoveryModeRequest
    {
    }

    [XmlRoot("GetDiscoveryModeResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDiscoveryModeResponse
    {
        [XmlElement("DiscoveryMode", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DiscoveryMode DiscoveryMode { get; set; }
    }

    [XmlRoot("GetRemoteDiscoveryMode", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetRemoteDiscoveryModeRequest
    {
    }

    [XmlRoot("GetRemoteDiscoveryModeResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetRemoteDiscoveryModeResponse
    {
        [XmlElement("RemoteDiscoveryMode", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DiscoveryMode RemoteDiscoveryMode { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum DiscoveryMode
    {
        Discoverable,
        NonDiscoverable,
    }

    [XmlRoot("GetWsdlUrl", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetWsdlUrlRequest
    {
    }

    [XmlRoot("GetWsdlUrlResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetWsdlUrlResponse
    {
        [XmlElement("WsdlUrl", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string WsdlUrl { get; set; }
    }

    [XmlRoot("GetEndpointReference", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetEndpointReferenceRequest
    {
    }

    [XmlRoot("GetEndpointReferenceResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetEndpointReferenceResponse
    {
        [XmlElement("GUID", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string GUID { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("GetHostname", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetHostnameRequest
    {
    }

    [XmlRoot("GetHostnameResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetHostnameResponse
    {
        [XmlElement("HostnameInformation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public HostnameInformation HostnameInformation { get; set; }
    }

    public class HostnameInformation
    {
        [XmlElement("FromDHCP", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool FromDHCP { get; set; }

        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("GetPasswordComplexityOptions", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetPasswordComplexityOptionsRequest
    {
    }

    [XmlRoot("GetPasswordComplexityOptionsResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetPasswordComplexityOptionsResponse
    {
        [XmlElement("MinLenRange", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public IntRange MinLenRange { get; set; }

        [XmlElement("UppercaseRange", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public IntRange UppercaseRange { get; set; }

        [XmlElement("NumberRange", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public IntRange NumberRange { get; set; }

        [XmlElement("SpecialCharsRange", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public IntRange SpecialCharsRange { get; set; }

        [XmlElement("BlockUsernameOccurrenceSupported", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool? BlockUsernameOccurrenceSupported { get; set; }

        [XmlElement("PolicyConfigurationLockSupported", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool? PolicyConfigurationLockSupported { get; set; }
    }

    public class IntRange
    {
        [XmlElement("Min", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Min { get; set; }

        [XmlElement("Max", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Max { get; set; }
    }

    [XmlRoot("GetPasswordComplexityConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetPasswordComplexityConfigurationRequest
    {
    }

    [XmlRoot("GetPasswordComplexityConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetPasswordComplexityConfigurationResponse
    {
        [XmlElement("MinLen", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int? MinLen { get; set; }

        [XmlElement("Uppercase", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int? Uppercase { get; set; }

        [XmlElement("Number", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int? Number { get; set; }

        [XmlElement("SpecialChars", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int? SpecialChars { get; set; }

        [XmlElement("BlockUsernameOccurrence", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool? BlockUsernameOccurrence { get; set; }

        [XmlElement("PolicyConfigurationLocked", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool? PolicyConfigurationLocked { get; set; }
    }

    [XmlRoot("GetPasswordHistoryConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetPasswordHistoryConfigurationRequest
    {
    }

    [XmlRoot("GetPasswordHistoryConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetPasswordHistoryConfigurationResponse
    {
        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool Enabled { get; set; }

        [XmlElement("Length", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int Length { get; set; }
    }

    [XmlRoot("GetAuthFailureWarningOptions", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetAuthFailureWarningOptionsRequest
    {
    }

    [XmlRoot("GetAuthFailureWarningOptionsResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetAuthFailureWarningOptionsResponse
    {
        [XmlElement("MonitorPeriodRange", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public IntRange MonitorPeriodRange { get; set; }

        [XmlElement("AuthFailureRange", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public IntRange AuthFailureRange { get; set; }
    }

    [XmlRoot("GetAuthFailureWarningConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetAuthFailureWarningConfigurationRequest
    {
    }

    [XmlRoot("GetAuthFailureWarningConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetAuthFailureWarningConfigurationResponse
    {
        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool Enabled { get; set; }

        [XmlElement("MonitorPeriod", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int MonitorPeriod { get; set; }

        [XmlElement("MaxAuthFailures", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int MaxAuthFailures { get; set; }
    }

    [XmlRoot("GetSystemBackup", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetSystemBackupRequest
    {
    }

    [XmlRoot("GetSystemBackupResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetSystemBackupResponse
    {
        [XmlElement("BackupFiles", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public BackupFile[] BackupFiles { get; set; }
    }

    public class BackupFile
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name { get; set; }

        [XmlElement("Data", Namespace = "http://www.onvif.org/ver10/schema")]
        public AttachmentData Data { get; set; }
    }

    public class AttachmentData
    {
        [XmlElement("Include", Namespace = "http://www.w3.org/2004/08/xop/include")]
        public XmlElement Include { get; set; }

        [XmlAttribute(AttributeName = "contentType", Namespace = "http://www.w3.org/2005/05/xmlmime")]
        public string ContentType { get; set; }
    }

    [XmlRoot("GetDPAddresses", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDPAddressesRequest
    {
    }

    [XmlRoot("GetDPAddressesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDPAddressesResponse
    {
        [XmlElement("DPAddress", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public NetworkHost[] DPAddress { get; set; }
    }

    [XmlRoot("GetUserRoles", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetUserRolesRequest
    {
        [XmlElement("UserRole", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string UserRole { get; set; }
    }

    [XmlRoot("GetUserRolesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetUserRolesResponse
    {
        [XmlElement("UserRole", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public UserRole[] UserRole { get; set; }
    }

    public class UserRole
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name { get; set; }

        [XmlElement("Functions", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Functions { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetUsers", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetUsersRequest
    {
    }

    [XmlRoot("GetUsersResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetUsersResponse
    {
        [XmlElement("User", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public OnvifUser[] User { get; set; }
    }

    public class OnvifUser
    {
        [XmlElement("Username", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Username { get; set; }

        [XmlElement("Password", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Password { get; set; }

        [XmlElement("UserLevel", Namespace = "http://www.onvif.org/ver10/schema")]
        public UserLevel UserLevel { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public UserExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum UserLevel
    {
        Administrator,
        Operator,
        User,
        Anonymous,
        Extended,
    }

    public class UserExtension
    {
        [XmlElement("Roles", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Roles { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("GetDNS", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDNSRequest
    {
    }

    [XmlRoot("GetDNSResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDNSResponse
    {
        [XmlElement("DNSInformation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DNSInformation DNSInformation { get; set; }
    }

    public class DNSInformation
    {
        [XmlElement("FromDHCP", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool FromDHCP { get; set; }

        [XmlElement("SearchDomain", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] SearchDomain { get; set; }

        [XmlElement("DNSFromDHCP", Namespace = "http://www.onvif.org/ver10/schema")]
        public IPAddress[] DNSFromDHCP { get; set; }

        [XmlElement("DNSManual", Namespace = "http://www.onvif.org/ver10/schema")]
        public IPAddress[] DNSManual { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class IPAddress
    {
        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/schema")]
        public IPType Type { get; set; }

        [XmlElement("IPv4Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public string IPv4Address { get; set; }

        [XmlElement("IPv6Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public string IPv6Address { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum IPType
    {
        IPv4,
        IPv6,
    }

    [XmlRoot("GetNTP", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetNTPRequest
    {
    }

    [XmlRoot("GetNTPResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetNTPResponse
    {
        [XmlElement("NTPInformation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public NTPInformation NTPInformation { get; set; }
    }

    public class NTPInformation
    {
        [XmlElement("FromDHCP", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool FromDHCP { get; set; }

        [XmlElement("NTPFromDHCP", Namespace = "http://www.onvif.org/ver10/schema")]
        public NetworkHost[] NTPFromDHCP { get; set; }

        [XmlElement("NTPManual", Namespace = "http://www.onvif.org/ver10/schema")]
        public NetworkHost[] NTPManual { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class NetworkHost
    {
        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/schema")]
        public NetworkHostType Type { get; set; }

        [XmlElement("IPv4Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public string IPv4Address { get; set; }

        [XmlElement("IPv6Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public string IPv6Address { get; set; }

        [XmlElement("DNSname", Namespace = "http://www.onvif.org/ver10/schema")]
        public string DNSname { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum NetworkHostType
    {
        IPv4,
        IPv6,
        DNS,
    }

    [XmlRoot("GetDynamicDNS", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDynamicDNSRequest
    {
    }

    [XmlRoot("GetDynamicDNSResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDynamicDNSResponse
    {
        [XmlElement("DynamicDNSInformation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DynamicDNSInformation DynamicDNSInformation { get; set; }
    }

    public class DynamicDNSInformation
    {
        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/schema")]
        public DynamicDNSType Type { get; set; }

        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name { get; set; }

        [XmlElement("TTL", Namespace = "http://www.onvif.org/ver10/schema")]
        public string TTL { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum DynamicDNSType
    {
        NoUpdate,
        ClientUpdates,
        ServerUpdates,
    }

    [XmlRoot("GetNetworkProtocols", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetNetworkProtocolsRequest
    {
    }

    [XmlRoot("GetNetworkProtocolsResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetNetworkProtocolsResponse
    {
        [XmlElement("NetworkProtocols", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public NetworkProtocol[] NetworkProtocols { get; set; }
    }

    public class NetworkProtocol
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/schema")]
        public NetworkProtocolType Name { get; set; }

        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool Enabled { get; set; }

        [XmlElement("Port", Namespace = "http://www.onvif.org/ver10/schema")]
        public int[] Port { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum NetworkProtocolType
    {
        HTTP,
        HTTPS,
        RTSP,
    }

    [XmlRoot("GetNetworkDefaultGateway", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetNetworkDefaultGatewayRequest
    {
    }

    [XmlRoot("GetNetworkDefaultGatewayResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetNetworkDefaultGatewayResponse
    {
        [XmlElement("NetworkGateway", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public NetworkGateway NetworkGateway { get; set; }
    }

    public class NetworkGateway
    {
        [XmlElement("IPv4Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] IPv4Address { get; set; }

        [XmlElement("IPv6Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] IPv6Address { get; set; }
    }

    [XmlRoot("GetZeroConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetZeroConfigurationRequest
    {
    }

    [XmlRoot("GetZeroConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetZeroConfigurationResponse
    {
        [XmlElement("ZeroConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public NetworkZeroConfiguration ZeroConfiguration { get; set; }
    }

    public class NetworkZeroConfiguration
    {
        [XmlElement("InterfaceToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public string InterfaceToken { get; set; }

        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool Enabled { get; set; }

        [XmlElement("Addresses", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] Addresses { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetIPAddressFilter", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetIPAddressFilterRequest
    {
    }

    [XmlRoot("GetIPAddressFilterResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetIPAddressFilterResponse
    {
        [XmlElement("IPAddressFilter", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public IPAddressFilter IPAddressFilter { get; set; }
    }

    public class IPAddressFilter
    {
        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/schema")]
        public IPAddressFilterType Type { get; set; }

        [XmlElement("IPv4Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public PrefixedIPv4Address[] IPv4Address { get; set; }

        [XmlElement("IPv6Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public PrefixedIPv6Address[] IPv6Address { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum IPAddressFilterType
    {
        Allow,
        Deny,
    }

    public class PrefixedIPv4Address
    {
        [XmlElement("Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Address { get; set; }

        [XmlElement("PrefixLength", Namespace = "http://www.onvif.org/ver10/schema")]
        public int PrefixLength { get; set; }
    }

    public class PrefixedIPv6Address
    {
        [XmlElement("Address", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Address { get; set; }

        [XmlElement("PrefixLength", Namespace = "http://www.onvif.org/ver10/schema")]
        public int PrefixLength { get; set; }
    }

    [XmlRoot("GetRemoteUser", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetRemoteUserRequest
    {
    }

    [XmlRoot("GetRemoteUserResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetRemoteUserResponse
    {
        [XmlElement("RemoteUser", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public RemoteUser RemoteUser { get; set; }
    }

    public class RemoteUser
    {
        [XmlElement("Username", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Username { get; set; }

        [XmlElement("Password", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Password { get; set; }

        [XmlElement("UseDerivedPassword", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool UseDerivedPassword { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetNetworkInterfaces", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetNetworkInterfacesRequest
    {
    }

    [XmlRoot("GetNetworkInterfacesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetNetworkInterfacesResponse
    {
        [XmlElement("NetworkInterfaces", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public NetworkInterface[] NetworkInterfaces { get; set; }
    }

    public class NetworkInterface
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetAccessPolicy", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetAccessPolicyRequest
    {
    }

    [XmlRoot("GetAccessPolicyResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetAccessPolicyResponse
    {
        [XmlElement("PolicyFile", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public BinaryData PolicyFile { get; set; }
    }

    public class BinaryData
    {
        [XmlElement("Include", Namespace = "http://www.w3.org/2004/08/xop/include")]
        public XmlElement Include { get; set; }

        [XmlElement("Data", Namespace = "http://www.onvif.org/ver10/schema")]
        public byte[] Data { get; set; }

        [XmlAttribute(AttributeName = "contentType", Namespace = "http://www.w3.org/2005/05/xmlmime")]
        public string ContentType { get; set; }
    }

    [XmlRoot("GetRelayOutputs", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetRelayOutputsRequest
    {
    }

    [XmlRoot("GetRelayOutputsResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetRelayOutputsResponse
    {
        [XmlElement("RelayOutputs", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public RelayOutput[] RelayOutputs { get; set; }
    }

    public class RelayOutput
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetDot11Capabilities", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDot11CapabilitiesRequest
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("GetDot11CapabilitiesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDot11CapabilitiesResponse
    {
        [XmlElement("Capabilities", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Dot11Capabilities Capabilities { get; set; }
    }

    public class Dot11Capabilities
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetDot11Status", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDot11StatusRequest
    {
        [XmlElement("InterfaceToken", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string InterfaceToken { get; set; }
    }

    [XmlRoot("GetDot11StatusResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDot11StatusResponse
    {
        [XmlElement("Status", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Dot11Status Status { get; set; }
    }

    public class Dot11Status
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetSystemUris", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetSystemUrisRequest
    {
    }

    [XmlRoot("GetSystemUrisResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetSystemUrisResponse
    {
        [XmlElement("SystemLogUris", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public SystemLogUriList SystemLogUris { get; set; }

        [XmlElement("SupportInfoUri", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string SupportInfoUri { get; set; }

        [XmlElement("SystemBackupUri", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string SystemBackupUri { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public SystemUrisExtension Extension { get; set; }
    }

    public class SystemUrisExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class SystemLogUriList
    {
        [XmlElement("SystemLog", Namespace = "http://www.onvif.org/ver10/schema")]
        public SystemLogUri[] SystemLog { get; set; }
    }

    public class SystemLogUri
    {
        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/schema")]
        public SystemLogType Type { get; set; }

        [XmlElement("Uri", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Uri { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetStorageConfigurations", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetStorageConfigurationsRequest
    {
    }

    [XmlRoot("GetStorageConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetStorageConfigurationsResponse
    {
        [XmlElement("StorageConfigurations", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public StorageConfiguration[] StorageConfigurations { get; set; }
    }

    [XmlRoot("GetStorageConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetStorageConfigurationRequest
    {
        [XmlElement("Token", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Token { get; set; }
    }

    [XmlRoot("GetStorageConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetStorageConfigurationResponse
    {
        [XmlElement("StorageConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public StorageConfiguration StorageConfiguration { get; set; }
    }

    public class StorageConfiguration
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetGeoLocation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetGeoLocationRequest
    {
    }

    [XmlRoot("GetGeoLocationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetGeoLocationResponse
    {
        [XmlElement("Location", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public LocationEntity[] Location { get; set; }
    }

    public class LocationEntity
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetCertificates", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetCertificatesRequest
    {
    }

    [XmlRoot("GetCertificatesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetCertificatesResponse
    {
        [XmlElement("NvtCertificate", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Certificate[] NvtCertificate { get; set; }
    }

    public class Certificate
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetCertificatesStatus", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetCertificatesStatusRequest
    {
    }

    [XmlRoot("GetCertificatesStatusResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetCertificatesStatusResponse
    {
        [XmlElement("CertificateStatus", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public CertificateStatus[] CertificateStatus { get; set; }
    }

    public class CertificateStatus
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetPkcs10Request", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetPkcs10Request
    {
        [XmlElement("CertificateID", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string CertificateID { get; set; }

        [XmlElement("Subject", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Subject { get; set; }

        [XmlElement("Attributes", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public BinaryData Attributes { get; set; }
    }

    [XmlRoot("GetPkcs10RequestResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetPkcs10RequestResponse
    {
        [XmlElement("Pkcs10Request", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public BinaryData Pkcs10Request { get; set; }
    }

    [XmlRoot("GetClientCertificateMode", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetClientCertificateModeRequest
    {
    }

    [XmlRoot("GetClientCertificateModeResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetClientCertificateModeResponse
    {
        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool Enabled { get; set; }
    }

    [XmlRoot("GetCACertificates", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetCACertificatesRequest
    {
    }

    [XmlRoot("GetCACertificatesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetCACertificatesResponse
    {
        [XmlElement("CACertificate", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Certificate[] CACertificate { get; set; }
    }

    [XmlRoot("GetCertificateInformation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetCertificateInformationRequest
    {
        [XmlElement("CertificateID", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string CertificateID { get; set; }
    }

    [XmlRoot("GetCertificateInformationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetCertificateInformationResponse
    {
        [XmlElement("CertificateInformation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public CertificateInformation CertificateInformation { get; set; }
    }

    public class CertificateInformation
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetDot1XConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDot1XConfigurationRequest
    {
        [XmlElement("Dot1XConfigurationToken", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Dot1XConfigurationToken { get; set; }
    }

    [XmlRoot("GetDot1XConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDot1XConfigurationResponse
    {
        [XmlElement("Dot1XConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Dot1XConfiguration Dot1XConfiguration { get; set; }
    }

    [XmlRoot("GetDot1XConfigurations", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDot1XConfigurationsRequest
    {
    }

    [XmlRoot("GetDot1XConfigurationsResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDot1XConfigurationsResponse
    {
        [XmlElement("Dot1XConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Dot1XConfiguration[] Dot1XConfiguration { get; set; }
    }

    public class Dot1XConfiguration
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("GetDeviceInformation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDeviceInformationRequest
    {
    }

    [XmlRoot("GetDeviceInformationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetDeviceInformationResponse
    {
        [XmlElement("Manufacturer", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Manufacturer { get; set; }

        [XmlElement("Model", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Model { get; set; }

        [XmlElement("FirmwareVersion", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string FirmwareVersion { get; set; }

        [XmlElement("SerialNumber", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string SerialNumber { get; set; }

        [XmlElement("HardwareId", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string HardwareId { get; set; }
    }

    [XmlRoot("GetCapabilities", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetCapabilitiesRequest
    {
        [XmlElement("Category", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public CapabilityCategory[] Category { get; set; } = { CapabilityCategory.All };
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum CapabilityCategory
    {
        All,
        Analytics,
        Device,
        Events,
        Imaging,
        Media,
        PTZ,
    }

    [XmlRoot("GetCapabilitiesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class GetCapabilitiesResponse
    {
        [XmlElement(ElementName = "Capabilities", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Capabilities Capabilities { get; set; }
    }

    public class Capabilities
    {
        [XmlElement(ElementName = "Device", Namespace = "http://www.onvif.org/ver10/schema")]
        public DeviceCapabilities Device { get; set; }

        [XmlElement(ElementName = "Media", Namespace = "http://www.onvif.org/ver10/schema")]
        public MediaCapabilities Media { get; set; }

        [XmlElement(ElementName = "PTZ", Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZCapabilities PTZ { get; set; }

        [XmlElement(ElementName = "Events", Namespace = "http://www.onvif.org/ver10/schema")]
        public EventCapabilities Events { get; set; }

        [XmlElement(ElementName = "Imaging", Namespace = "http://www.onvif.org/ver10/schema")]
        public ImagingCapabilities Imaging { get; set; }

        [XmlElement(ElementName = "Analytics", Namespace = "http://www.onvif.org/ver10/schema")]
        public AnalyticsCapabilities Analytics { get; set; }

        [XmlElement(ElementName = "Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public CapabilitiesExtension Extension { get; set; }
    }

    public class DeviceCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlElement("Network", Namespace = "http://www.onvif.org/ver10/schema")]
        public NetworkCapabilities Network { get; set; }

        [XmlElement("System", Namespace = "http://www.onvif.org/ver10/schema")]
        public SystemCapabilities System { get; set; }

        [XmlElement("IO", Namespace = "http://www.onvif.org/ver10/schema")]
        public IOCapabilities IO { get; set; }

        [XmlElement("Security", Namespace = "http://www.onvif.org/ver10/schema")]
        public SecurityCapabilities Security { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public DeviceCapabilitiesExtension Extension { get; set; }
    }

    public class NetworkCapabilities
    {
        [XmlElement("IPFilter", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? IPFilter { get; set; }

        [XmlElement("ZeroConfiguration", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? ZeroConfiguration { get; set; }

        [XmlElement("IPVersion6", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? IPVersion6 { get; set; }

        [XmlElement("DynDNS", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? DynDNS { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public NetworkCapabilitiesExtension Extension { get; set; }
    }

    public class NetworkCapabilitiesExtension
    {
        [XmlElement("Dot11Configuration", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? Dot11Configuration { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public NetworkCapabilitiesExtension2 Extension { get; set; }
    }

    public class NetworkCapabilitiesExtension2
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class SystemCapabilities
    {
        [XmlElement("DiscoveryResolve", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? DiscoveryResolve { get; set; }

        [XmlElement("DiscoveryBye", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? DiscoveryBye { get; set; }

        [XmlElement("RemoteDiscovery", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? RemoteDiscovery { get; set; }

        [XmlElement("SystemBackup", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? SystemBackup { get; set; }

        [XmlElement("SystemLogging", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? SystemLogging { get; set; }

        [XmlElement("FirmwareUpgrade", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? FirmwareUpgrade { get; set; }

        [XmlElement("SupportedVersions", Namespace = "http://www.onvif.org/ver10/schema")]
        public OnvifVersion[] SupportedVersions { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public SystemCapabilitiesExtension Extension { get; set; }
    }

    public class SystemCapabilitiesExtension
    {
        [XmlElement("HttpFirmwareUpgrade", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? HttpFirmwareUpgrade { get; set; }

        [XmlElement("HttpSystemBackup", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? HttpSystemBackup { get; set; }

        [XmlElement("HttpSystemLogging", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? HttpSystemLogging { get; set; }

        [XmlElement("HttpSupportInformation", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? HttpSupportInformation { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public SystemCapabilitiesExtension2 Extension { get; set; }
    }

    public class SystemCapabilitiesExtension2
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class IOCapabilities
    {
        [XmlElement("InputConnectors", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? InputConnectors { get; set; }

        [XmlElement("RelayOutputs", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? RelayOutputs { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public IOCapabilitiesExtension Extension { get; set; }
    }

    public class IOCapabilitiesExtension
    {
        [XmlElement("Auxiliary", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? Auxiliary { get; set; }

        [XmlElement("AuxiliaryCommands", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] AuxiliaryCommands { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public IOCapabilitiesExtension2 Extension { get; set; }
    }

    public class IOCapabilitiesExtension2
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class SecurityCapabilities
    {
        [XmlElement("TLS1.1", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? TLS11 { get; set; }

        [XmlElement("TLS1.2", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? TLS12 { get; set; }

        [XmlElement("OnboardKeyGeneration", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? OnboardKeyGeneration { get; set; }

        [XmlElement("AccessPolicyConfig", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? AccessPolicyConfig { get; set; }

        [XmlElement("X.509Token", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? X509Token { get; set; }

        [XmlElement("SAMLToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? SAMLToken { get; set; }

        [XmlElement("KerberosToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? KerberosToken { get; set; }

        [XmlElement("RELToken", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? RELToken { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public SecurityCapabilitiesExtension Extension { get; set; }
    }

    public class SecurityCapabilitiesExtension
    {
        [XmlElement("TLS1.0", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? TLS10 { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public SecurityCapabilitiesExtension2 Extension { get; set; }
    }

    public class SecurityCapabilitiesExtension2
    {
        [XmlElement("Dot1X", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? Dot1X { get; set; }

        [XmlElement("SupportedEAPMethod", Namespace = "http://www.onvif.org/ver10/schema")]
        public int[] SupportedEAPMethod { get; set; }

        [XmlElement("RemoteUserHandling", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? RemoteUserHandling { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class DeviceCapabilitiesExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class OnvifVersion
    {
        [XmlElement("Major", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Major { get; set; }

        [XmlElement("Minor", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Minor { get; set; }
    }

    public class MediaCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlElement("StreamingCapabilities", Namespace = "http://www.onvif.org/ver10/schema")]
        public StreamingCapabilities StreamingCapabilities { get; set; }

        [XmlElement("ProfileCapabilities", Namespace = "http://www.onvif.org/ver10/schema")]
        public ProfileCapabilities ProfileCapabilities { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public MediaExtension Extension { get; set; }
    }

    public class StreamingCapabilities
    {
        [XmlElement("RTPMulticast", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? RTPMulticast { get; set; }

        [XmlElement("RTP_TCP", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? RTP_TCP { get; set; }

        [XmlElement("RTP_RTSP_TCP", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? RTP_RTSP_TCP { get; set; }

        [XmlElement("NonAggregateControl", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? NonAggregateControl { get; set; }

        [XmlElement("NoRTSPStreaming", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? NoRTSPStreaming { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public StreamingCapabilitiesExtension Extension { get; set; }
    }

    public class StreamingCapabilitiesExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class MediaExtension
    {
        [XmlElement("ProfileCapabilities", Namespace = "http://www.onvif.org/ver10/schema")]
        public ProfileCapabilities ProfileCapabilities { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class ProfileCapabilities
    {
        [XmlElement("MaximumNumberOfProfiles", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? MaximumNumberOfProfiles { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class MediaStreamingCapabilities
    {
        public bool RTPMulticast { get; set; }
        public bool RTP_TCP { get; set; }
        public bool RTP_RTSP_TCP { get; set; }
    }

    public class PTZCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class EventCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlElement("WSSubscriptionPolicySupport", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? WSSubscriptionPolicySupport { get; set; }

        [XmlElement("WSPullPointSupport", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? WSPullPointSupport { get; set; }

        [XmlElement("WSPausableSubscriptionManagerInterfaceSupport", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? WSPausableSubscriptionManagerInterfaceSupport { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class ImagingCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }
    }

    public class AnalyticsCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlElement("RuleSupport", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? RuleSupport { get; set; }

        [XmlElement("AnalyticsModuleSupport", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? AnalyticsModuleSupport { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class CapabilitiesExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement(ElementName = "DeviceIO", Namespace = "http://www.onvif.org/ver10/schema")]
        public DeviceIOCapabilities DeviceIO { get; set; }

        [XmlElement(ElementName = "Display", Namespace = "http://www.onvif.org/ver10/schema")]
        public DisplayCapabilities Display { get; set; }

        [XmlElement(ElementName = "Recording", Namespace = "http://www.onvif.org/ver10/schema")]
        public RecordingCapabilities Recording { get; set; }

        [XmlElement(ElementName = "Search", Namespace = "http://www.onvif.org/ver10/schema")]
        public SearchCapabilities Search { get; set; }

        [XmlElement(ElementName = "Replay", Namespace = "http://www.onvif.org/ver10/schema")]
        public ReplayCapabilities Replay { get; set; }

        [XmlElement(ElementName = "Receiver", Namespace = "http://www.onvif.org/ver10/schema")]
        public ReceiverCapabilities Receiver { get; set; }

        [XmlElement(ElementName = "AnalyticsDevice", Namespace = "http://www.onvif.org/ver10/schema")]
        public AnalyticsDeviceCapabilities AnalyticsDevice { get; set; }

        [XmlElement(ElementName = "Extensions", Namespace = "http://www.onvif.org/ver10/schema")]
        public CapabilitiesExtension2 Extensions { get; set; }
    }

    public class DeviceIOCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlElement("VideoSources", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? VideoSources { get; set; }

        [XmlElement("VideoOutputs", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? VideoOutputs { get; set; }

        [XmlElement("AudioSources", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? AudioSources { get; set; }

        [XmlElement("AudioOutputs", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? AudioOutputs { get; set; }

        [XmlElement("RelayOutputs", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? RelayOutputs { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class DisplayCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlElement("FixedLayout", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? FixedLayout { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class RecordingCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlElement("ReceiverSource", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? ReceiverSource { get; set; }

        [XmlElement("MediaProfileSource", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? MediaProfileSource { get; set; }

        [XmlElement("DynamicRecordings", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? DynamicRecordings { get; set; }

        [XmlElement("DynamicTracks", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? DynamicTracks { get; set; }

        [XmlElement("MaxStringLength", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? MaxStringLength { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class SearchCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlElement("MetadataSearch", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? MetadataSearch { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class ReplayCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class ReceiverCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlElement("RTP_Multicast", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? RTP_Multicast { get; set; }

        [XmlElement("RTP_TCP", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? RTP_TCP { get; set; }

        [XmlElement("RTP_RTSP_TCP", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? RTP_RTSP_TCP { get; set; }

        [XmlElement("SupportedReceivers", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? SupportedReceivers { get; set; }

        [XmlElement("MaximumRTSPURILength", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? MaximumRTSPURILength { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class AnalyticsDeviceCapabilities
    {
        [XmlElement("XAddr", Namespace = "http://www.onvif.org/ver10/schema")]
        public string XAddr { get; set; }

        [XmlElement("RuleSupport", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? RuleSupport { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public AnalyticsDeviceExtension Extension { get; set; }
    }

    public class AnalyticsDeviceExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class CapabilitiesExtension2
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
[XmlRoot("AddIPAddressFilter", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class AddIPAddressFilterRequest
    {
        [XmlElement("IPAddressFilter", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public IPAddressFilter IPAddressFilter { get; set; }

    }

    [XmlRoot("AddIPAddressFilterResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class AddIPAddressFilterResponse
    {
    }

    [XmlRoot("AddScopes", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class AddScopesRequest
    {
        [XmlElement("ScopeItem", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string[] ScopeItem { get; set; }

    }

    [XmlRoot("AddScopesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class AddScopesResponse
    {
    }

    [XmlRoot("CreateCertificate", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class CreateCertificateRequest
    {
        [XmlElement("CertificateID", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string CertificateID { get; set; }

        [XmlElement("Subject", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Subject { get; set; }

        [XmlElement("ValidNotBefore", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DateTime? ValidNotBefore { get; set; }

        [XmlElement("ValidNotAfter", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DateTime? ValidNotAfter { get; set; }

    }

    [XmlRoot("CreateCertificateResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class CreateCertificateResponse
    {
        [XmlElement("NvtCertificate", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Certificate NvtCertificate { get; set; }

    }

    [XmlRoot("CreateDot1XConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class CreateDot1XConfigurationRequest
    {
        [XmlElement("Dot1XConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Dot1XConfiguration Dot1XConfiguration { get; set; }

    }

    [XmlRoot("CreateDot1XConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class CreateDot1XConfigurationResponse
    {
    }

    [XmlRoot("CreateStorageConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class CreateStorageConfigurationRequest
    {
        [XmlElement("StorageConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public StorageConfiguration StorageConfiguration { get; set; }

    }

    [XmlRoot("CreateStorageConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class CreateStorageConfigurationResponse
    {
        [XmlElement("Token", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Token { get; set; }

    }

    [XmlRoot("CreateUsers", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class CreateUsersRequest
    {
        [XmlElement("User", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public OnvifUser[] User { get; set; }

    }

    [XmlRoot("CreateUsersResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class CreateUsersResponse
    {
    }

    [XmlRoot("DeleteCertificates", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteCertificatesRequest
    {
        [XmlElement("CertificateID", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string[] CertificateID { get; set; }

    }

    [XmlRoot("DeleteCertificatesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteCertificatesResponse
    {
    }

    [XmlRoot("DeleteDot1XConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteDot1XConfigurationRequest
    {
        [XmlElement("Dot1XConfigurationToken", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string[] Dot1XConfigurationToken { get; set; }

    }

    [XmlRoot("DeleteDot1XConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteDot1XConfigurationResponse
    {
    }

    [XmlRoot("DeleteGeoLocation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteGeoLocationRequest
    {
        [XmlElement("Location", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public LocationEntity[] Location { get; set; }

    }

    [XmlRoot("DeleteGeoLocationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteGeoLocationResponse
    {
    }

    [XmlRoot("DeleteStorageConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteStorageConfigurationRequest
    {
        [XmlElement("Token", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Token { get; set; }

    }

    [XmlRoot("DeleteStorageConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteStorageConfigurationResponse
    {
    }

    [XmlRoot("DeleteUserRole", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteUserRoleRequest
    {
        [XmlElement("UserRole", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string UserRole { get; set; }

    }

    [XmlRoot("DeleteUserRoleResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteUserRoleResponse
    {
    }

    [XmlRoot("DeleteUsers", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteUsersRequest
    {
        [XmlElement("Username", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string[] Username { get; set; }

    }

    [XmlRoot("DeleteUsersResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class DeleteUsersResponse
    {
    }

    [XmlRoot("LoadCACertificates", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class LoadCACertificatesRequest
    {
        [XmlElement("CACertificate", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Certificate[] CACertificate { get; set; }

    }

    [XmlRoot("LoadCACertificatesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class LoadCACertificatesResponse
    {
    }

    [XmlRoot("LoadCertificates", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class LoadCertificatesRequest
    {
        [XmlElement("NVTCertificate", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Certificate[] NVTCertificate { get; set; }

    }

    [XmlRoot("LoadCertificatesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class LoadCertificatesResponse
    {
    }

    [XmlRoot("LoadCertificateWithPrivateKey", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class LoadCertificateWithPrivateKeyRequest
    {
        [XmlElement("CertificateWithPrivateKey", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public CertificateWithPrivateKey[] CertificateWithPrivateKey { get; set; }

    }

    [XmlRoot("LoadCertificateWithPrivateKeyResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class LoadCertificateWithPrivateKeyResponse
    {
    }

    [XmlRoot("RemoveIPAddressFilter", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class RemoveIPAddressFilterRequest
    {
        [XmlElement("IPAddressFilter", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public IPAddressFilter IPAddressFilter { get; set; }

    }

    [XmlRoot("RemoveIPAddressFilterResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class RemoveIPAddressFilterResponse
    {
    }

    [XmlRoot("RemoveScopes", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class RemoveScopesRequest
    {
        [XmlElement("ScopeItem", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string[] ScopeItem { get; set; }

    }

    [XmlRoot("RemoveScopesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class RemoveScopesResponse
    {
        [XmlElement("ScopeItem", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string[] ScopeItem { get; set; }

    }

    [XmlRoot("RestoreSystem", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class RestoreSystemRequest
    {
        [XmlElement("BackupFiles", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public BackupFile[] BackupFiles { get; set; }

    }

    [XmlRoot("RestoreSystemResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class RestoreSystemResponse
    {
    }

    [XmlRoot("ScanAvailableDot11Networks", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class ScanAvailableDot11NetworksRequest
    {
        [XmlElement("InterfaceToken", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string InterfaceToken { get; set; }

    }

    [XmlRoot("ScanAvailableDot11NetworksResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class ScanAvailableDot11NetworksResponse
    {
        [XmlElement("Networks", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Dot11AvailableNetworks[] Networks { get; set; }

    }

    [XmlRoot("SendAuxiliaryCommand", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SendAuxiliaryCommandRequest
    {
        [XmlElement("AuxiliaryCommand", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string AuxiliaryCommand { get; set; }

    }

    [XmlRoot("SendAuxiliaryCommandResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SendAuxiliaryCommandResponse
    {
        [XmlElement("AuxiliaryCommandResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string AuxiliaryCommandResponse { get; set; }

    }

    [XmlRoot("SetAccessPolicy", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetAccessPolicyRequest
    {
        [XmlElement("PolicyFile", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public BinaryData PolicyFile { get; set; }

    }

    [XmlRoot("SetAccessPolicyResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetAccessPolicyResponse
    {
    }

    [XmlRoot("SetAuthFailureWarningConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetAuthFailureWarningConfigurationRequest
    {
        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool Enabled { get; set; }

        [XmlElement("MonitorPeriod", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int MonitorPeriod { get; set; }

        [XmlElement("MaxAuthFailures", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int MaxAuthFailures { get; set; }

    }

    [XmlRoot("SetAuthFailureWarningConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetAuthFailureWarningConfigurationResponse
    {
    }

    [XmlRoot("SetCertificatesStatus", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetCertificatesStatusRequest
    {
        [XmlElement("CertificateStatus", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public CertificateStatus[] CertificateStatus { get; set; }

    }

    [XmlRoot("SetCertificatesStatusResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetCertificatesStatusResponse
    {
    }

    [XmlRoot("SetClientCertificateMode", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetClientCertificateModeRequest
    {
        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool Enabled { get; set; }

    }

    [XmlRoot("SetClientCertificateModeResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetClientCertificateModeResponse
    {
    }

    [XmlRoot("SetDiscoveryMode", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetDiscoveryModeRequest
    {
        [XmlElement("DiscoveryMode", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DiscoveryMode DiscoveryMode { get; set; }

    }

    [XmlRoot("SetDiscoveryModeResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetDiscoveryModeResponse
    {
    }

    [XmlRoot("SetDNS", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetDNSRequest
    {
        [XmlElement("FromDHCP", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool FromDHCP { get; set; }

        [XmlElement("SearchDomain", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string[] SearchDomain { get; set; }

        [XmlElement("DNSManual", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public IPAddress[] DNSManual { get; set; }

    }

    [XmlRoot("SetDNSResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetDNSResponse
    {
    }

    [XmlRoot("SetDot1XConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetDot1XConfigurationRequest
    {
        [XmlElement("Dot1XConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public Dot1XConfiguration Dot1XConfiguration { get; set; }

    }

    [XmlRoot("SetDot1XConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetDot1XConfigurationResponse
    {
    }

    [XmlRoot("SetDPAddresses", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetDPAddressesRequest
    {
        [XmlElement("DPAddress", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public NetworkHost[] DPAddress { get; set; }

    }

    [XmlRoot("SetDPAddressesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetDPAddressesResponse
    {
    }

    [XmlRoot("SetDynamicDNS", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetDynamicDNSRequest
    {
        [XmlElement("Type", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DynamicDNSType Type { get; set; }

        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Name { get; set; }

        [XmlElement("TTL", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string TTL { get; set; }

    }

    [XmlRoot("SetDynamicDNSResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetDynamicDNSResponse
    {
    }

    [XmlRoot("SetGeoLocation", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetGeoLocationRequest
    {
        [XmlElement("Location", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public LocationEntity[] Location { get; set; }

    }

    [XmlRoot("SetGeoLocationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetGeoLocationResponse
    {
    }

    [XmlRoot("SetHashingAlgorithm", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetHashingAlgorithmRequest
    {
        [XmlElement("Algorithm", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Algorithm { get; set; }

    }

    [XmlRoot("SetHashingAlgorithmResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetHashingAlgorithmResponse
    {
    }

    [XmlRoot("SetHostname", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetHostnameRequest
    {
        [XmlElement("Name", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Name { get; set; }

    }

    [XmlRoot("SetHostnameResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetHostnameResponse
    {
    }

    [XmlRoot("SetHostnameFromDHCP", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetHostnameFromDHCPRequest
    {
        [XmlElement("FromDHCP", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool FromDHCP { get; set; }

    }

    [XmlRoot("SetHostnameFromDHCPResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetHostnameFromDHCPResponse
    {
        [XmlElement("RebootNeeded", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool RebootNeeded { get; set; }

    }

    [XmlRoot("SetIPAddressFilter", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetIPAddressFilterRequest
    {
        [XmlElement("IPAddressFilter", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public IPAddressFilter IPAddressFilter { get; set; }

    }

    [XmlRoot("SetIPAddressFilterResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetIPAddressFilterResponse
    {
    }

    [XmlRoot("SetNetworkDefaultGateway", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetNetworkDefaultGatewayRequest
    {
        [XmlElement("IPv4Address", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string[] IPv4Address { get; set; }

        [XmlElement("IPv6Address", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string[] IPv6Address { get; set; }

    }

    [XmlRoot("SetNetworkDefaultGatewayResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetNetworkDefaultGatewayResponse
    {
    }

    [XmlRoot("SetNetworkInterfaces", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetNetworkInterfacesRequest
    {
        [XmlElement("InterfaceToken", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string InterfaceToken { get; set; }

        [XmlElement("NetworkInterface", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public NetworkInterfaceSetConfiguration NetworkInterface { get; set; }

    }

    [XmlRoot("SetNetworkInterfacesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetNetworkInterfacesResponse
    {
        [XmlElement("RebootNeeded", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool RebootNeeded { get; set; }

    }

    [XmlRoot("SetNetworkProtocols", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetNetworkProtocolsRequest
    {
        [XmlElement("NetworkProtocols", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public NetworkProtocol[] NetworkProtocols { get; set; }

    }

    [XmlRoot("SetNetworkProtocolsResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetNetworkProtocolsResponse
    {
    }

    [XmlRoot("SetNTP", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetNTPRequest
    {
        [XmlElement("FromDHCP", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool FromDHCP { get; set; }

        [XmlElement("NTPManual", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public NetworkHost[] NTPManual { get; set; }

    }

    [XmlRoot("SetNTPResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetNTPResponse
    {
    }

    [XmlRoot("SetPasswordComplexityConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetPasswordComplexityConfigurationRequest
    {
        [XmlElement("MinLen", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int? MinLen { get; set; }

        [XmlElement("Uppercase", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int? Uppercase { get; set; }

        [XmlElement("Number", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int? Number { get; set; }

        [XmlElement("SpecialChars", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int? SpecialChars { get; set; }

        [XmlElement("BlockUsernameOccurrence", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool? BlockUsernameOccurrence { get; set; }

        [XmlElement("PolicyConfigurationLocked", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool? PolicyConfigurationLocked { get; set; }

    }

    [XmlRoot("SetPasswordComplexityConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetPasswordComplexityConfigurationResponse
    {
    }

    [XmlRoot("SetPasswordHistoryConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetPasswordHistoryConfigurationRequest
    {
        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool Enabled { get; set; }

        [XmlElement("Length", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public int Length { get; set; }

    }

    [XmlRoot("SetPasswordHistoryConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetPasswordHistoryConfigurationResponse
    {
    }

    [XmlRoot("SetRelayOutputSettings", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetRelayOutputSettingsRequest
    {
        [XmlElement("RelayOutputToken", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string RelayOutputToken { get; set; }

        [XmlElement("Properties", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public RelayOutputSettings Properties { get; set; }

    }

    [XmlRoot("SetRelayOutputSettingsResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetRelayOutputSettingsResponse
    {
    }

    [XmlRoot("SetRelayOutputState", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetRelayOutputStateRequest
    {
        [XmlElement("RelayOutputToken", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string RelayOutputToken { get; set; }

        [XmlElement("LogicalState", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string LogicalState { get; set; }

    }

    [XmlRoot("SetRelayOutputStateResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetRelayOutputStateResponse
    {
    }

    [XmlRoot("SetRemoteDiscoveryMode", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetRemoteDiscoveryModeRequest
    {
        [XmlElement("RemoteDiscoveryMode", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DiscoveryMode RemoteDiscoveryMode { get; set; }

    }

    [XmlRoot("SetRemoteDiscoveryModeResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetRemoteDiscoveryModeResponse
    {
    }

    [XmlRoot("SetRemoteUser", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetRemoteUserRequest
    {
        [XmlElement("RemoteUser", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public RemoteUser RemoteUser { get; set; }

    }

    [XmlRoot("SetRemoteUserResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetRemoteUserResponse
    {
    }

    [XmlRoot("SetScopes", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetScopesRequest
    {
        [XmlElement("Scopes", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string[] Scopes { get; set; }

    }

    [XmlRoot("SetScopesResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetScopesResponse
    {
    }

    [XmlRoot("SetStorageConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetStorageConfigurationRequest
    {
        [XmlElement("StorageConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public StorageConfiguration StorageConfiguration { get; set; }

    }

    [XmlRoot("SetStorageConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetStorageConfigurationResponse
    {
    }

    [XmlRoot("SetSystemDateAndTime", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetSystemDateAndTimeRequest
    {
        [XmlElement("DateTimeType", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public SetDateTimeType DateTimeType { get; set; }

        [XmlElement("DaylightSavings", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool DaylightSavings { get; set; }

        [XmlElement("TimeZone", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DeviceTimeZone TimeZone { get; set; }

        [XmlElement("UTCDateTime", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public DeviceDateTime UTCDateTime { get; set; }

    }

    [XmlRoot("SetSystemDateAndTimeResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetSystemDateAndTimeResponse
    {
    }

    [XmlRoot("SetSystemFactoryDefault", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetSystemFactoryDefaultRequest
    {
        [XmlElement("FactoryDefault", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string FactoryDefault { get; set; }

    }

    [XmlRoot("SetSystemFactoryDefaultResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetSystemFactoryDefaultResponse
    {
    }

    [XmlRoot("SetUser", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetUserRequest
    {
        [XmlElement("User", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public OnvifUser[] User { get; set; }

    }

    [XmlRoot("SetUserResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetUserResponse
    {
    }

    [XmlRoot("SetUserRole", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetUserRoleRequest
    {
        [XmlElement("UserRole", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public UserRole UserRole { get; set; }

    }

    [XmlRoot("SetUserRoleResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetUserRoleResponse
    {
    }

    [XmlRoot("SetZeroConfiguration", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetZeroConfigurationRequest
    {
        [XmlElement("InterfaceToken", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string InterfaceToken { get; set; }

        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public bool Enabled { get; set; }

    }

    [XmlRoot("SetZeroConfigurationResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SetZeroConfigurationResponse
    {
    }

    [XmlRoot("StartFirmwareUpgrade", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class StartFirmwareUpgradeRequest
    {
    }

    [XmlRoot("StartFirmwareUpgradeResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class StartFirmwareUpgradeResponse
    {
        [XmlElement("UploadUri", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string UploadUri { get; set; }

        [XmlElement("UploadDelay", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string UploadDelay { get; set; }

        [XmlElement("ExpectedDownTime", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string ExpectedDownTime { get; set; }

    }

    [XmlRoot("StartSystemRestore", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class StartSystemRestoreRequest
    {
    }

    [XmlRoot("StartSystemRestoreResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class StartSystemRestoreResponse
    {
        [XmlElement("UploadUri", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string UploadUri { get; set; }

        [XmlElement("ExpectedDownTime", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string ExpectedDownTime { get; set; }

    }

    [XmlRoot("SystemReboot", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SystemRebootRequest
    {
    }

    [XmlRoot("SystemRebootResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class SystemRebootResponse
    {
        [XmlElement("Message", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Message { get; set; }

    }

    [XmlRoot("UpgradeFirmware", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class UpgradeFirmwareRequest
    {
        [XmlElement("Version", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Version { get; set; }

    }

    [XmlRoot("UpgradeFirmwareResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class UpgradeFirmwareResponse
    {
        [XmlElement("ExpectedDownTime", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string ExpectedDownTime { get; set; }

    }

    [XmlRoot("UpgradeSystemFirmware", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class UpgradeSystemFirmwareRequest
    {
        [XmlElement("Firmware", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public AttachmentData Firmware { get; set; }

    }

    [XmlRoot("UpgradeSystemFirmwareResponse", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public class UpgradeSystemFirmwareResponse
    {
        [XmlElement("Message", Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public string Message { get; set; }

    }


    public class CertificateWithPrivateKey
    {
        [XmlElement("CertificateID", Namespace = "http://www.onvif.org/ver10/schema")]
        public string CertificateID { get; set; }

        [XmlElement("Certificate", Namespace = "http://www.onvif.org/ver10/schema")]
        public BinaryData Certificate { get; set; }

        [XmlElement("PrivateKey", Namespace = "http://www.onvif.org/ver10/schema")]
        public BinaryData PrivateKey { get; set; }
    }

    public class Dot11AvailableNetworks
    {
        [XmlElement("SSID", Namespace = "http://www.onvif.org/ver10/schema")]
        public string SSID { get; set; }

        [XmlElement("BSSID", Namespace = "http://www.onvif.org/ver10/schema")]
        public string BSSID { get; set; }

        [XmlElement("AuthAndMangementSuite", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] AuthAndMangementSuite { get; set; }

        [XmlElement("PairCipher", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] PairCipher { get; set; }

        [XmlElement("GroupCipher", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] GroupCipher { get; set; }

        [XmlElement("SignalStrength", Namespace = "http://www.onvif.org/ver10/schema")]
        public string SignalStrength { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public Dot11AvailableNetworksExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class Dot11AvailableNetworksExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class NetworkInterfaceSetConfiguration
    {
        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? Enabled { get; set; }

        [XmlElement("Link", Namespace = "http://www.onvif.org/ver10/schema")]
        public NetworkInterfaceConnectionSetting Link { get; set; }

        [XmlElement("MTU", Namespace = "http://www.onvif.org/ver10/schema")]
        public int? MTU { get; set; }

        [XmlElement("IPv4", Namespace = "http://www.onvif.org/ver10/schema")]
        public IPv4NetworkInterfaceSetConfiguration IPv4 { get; set; }

        [XmlElement("IPv6", Namespace = "http://www.onvif.org/ver10/schema")]
        public IPv6NetworkInterfaceSetConfiguration IPv6 { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public NetworkInterfaceSetConfigurationExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class NetworkInterfaceConnectionSetting
    {
        [XmlElement("AutoNegotiation", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool AutoNegotiation { get; set; }

        [XmlElement("Speed", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Speed { get; set; }

        [XmlElement("Duplex", Namespace = "http://www.onvif.org/ver10/schema")]
        public Duplex Duplex { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum Duplex
    {
        Full,
        Half,
    }

    public class IPv4NetworkInterfaceSetConfiguration
    {
        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? Enabled { get; set; }

        [XmlElement("Manual", Namespace = "http://www.onvif.org/ver10/schema")]
        public PrefixedIPv4Address[] Manual { get; set; }

        [XmlElement("DHCP", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? DHCP { get; set; }
    }

    public class IPv6NetworkInterfaceSetConfiguration
    {
        [XmlElement("Enabled", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? Enabled { get; set; }

        [XmlElement("AcceptRouterAdvert", Namespace = "http://www.onvif.org/ver10/schema")]
        public bool? AcceptRouterAdvert { get; set; }

        [XmlElement("Manual", Namespace = "http://www.onvif.org/ver10/schema")]
        public PrefixedIPv6Address[] Manual { get; set; }

        [XmlElement("DHCP", Namespace = "http://www.onvif.org/ver10/schema")]
        public string DHCP { get; set; }
    }

    public class NetworkInterfaceSetConfigurationExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlElement("Dot3", Namespace = "http://www.onvif.org/ver10/schema")]
        public Dot3Configuration[] Dot3 { get; set; }

        [XmlElement("Dot11", Namespace = "http://www.onvif.org/ver10/schema")]
        public Dot11Configuration[] Dot11 { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public NetworkInterfaceSetConfigurationExtension2 Extension { get; set; }
    }

    public class NetworkInterfaceSetConfigurationExtension2
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class Dot3Configuration
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class Dot11Configuration
    {
        [XmlElement("SSID", Namespace = "http://www.onvif.org/ver10/schema")]
        public string SSID { get; set; }

        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Mode { get; set; }

        [XmlElement("Alias", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Alias { get; set; }

        [XmlElement("Priority", Namespace = "http://www.onvif.org/ver10/schema")]
        public int Priority { get; set; }

        [XmlElement("Security", Namespace = "http://www.onvif.org/ver10/schema")]
        public Dot11SecurityConfiguration Security { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class Dot11SecurityConfiguration
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Mode { get; set; }

        [XmlElement("Algorithm", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Algorithm { get; set; }

        [XmlElement("PSK", Namespace = "http://www.onvif.org/ver10/schema")]
        public Dot11PSKSet PSK { get; set; }

        [XmlElement("Dot1X", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Dot1X { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public Dot11SecurityConfigurationExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class Dot11SecurityConfigurationExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class Dot11PSKSet
    {
        [XmlElement("Key", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Key { get; set; }

        [XmlElement("Passphrase", Namespace = "http://www.onvif.org/ver10/schema")]
        public string Passphrase { get; set; }

        [XmlElement("Extension", Namespace = "http://www.onvif.org/ver10/schema")]
        public Dot11PSKSetExtension Extension { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    public class Dot11PSKSetExtension
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    public class RelayOutputSettings
    {
        [XmlElement("Mode", Namespace = "http://www.onvif.org/ver10/schema")]
        public RelayMode Mode { get; set; }

        [XmlElement("DelayTime", Namespace = "http://www.onvif.org/ver10/schema")]
        public string DelayTime { get; set; }

        [XmlElement("IdleState", Namespace = "http://www.onvif.org/ver10/schema")]
        public RelayIdleState IdleState { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum RelayMode
    {
        Monostable,
        Bistable,
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/schema")]
    public enum RelayIdleState
    {
        closed,
        open,
    }
}
