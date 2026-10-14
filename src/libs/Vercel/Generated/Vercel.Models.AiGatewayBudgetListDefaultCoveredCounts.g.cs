
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Paged requests only: `source: 'default'` rows per scope type across the whole `scopeType`-filtered list, independent of the page and of `includeDefaultCovered`.
    /// </summary>
    public sealed partial class AiGatewayBudgetListDefaultCoveredCounts
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api-key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ApiKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Project { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Team { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayBudgetListDefaultCoveredCounts" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="project"></param>
        /// <param name="team"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AiGatewayBudgetListDefaultCoveredCounts(
            double apiKey,
            double project,
            double team,
            double user)
        {
            this.ApiKey = apiKey;
            this.Project = project;
            this.Team = team;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AiGatewayBudgetListDefaultCoveredCounts" /> class.
        /// </summary>
        public AiGatewayBudgetListDefaultCoveredCounts()
        {
        }

    }
}