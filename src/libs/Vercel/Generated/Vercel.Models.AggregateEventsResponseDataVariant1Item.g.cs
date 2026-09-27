
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AggregateEventsResponseDataVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browserName")]
        public string? BrowserName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceType")]
        public string? DeviceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventData")]
        public string? EventData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventName")]
        public string? EventName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        public string? Flags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("osName")]
        public string? OsName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        public string? ProjectName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referrerHostname")]
        public string? ReferrerHostname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestHostname")]
        public string? RequestHostname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestPath")]
        public string? RequestPath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        public string? Route { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmCampaign")]
        public string? UtmCampaign { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmContent")]
        public string? UtmContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmMedium")]
        public string? UtmMedium { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmSource")]
        public string? UtmSource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmTerm")]
        public string? UtmTerm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visitorId")]
        public string? VisitorId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateEventsResponseDataVariant1Item" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="browserName"></param>
        /// <param name="country"></param>
        /// <param name="deviceType"></param>
        /// <param name="environment"></param>
        /// <param name="eventData"></param>
        /// <param name="eventName"></param>
        /// <param name="flags"></param>
        /// <param name="osName"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="referrerHostname"></param>
        /// <param name="requestHostname"></param>
        /// <param name="requestPath"></param>
        /// <param name="route"></param>
        /// <param name="utmCampaign"></param>
        /// <param name="utmContent"></param>
        /// <param name="utmMedium"></param>
        /// <param name="utmSource"></param>
        /// <param name="utmTerm"></param>
        /// <param name="visitorId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AggregateEventsResponseDataVariant1Item(
            global::System.DateTime timestamp,
            string? browserName,
            string? country,
            string? deviceType,
            string? environment,
            string? eventData,
            string? eventName,
            string? flags,
            string? osName,
            string? projectId,
            string? projectName,
            string? referrerHostname,
            string? requestHostname,
            string? requestPath,
            string? route,
            string? utmCampaign,
            string? utmContent,
            string? utmMedium,
            string? utmSource,
            string? utmTerm,
            string? visitorId)
        {
            this.BrowserName = browserName;
            this.Country = country;
            this.DeviceType = deviceType;
            this.Environment = environment;
            this.EventData = eventData;
            this.EventName = eventName;
            this.Flags = flags;
            this.OsName = osName;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.ReferrerHostname = referrerHostname;
            this.RequestHostname = requestHostname;
            this.RequestPath = requestPath;
            this.Route = route;
            this.UtmCampaign = utmCampaign;
            this.UtmContent = utmContent;
            this.UtmMedium = utmMedium;
            this.UtmSource = utmSource;
            this.UtmTerm = utmTerm;
            this.VisitorId = visitorId;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateEventsResponseDataVariant1Item" /> class.
        /// </summary>
        public AggregateEventsResponseDataVariant1Item()
        {
        }

    }
}