
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant151
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant151Team Team { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant151Project Project { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant151" /> class.
        /// </summary>
        /// <param name="team"></param>
        /// <param name="project"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant151(
            global::Vercel.UserEventPayloadVariant151Team team,
            global::Vercel.UserEventPayloadVariant151Project project)
        {
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant151" /> class.
        /// </summary>
        public UserEventPayloadVariant151()
        {
        }
    }
}