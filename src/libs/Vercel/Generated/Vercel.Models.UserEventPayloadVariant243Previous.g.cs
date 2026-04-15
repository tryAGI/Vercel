
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Automatic code review settings
    /// </summary>
    public sealed partial class UserEventPayloadVariant243Previous
    {
        /// <summary>
        /// Whether automatic code reviews are enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Which repository visibilities get automatic reviews
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant243PreviousScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant243PreviousScope Scope { get; set; }

        /// <summary>
        /// Whether to include draft pull requests in automatic reviews
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeDrafts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeDrafts { get; set; }

        /// <summary>
        /// GitHub repos to scope automatic reviews to. Format: "owner/repo" (lowercase). Only used when scope='selected_repos'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectedRepos")]
        public global::System.Collections.Generic.IList<string>? SelectedRepos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant243Previous" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether automatic code reviews are enabled
        /// </param>
        /// <param name="scope">
        /// Which repository visibilities get automatic reviews
        /// </param>
        /// <param name="includeDrafts">
        /// Whether to include draft pull requests in automatic reviews
        /// </param>
        /// <param name="selectedRepos">
        /// GitHub repos to scope automatic reviews to. Format: "owner/repo" (lowercase). Only used when scope='selected_repos'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant243Previous(
            bool enabled,
            global::Vercel.UserEventPayloadVariant243PreviousScope scope,
            bool includeDrafts,
            global::System.Collections.Generic.IList<string>? selectedRepos)
        {
            this.Enabled = enabled;
            this.Scope = scope;
            this.IncludeDrafts = includeDrafts;
            this.SelectedRepos = selectedRepos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant243Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant243Previous()
        {
        }
    }
}