
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportResourceRequestNotification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ImportResourceRequestNotificationLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ImportResourceRequestNotificationLevel Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

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
        /// Initializes a new instance of the <see cref="ImportResourceRequestNotification" /> class.
        /// </summary>
        /// <param name="level"></param>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="href"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImportResourceRequestNotification(
            global::Vercel.ImportResourceRequestNotificationLevel level,
            string title,
            string? message,
            string? href)
        {
            this.Level = level;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Message = message;
            this.Href = href;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportResourceRequestNotification" /> class.
        /// </summary>
        public ImportResourceRequestNotification()
        {
        }
    }
}