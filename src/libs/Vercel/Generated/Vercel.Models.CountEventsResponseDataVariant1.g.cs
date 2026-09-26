
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CountEventsResponseDataVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browserName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BrowserName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Country { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeviceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Flags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("osName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OsName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referrerHostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferrerHostname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestHostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestHostname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestPath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Route { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmCampaign")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UtmCampaign { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmContent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UtmContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmMedium")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UtmMedium { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmSource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UtmSource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utmTerm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UtmTerm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visitorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VisitorId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountEventsResponseDataVariant1" /> class.
        /// </summary>
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
        public CountEventsResponseDataVariant1(
            string browserName,
            string country,
            string deviceType,
            string environment,
            string eventData,
            string eventName,
            string flags,
            string osName,
            string projectId,
            string projectName,
            string referrerHostname,
            string requestHostname,
            string requestPath,
            string route,
            string utmCampaign,
            string utmContent,
            string utmMedium,
            string utmSource,
            string utmTerm,
            string visitorId)
        {
            this.BrowserName = browserName ?? throw new global::System.ArgumentNullException(nameof(browserName));
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.DeviceType = deviceType ?? throw new global::System.ArgumentNullException(nameof(deviceType));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.EventData = eventData ?? throw new global::System.ArgumentNullException(nameof(eventData));
            this.EventName = eventName ?? throw new global::System.ArgumentNullException(nameof(eventName));
            this.Flags = flags ?? throw new global::System.ArgumentNullException(nameof(flags));
            this.OsName = osName ?? throw new global::System.ArgumentNullException(nameof(osName));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.ReferrerHostname = referrerHostname ?? throw new global::System.ArgumentNullException(nameof(referrerHostname));
            this.RequestHostname = requestHostname ?? throw new global::System.ArgumentNullException(nameof(requestHostname));
            this.RequestPath = requestPath ?? throw new global::System.ArgumentNullException(nameof(requestPath));
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
            this.UtmCampaign = utmCampaign ?? throw new global::System.ArgumentNullException(nameof(utmCampaign));
            this.UtmContent = utmContent ?? throw new global::System.ArgumentNullException(nameof(utmContent));
            this.UtmMedium = utmMedium ?? throw new global::System.ArgumentNullException(nameof(utmMedium));
            this.UtmSource = utmSource ?? throw new global::System.ArgumentNullException(nameof(utmSource));
            this.UtmTerm = utmTerm ?? throw new global::System.ArgumentNullException(nameof(utmTerm));
            this.VisitorId = visitorId ?? throw new global::System.ArgumentNullException(nameof(visitorId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountEventsResponseDataVariant1" /> class.
        /// </summary>
        public CountEventsResponseDataVariant1()
        {
        }

    }
}