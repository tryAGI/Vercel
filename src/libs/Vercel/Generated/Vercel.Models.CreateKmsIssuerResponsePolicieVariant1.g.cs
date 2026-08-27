
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateKmsIssuerResponsePolicieVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateKmsIssuerResponsePolicieVariant1KindJsonConverter))]
        public global::Vercel.CreateKmsIssuerResponsePolicieVariant1Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Environments whose OIDC tokens this grant authorizes. Each entry is either a system environment slug (`production`, `preview`, `development`) or a custom environment ID (prefixed `env_`). Custom environments are matched against the token's `custom_environment_id` claim (the stable ID); system environments against its `environment` claim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenClaims")]
        public object? TokenClaims { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKmsIssuerResponsePolicieVariant1" /> class.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="projectId"></param>
        /// <param name="environments">
        /// Environments whose OIDC tokens this grant authorizes. Each entry is either a system environment slug (`production`, `preview`, `development`) or a custom environment ID (prefixed `env_`). Custom environments are matched against the token's `custom_environment_id` claim (the stable ID); system environments against its `environment` claim.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="kind"></param>
        /// <param name="tokenClaims"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKmsIssuerResponsePolicieVariant1(
            string teamId,
            string projectId,
            global::System.Collections.Generic.IList<string> environments,
            string createdAt,
            string updatedAt,
            global::Vercel.CreateKmsIssuerResponsePolicieVariant1Kind kind,
            object? tokenClaims)
        {
            this.Kind = kind;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.TokenClaims = tokenClaims;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKmsIssuerResponsePolicieVariant1" /> class.
        /// </summary>
        public CreateKmsIssuerResponsePolicieVariant1()
        {
        }

    }
}