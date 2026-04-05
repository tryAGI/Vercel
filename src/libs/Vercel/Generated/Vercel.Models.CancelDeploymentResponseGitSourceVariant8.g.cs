
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseGitSourceVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseGitSourceVariant8TypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseGitSourceVariant8Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaceUuid")]
        public string? WorkspaceUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoUuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prId")]
        public double? PrId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseGitSourceVariant8" /> class.
        /// </summary>
        /// <param name="repoUuid"></param>
        /// <param name="type"></param>
        /// <param name="workspaceUuid"></param>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="prId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseGitSourceVariant8(
            string repoUuid,
            global::Vercel.CancelDeploymentResponseGitSourceVariant8Type type,
            string? workspaceUuid,
            string? @ref,
            string? sha,
            double? prId)
        {
            this.Type = type;
            this.WorkspaceUuid = workspaceUuid;
            this.RepoUuid = repoUuid ?? throw new global::System.ArgumentNullException(nameof(repoUuid));
            this.Ref = @ref;
            this.Sha = sha;
            this.PrId = prId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseGitSourceVariant8" /> class.
        /// </summary>
        public CancelDeploymentResponseGitSourceVariant8()
        {
        }
    }
}