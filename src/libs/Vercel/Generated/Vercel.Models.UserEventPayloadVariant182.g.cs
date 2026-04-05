
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant182
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant182Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectMembership")]
        public global::Vercel.UserEventPayloadVariant182ProjectMembership? ProjectMembership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant182" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="projectMembership"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant182(
            global::Vercel.UserEventPayloadVariant182Project project,
            global::Vercel.UserEventPayloadVariant182ProjectMembership? projectMembership)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.ProjectMembership = projectMembership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant182" /> class.
        /// </summary>
        public UserEventPayloadVariant182()
        {
        }
    }
}