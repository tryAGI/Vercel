
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentRequestGitSourceVariant5
    {
        /// <summary>
        /// Example: vercel
        /// </summary>
        /// <example>vercel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// Example: next.js
        /// </summary>
        /// <example>next.js</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repo { get; set; }

        /// <summary>
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0
        /// </summary>
        /// <example>a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentRequestGitSourceVariant5TypeJsonConverter))]
        public global::Vercel.CreateDeploymentRequestGitSourceVariant5Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitSourceVariant5" /> class.
        /// </summary>
        /// <param name="org">
        /// Example: vercel
        /// </param>
        /// <param name="ref">
        /// Example: main
        /// </param>
        /// <param name="repo">
        /// Example: next.js
        /// </param>
        /// <param name="sha">
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequestGitSourceVariant5(
            string org,
            string @ref,
            string repo,
            string? sha,
            global::Vercel.CreateDeploymentRequestGitSourceVariant5Type type)
        {
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Sha = sha;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitSourceVariant5" /> class.
        /// </summary>
        public CreateDeploymentRequestGitSourceVariant5()
        {
        }
    }
}