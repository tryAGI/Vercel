
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant204
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant204Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedMembership")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant204RemovedMembership RemovedMembership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant204" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="removedMembership"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant204(
            global::Vercel.UserEventPayloadVariant204Project project,
            global::Vercel.UserEventPayloadVariant204RemovedMembership removedMembership)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.RemovedMembership = removedMembership ?? throw new global::System.ArgumentNullException(nameof(removedMembership));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant204" /> class.
        /// </summary>
        public UserEventPayloadVariant204()
        {
        }
    }
}