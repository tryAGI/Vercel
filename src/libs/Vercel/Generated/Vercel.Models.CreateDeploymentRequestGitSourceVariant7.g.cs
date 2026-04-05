
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentRequestGitSourceVariant7
    {
        /// <summary>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoUuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoUuid { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentRequestGitSourceVariant7TypeJsonConverter))]
        public global::Vercel.CreateDeploymentRequestGitSourceVariant7Type Type { get; set; }

        /// <summary>
        /// Example: 987e6543-e21b-12d3-a456-426614174000
        /// </summary>
        /// <example>987e6543-e21b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaceUuid")]
        public string? WorkspaceUuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitSourceVariant7" /> class.
        /// </summary>
        /// <param name="ref">
        /// Example: main
        /// </param>
        /// <param name="repoUuid">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="sha">
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0
        /// </param>
        /// <param name="type"></param>
        /// <param name="workspaceUuid">
        /// Example: 987e6543-e21b-12d3-a456-426614174000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequestGitSourceVariant7(
            string @ref,
            string repoUuid,
            string? sha,
            global::Vercel.CreateDeploymentRequestGitSourceVariant7Type type,
            string? workspaceUuid)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.RepoUuid = repoUuid ?? throw new global::System.ArgumentNullException(nameof(repoUuid));
            this.Sha = sha;
            this.Type = type;
            this.WorkspaceUuid = workspaceUuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitSourceVariant7" /> class.
        /// </summary>
        public CreateDeploymentRequestGitSourceVariant7()
        {
        }
    }
}