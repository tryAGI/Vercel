
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant51
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant51Team Team { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant51Configuration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant51Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildsEnabled")]
        public bool? BuildsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant51" /> class.
        /// </summary>
        /// <param name="team"></param>
        /// <param name="configuration"></param>
        /// <param name="project"></param>
        /// <param name="buildsEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant51(
            global::Vercel.UserEventPayloadVariant51Team team,
            global::Vercel.UserEventPayloadVariant51Configuration configuration,
            global::Vercel.UserEventPayloadVariant51Project project,
            bool? buildsEnabled)
        {
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.Configuration = configuration ?? throw new global::System.ArgumentNullException(nameof(configuration));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.BuildsEnabled = buildsEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant51" /> class.
        /// </summary>
        public UserEventPayloadVariant51()
        {
        }
    }
}