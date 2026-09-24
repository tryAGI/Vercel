
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeploymentRequestGitSourceVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentRequestGitSourceVariant1TypeJsonConverter))]
        public global::Vercel.CreateDeploymentRequestGitSourceVariant1Type Type { get; set; }

        /// <summary>
        /// The stable Vercel Git repository ID.<br/>
        /// Example: 123456789
        /// </summary>
        /// <example>123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoId { get; set; }

        /// <summary>
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0
        /// </summary>
        /// <example>a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitSourceVariant1" /> class.
        /// </summary>
        /// <param name="repoId">
        /// The stable Vercel Git repository ID.<br/>
        /// Example: 123456789
        /// </param>
        /// <param name="sha">
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequestGitSourceVariant1(
            string repoId,
            string sha,
            global::Vercel.CreateDeploymentRequestGitSourceVariant1Type type)
        {
            this.Type = type;
            this.RepoId = repoId ?? throw new global::System.ArgumentNullException(nameof(repoId));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitSourceVariant1" /> class.
        /// </summary>
        public CreateDeploymentRequestGitSourceVariant1()
        {
        }

    }
}