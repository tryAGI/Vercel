
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddProjectDomainResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apexName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApexName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentId")]
        public string? CustomEnvironmentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public string? Redirect { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectStatusCode")]
        public double? RedirectStatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// A list of verification challenges, one of which must be completed to verify the domain for use on the project. After the challenge is complete `POST /projects/:idOrName/domains/:domain/verify` to verify the domain. Possible challenges: - If `verification.type = TXT` the `verification.domain` will be checked for a TXT record matching `verification.value`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification")]
        public global::System.Collections.Generic.IList<global::Vercel.AddProjectDomainResponseVerificationItem>? Verification { get; set; }

        /// <summary>
        /// `true` if the domain is verified for use with the project. If `false` it will not be used as an alias on this project until the challenge in `verification` is completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectDomainResponse" /> class.
        /// </summary>
        /// <param name="apexName"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="verified">
        /// `true` if the domain is verified for use with the project. If `false` it will not be used as an alias on this project until the challenge in `verification` is completed.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="customEnvironmentId"></param>
        /// <param name="gitBranch"></param>
        /// <param name="redirect"></param>
        /// <param name="redirectStatusCode"></param>
        /// <param name="updatedAt"></param>
        /// <param name="verification">
        /// A list of verification challenges, one of which must be completed to verify the domain for use on the project. After the challenge is complete `POST /projects/:idOrName/domains/:domain/verify` to verify the domain. Possible challenges: - If `verification.type = TXT` the `verification.domain` will be checked for a TXT record matching `verification.value`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddProjectDomainResponse(
            string apexName,
            string name,
            string projectId,
            bool verified,
            double? createdAt,
            string? customEnvironmentId,
            string? gitBranch,
            string? redirect,
            double? redirectStatusCode,
            double? updatedAt,
            global::System.Collections.Generic.IList<global::Vercel.AddProjectDomainResponseVerificationItem>? verification)
        {
            this.ApexName = apexName ?? throw new global::System.ArgumentNullException(nameof(apexName));
            this.CreatedAt = createdAt;
            this.CustomEnvironmentId = customEnvironmentId;
            this.GitBranch = gitBranch;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Redirect = redirect;
            this.RedirectStatusCode = redirectStatusCode;
            this.UpdatedAt = updatedAt;
            this.Verification = verification;
            this.Verified = verified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddProjectDomainResponse" /> class.
        /// </summary>
        public AddProjectDomainResponse()
        {
        }

    }
}