
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant272
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exportId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExportId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double To { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant272" /> class.
        /// </summary>
        /// <param name="exportId"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant272(
            string exportId,
            double from,
            double to,
            string format)
        {
            this.ExportId = exportId ?? throw new global::System.ArgumentNullException(nameof(exportId));
            this.From = from;
            this.To = to;
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant272" /> class.
        /// </summary>
        public UserEventPayloadVariant272()
        {
        }
    }
}