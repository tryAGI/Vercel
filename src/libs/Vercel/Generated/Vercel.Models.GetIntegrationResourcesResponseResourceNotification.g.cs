
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The notification, if set, displayed to the user when viewing the resource in Vercel
    /// </summary>
    public sealed partial class GetIntegrationResourcesResponseResourceNotification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetIntegrationResourcesResponseResourceNotificationLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetIntegrationResourcesResponseResourceNotificationLevel Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourcesResponseResourceNotification" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="level"></param>
        /// <param name="message"></param>
        /// <param name="href"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetIntegrationResourcesResponseResourceNotification(
            string title,
            global::Vercel.GetIntegrationResourcesResponseResourceNotificationLevel level,
            string? message,
            string? href)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Level = level;
            this.Message = message;
            this.Href = href;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetIntegrationResourcesResponseResourceNotification" /> class.
        /// </summary>
        public GetIntegrationResourcesResponseResourceNotification()
        {
        }
    }
}