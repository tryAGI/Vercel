
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant127
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant127Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant127Prev Prev { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant127Group Group { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant127" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="prev"></param>
        /// <param name="group"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant127(
            global::Vercel.UserEventPayloadVariant127Project project,
            global::Vercel.UserEventPayloadVariant127Prev prev,
            global::Vercel.UserEventPayloadVariant127Group group)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Prev = prev ?? throw new global::System.ArgumentNullException(nameof(prev));
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant127" /> class.
        /// </summary>
        public UserEventPayloadVariant127()
        {
        }
    }
}