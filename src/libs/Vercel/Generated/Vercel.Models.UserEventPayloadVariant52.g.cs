
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant52
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant52Team Team { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant52Configuration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant52Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildsEnabled")]
        public bool? BuildsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passive")]
        public bool? Passive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant52" /> class.
        /// </summary>
        /// <param name="team"></param>
        /// <param name="configuration"></param>
        /// <param name="project"></param>
        /// <param name="buildsEnabled"></param>
        /// <param name="passive"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant52(
            global::Vercel.UserEventPayloadVariant52Team team,
            global::Vercel.UserEventPayloadVariant52Configuration configuration,
            global::Vercel.UserEventPayloadVariant52Project project,
            bool? buildsEnabled,
            bool? passive)
        {
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.BuildsEnabled = buildsEnabled;
            this.Passive = passive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant52" /> class.
        /// </summary>
        public UserEventPayloadVariant52()
        {
        }
    }
}