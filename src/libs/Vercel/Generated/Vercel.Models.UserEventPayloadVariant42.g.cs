
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant42
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant42Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulkRedirectsLimit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BulkRedirectsLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevBulkRedirectsLimit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PrevBulkRedirectsLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant42" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="bulkRedirectsLimit"></param>
        /// <param name="prevBulkRedirectsLimit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant42(
            global::Vercel.UserEventPayloadVariant42Project project,
            double bulkRedirectsLimit,
            double prevBulkRedirectsLimit)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.BulkRedirectsLimit = bulkRedirectsLimit;
            this.PrevBulkRedirectsLimit = prevBulkRedirectsLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant42" /> class.
        /// </summary>
        public UserEventPayloadVariant42()
        {
        }
    }
}