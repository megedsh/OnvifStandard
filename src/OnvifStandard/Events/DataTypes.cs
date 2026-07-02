using System;
using System.Xml;
using System.Xml.Serialization;

namespace OnvifStandard.Events
{
    [XmlRoot("GetServiceCapabilities", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class GetServiceCapabilitiesRequest
    {
    }

    [XmlRoot("GetServiceCapabilitiesResponse", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class GetServiceCapabilitiesResponse
    {
        [XmlElement("Capabilities", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public Capabilities Capabilities { get; set; }
    }

    [XmlRoot("Capabilities", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class Capabilities
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAttribute("WSSubscriptionPolicySupport")]
        public bool WSSubscriptionPolicySupport { get; set; }

        [XmlIgnore]
        public bool WSSubscriptionPolicySupportSpecified { get; set; }

        [XmlAttribute("WSPausableSubscriptionManagerInterfaceSupport")]
        public bool WSPausableSubscriptionManagerInterfaceSupport { get; set; }

        [XmlIgnore]
        public bool WSPausableSubscriptionManagerInterfaceSupportSpecified { get; set; }

        [XmlAttribute("MaxNotificationProducers")]
        public int MaxNotificationProducers { get; set; }

        [XmlIgnore]
        public bool MaxNotificationProducersSpecified { get; set; }

        [XmlAttribute("MaxPullPoints")]
        public int MaxPullPoints { get; set; }

        [XmlIgnore]
        public bool MaxPullPointsSpecified { get; set; }

        [XmlAttribute("PersistentNotificationStorage")]
        public bool PersistentNotificationStorage { get; set; }

        [XmlIgnore]
        public bool PersistentNotificationStorageSpecified { get; set; }

        [XmlAttribute("EventBrokerProtocols")]
        public string EventBrokerProtocols { get; set; }

        [XmlAttribute("MaxEventBrokers")]
        public int MaxEventBrokers { get; set; }

        [XmlIgnore]
        public bool MaxEventBrokersSpecified { get; set; }

        [XmlAttribute("MetadataOverMQTT")]
        public bool MetadataOverMQTT { get; set; }

        [XmlIgnore]
        public bool MetadataOverMQTTSpecified { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlRoot("CreatePullPointSubscription", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class CreatePullPointSubscriptionRequest
    {
        [XmlElement("Filter", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public FilterType Filter { get; set; }

        [XmlElement("InitialTerminationTime", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public AbsoluteOrRelativeTimeType InitialTerminationTime { get; set; }

        [XmlElement("SubscriptionPolicy", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public SubscriptionPolicy SubscriptionPolicy { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("CreatePullPointSubscriptionResponse", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class CreatePullPointSubscriptionResponse
    {
        [XmlElement("SubscriptionReference", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public EndpointReferenceType SubscriptionReference { get; set; }

        [XmlElement("CurrentTime", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public DateTime CurrentTime { get; set; }

        [XmlElement("TerminationTime", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public DateTime TerminationTime { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("PullMessages", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class PullMessagesRequest
    {
        [XmlElement("Timeout", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string Timeout { get; set; }

        [XmlElement("MessageLimit", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public int MessageLimit { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("PullMessagesResponse", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class PullMessagesResponse
    {
        [XmlElement("CurrentTime", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public DateTime CurrentTime { get; set; }

        [XmlElement("TerminationTime", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public DateTime TerminationTime { get; set; }

        [XmlElement("NotificationMessage", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public NotificationMessageHolder[] NotificationMessage { get; set; }
    }

    [XmlRoot("PullMessagesFaultResponse", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class PullMessagesFaultResponse
    {
        [XmlElement("MaxTimeout", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string MaxTimeout { get; set; }

        [XmlElement("MaxMessageLimit", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public int MaxMessageLimit { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("Seek", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class SeekRequest
    {
        [XmlElement("UtcTime", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public DateTime UtcTime { get; set; }

        [XmlElement("Reverse", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public bool Reverse { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("SeekResponse", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class SeekResponse
    {
    }

    [XmlRoot("SetSynchronizationPoint", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class SetSynchronizationPointRequest
    {
    }

    [XmlRoot("SetSynchronizationPointResponse", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class SetSynchronizationPointResponse
    {
    }

    [XmlRoot("GetEventProperties", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class GetEventPropertiesRequest
    {
    }

    [XmlRoot("GetEventPropertiesResponse", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class GetEventPropertiesResponse
    {
        [XmlElement("TopicNamespaceLocation", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string[] TopicNamespaceLocation { get; set; }

        [XmlElement("FixedTopicSet", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public bool FixedTopicSet { get; set; }

        [XmlElement("TopicSet", Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public TopicSet TopicSet { get; set; }

        [XmlElement("TopicExpressionDialect", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public string[] TopicExpressionDialect { get; set; }

        [XmlElement("MessageContentFilterDialect", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string[] MessageContentFilterDialect { get; set; }

        [XmlElement("ProducerPropertiesFilterDialect", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string[] ProducerPropertiesFilterDialect { get; set; }

        [XmlElement("MessageContentSchemaLocation", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string[] MessageContentSchemaLocation { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("ChangedOnly", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class ChangedOnly
    {
    }

    [XmlRoot("AddEventBroker", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class AddEventBrokerRequest
    {
        [XmlElement("EventBroker", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public EventBrokerConfig EventBroker { get; set; }
    }

    [XmlRoot("AddEventBrokerResponse", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class AddEventBrokerResponse
    {
    }

    [XmlRoot("DeleteEventBroker", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class DeleteEventBrokerRequest
    {
        [XmlElement("Address", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string Address { get; set; }
    }

    [XmlRoot("DeleteEventBrokerResponse", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class DeleteEventBrokerResponse
    {
    }

    [XmlRoot("GetEventBrokers", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class GetEventBrokersRequest
    {
        [XmlElement("Address", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string Address { get; set; }
    }

    [XmlRoot("GetEventBrokersResponse", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public class GetEventBrokersResponse
    {
        [XmlElement("EventBroker", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public EventBrokerConfig[] EventBroker { get; set; }
    }

    public class EventBrokerConfig
    {
        [XmlElement("Address", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string Address { get; set; }

        [XmlElement("TopicPrefix", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string TopicPrefix { get; set; }

        [XmlElement("UserName", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string UserName { get; set; }

        [XmlElement("Password", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string Password { get; set; }

        [XmlElement("CertificateID", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string CertificateID { get; set; }

        [XmlElement("PublishFilter", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public FilterType PublishFilter { get; set; }

        [XmlElement("QoS", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public int? QoS { get; set; }

        [XmlElement("Status", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string Status { get; set; }

        [XmlElement("CertPathValidationPolicyID", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public string CertPathValidationPolicyID { get; set; }

        [XmlElement("MetadataFilter", Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public FilterType MetadataFilter { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] AnyAttribute { get; set; }
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public enum EventBrokerProtocol
    {
        mqtt,
        mqtts,
        ws,
        wss,
    }

    [XmlType(Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    public enum ConnectionStatus
    {
        Offline,
        Connecting,
        Connected,
    }

    [XmlType(Namespace = "http://docs.oasis-open.org/wsn/b-2")]
    public class FilterType
    {
    }

    [XmlType(Namespace = "http://docs.oasis-open.org/wsn/b-2")]
    public class AbsoluteOrRelativeTimeType
    {
        [XmlText]
        public string Value { get; set; }
    }

    public class SubscriptionPolicy
    {
        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlType(Namespace = "http://www.w3.org/2005/08/addressing")]
    public class EndpointReferenceType
    {
        [XmlElement("Address", Namespace = "http://www.w3.org/2005/08/addressing")]
        public string Address { get; set; }
    }

    [XmlType(Namespace = "http://docs.oasis-open.org/wsn/b-2")]
    public class NotificationMessageHolder
    {
    }

    [XmlType(Namespace = "http://docs.oasis-open.org/wsn/t-1")]
    public class TopicSet
    {
    }

    [XmlRoot("Unsubscribe", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
    public class UnsubscribeRequest
    {
    }

    [XmlRoot("UnsubscribeResponse", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
    public class UnsubscribeResponse
    {
    }

    [XmlRoot("Subscribe", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
    public class SubscribeRequest
    {
        [XmlElement("ConsumerReference", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public EndpointReferenceType ConsumerReference { get; set; }

        [XmlElement("Filter", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public FilterType Filter { get; set; }

        [XmlElement("InitialTerminationTime", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public AbsoluteOrRelativeTimeType InitialTerminationTime { get; set; }

        [XmlElement("SubscriptionPolicy", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public SubscriptionPolicy SubscriptionPolicy { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("SubscribeResponse", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
    public class SubscribeResponse
    {
        [XmlElement("SubscriptionReference", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public EndpointReferenceType SubscriptionReference { get; set; }

        [XmlElement("CurrentTime", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public DateTime CurrentTime { get; set; }

        [XmlElement("TerminationTime", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public DateTime TerminationTime { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("Renew", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
    public class RenewRequest
    {
        [XmlElement("TerminationTime", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public AbsoluteOrRelativeTimeType TerminationTime { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }

    [XmlRoot("RenewResponse", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
    public class RenewResponse
    {
        [XmlElement("TerminationTime", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public DateTime TerminationTime { get; set; }

        [XmlAnyElement]
        public XmlElement[] Any { get; set; }
    }
}
