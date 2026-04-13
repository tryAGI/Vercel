
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant191
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant191Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectMembership")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant191ProjectMembership ProjectMembership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant191" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="projectMembership"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant191(
            global::Vercel.UserEventPayloadVariant191Project project,
            global::Vercel.UserEventPayloadVariant191ProjectMembership projectMembership)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.ProjectMembership = projectMembership ?? throw new global::System.ArgumentNullException(nameof(projectMembership));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant191" /> class.
        /// </summary>
        public UserEventPayloadVariant191()
        {
        }
    }
}