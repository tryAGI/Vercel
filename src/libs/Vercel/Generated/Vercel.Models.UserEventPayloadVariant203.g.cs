
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant203
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant203Project> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamMembership")]
        public global::Vercel.UserEventPayloadVariant203TeamMembership? TeamMembership { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directoryType")]
        public string? DirectoryType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant203" /> class.
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="teamMembership"></param>
        /// <param name="directoryType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant203(
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant203Project> projects,
            global::Vercel.UserEventPayloadVariant203TeamMembership? teamMembership,
            string? directoryType)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.TeamMembership = teamMembership;
            this.DirectoryType = directoryType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant203" /> class.
        /// </summary>
        public UserEventPayloadVariant203()
        {
        }
    }
}