
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant141
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public global::Vercel.UserEventPayloadVariant141Previous? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant141Next Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant141" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="next"></param>
        /// <param name="previous"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant141(
            string projectId,
            global::Vercel.UserEventPayloadVariant141Next next,
            global::Vercel.UserEventPayloadVariant141Previous? previous)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Previous = previous;
            this.Next = next ?? throw new global::System.ArgumentNullException(nameof(next));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant141" /> class.
        /// </summary>
        public UserEventPayloadVariant141()
        {
        }
    }
}