
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Commit metadata from the git commit author
    /// </summary>
    public sealed partial class CreateDeploymentResponseAttributionCommitMeta
    {
        /// <summary>
        /// Email from git commit author
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Name from git commit author
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the commit was signed/verified (GitHub only, others return undefined)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isVerified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseAttributionCommitMeta" /> class.
        /// </summary>
        /// <param name="email">
        /// Email from git commit author
        /// </param>
        /// <param name="name">
        /// Name from git commit author
        /// </param>
        /// <param name="isVerified">
        /// Whether the commit was signed/verified (GitHub only, others return undefined)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseAttributionCommitMeta(
            string? email,
            string? name,
            bool? isVerified)
        {
            this.Email = email;
            this.Name = name;
            this.IsVerified = isVerified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseAttributionCommitMeta" /> class.
        /// </summary>
        public CreateDeploymentResponseAttributionCommitMeta()
        {
        }
    }
}