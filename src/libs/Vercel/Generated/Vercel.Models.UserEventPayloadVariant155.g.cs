
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant155
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant155Next Next { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant155Previous Previous { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant155Update> Updates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant155" /> class.
        /// </summary>
        /// <param name="next"></param>
        /// <param name="previous"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="updates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant155(
            global::Vercel.UserEventPayloadVariant155Next next,
            global::Vercel.UserEventPayloadVariant155Previous previous,
            string projectId,
            string projectName,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant155Update> updates)
        {
            this.Next = next ?? throw new global::System.ArgumentNullException(nameof(next));
            this.Previous = previous ?? throw new global::System.ArgumentNullException(nameof(previous));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.Updates = updates ?? throw new global::System.ArgumentNullException(nameof(updates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant155" /> class.
        /// </summary>
        public UserEventPayloadVariant155()
        {
        }
    }
}