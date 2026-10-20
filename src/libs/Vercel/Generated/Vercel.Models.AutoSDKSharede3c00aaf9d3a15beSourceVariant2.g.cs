
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede3c00aaf9d3a15beSourceVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede3c00aaf9d3a15beSourceVariant2KindJsonConverter))]
        public global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant2Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookId")]
        public string? WebhookId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede3c00aaf9d3a15beSourceVariant2" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="webhookId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede3c00aaf9d3a15beSourceVariant2(
            global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant2Kind kind,
            string? webhookId)
        {
            this.Kind = kind;
            this.WebhookId = webhookId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede3c00aaf9d3a15beSourceVariant2" /> class.
        /// </summary>
        public AutoSDKSharede3c00aaf9d3a15beSourceVariant2()
        {
        }

    }
}