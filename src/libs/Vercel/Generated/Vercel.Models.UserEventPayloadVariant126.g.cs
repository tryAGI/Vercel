
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant126
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant126Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant126Group Group { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant126" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="group"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant126(
            global::Vercel.UserEventPayloadVariant126Project project,
            global::Vercel.UserEventPayloadVariant126Group group)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant126" /> class.
        /// </summary>
        public UserEventPayloadVariant126()
        {
        }
    }
}