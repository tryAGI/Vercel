
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCheckRunsResponseRunSourceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListCheckRunsResponseRunSourceVariant2KindJsonConverter))]
        public global::Vercel.ListCheckRunsResponseRunSourceVariant2Kind Kind { get; set; }

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
        /// Initializes a new instance of the <see cref="ListCheckRunsResponseRunSourceVariant2" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="webhookId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCheckRunsResponseRunSourceVariant2(
            global::Vercel.ListCheckRunsResponseRunSourceVariant2Kind kind,
            string? webhookId)
        {
            this.Kind = kind;
            this.WebhookId = webhookId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCheckRunsResponseRunSourceVariant2" /> class.
        /// </summary>
        public ListCheckRunsResponseRunSourceVariant2()
        {
        }
    }
}