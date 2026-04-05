
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListProjectChecksResponseCheckSourceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListProjectChecksResponseCheckSourceVariant2KindJsonConverter))]
        public global::Vercel.ListProjectChecksResponseCheckSourceVariant2Kind Kind { get; set; }

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
        /// Initializes a new instance of the <see cref="ListProjectChecksResponseCheckSourceVariant2" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="webhookId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectChecksResponseCheckSourceVariant2(
            global::Vercel.ListProjectChecksResponseCheckSourceVariant2Kind kind,
            string? webhookId)
        {
            this.Kind = kind;
            this.WebhookId = webhookId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectChecksResponseCheckSourceVariant2" /> class.
        /// </summary>
        public ListProjectChecksResponseCheckSourceVariant2()
        {
        }
    }
}