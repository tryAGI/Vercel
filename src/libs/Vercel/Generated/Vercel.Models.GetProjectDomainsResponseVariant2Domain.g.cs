
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectDomainsResponseVariant2Domain
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apexName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApexName { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customEnvironmentId")]
        public string? CustomEnvironmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public double? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public double? CreatedAt { get; set; }

        /// <summary>
        /// `true` if the domain is verified for use with the project. If `false` it will not be used as an alias on this project until the challenge in `verification` is completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        /// A list of verification challenges, one of which must be completed to verify the domain for use on the project. After the challenge is complete `POST /projects/:idOrName/domains/:domain/verify` to verify the domain. Possible challenges: - If `verification.type = TXT` the `verification.domain` will be checked for a TXT record matching `verification.value`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectDomainsResponseVariant2DomainVerificationItem>? Verification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDomainsResponseVariant2Domain" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="apexName"></param>
        /// <param name="projectId"></param>
        /// <param name="verified">
        /// `true` if the domain is verified for use with the project. If `false` it will not be used as an alias on this project until the challenge in `verification` is completed.
        /// </param>
        /// <param name="redirect"></param>
        /// <param name="redirectStatusCode"></param>
        /// <param name="gitBranch"></param>
        /// <param name="customEnvironmentId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="verification">
        /// A list of verification challenges, one of which must be completed to verify the domain for use on the project. After the challenge is complete `POST /projects/:idOrName/domains/:domain/verify` to verify the domain. Possible challenges: - If `verification.type = TXT` the `verification.domain` will be checked for a TXT record matching `verification.value`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectDomainsResponseVariant2Domain(
            string name,
            string apexName,
            string projectId,
            bool verified,
            string? redirect,
            double? redirectStatusCode,
            string? gitBranch,
            string? customEnvironmentId,
            double? updatedAt,
            double? createdAt,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectDomainsResponseVariant2DomainVerificationItem>? verification)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ApexName = apexName ?? throw new global::System.ArgumentNullException(nameof(apexName));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Redirect = redirect;
            this.RedirectStatusCode = redirectStatusCode;
            this.GitBranch = gitBranch;
            this.CustomEnvironmentId = customEnvironmentId;
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Verified = verified;
            this.Verification = verification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectDomainsResponseVariant2Domain" /> class.
        /// </summary>
        public GetProjectDomainsResponseVariant2Domain()
        {
        }
    }
}