
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2GitSourceVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2GitSourceVariant11TypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2GitSourceVariant11Type Type { get; set; }

        /// <summary>
        /// Origin repository id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoId { get; set; }

        /// <summary>
        /// Owner (namespace) slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        public string? Repo { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2GitSourceVariant11" /> class.
        /// </summary>
        /// <param name="repoId">
        /// Origin repository id.
        /// </param>
        /// <param name="type"></param>
        /// <param name="owner">
        /// Owner (namespace) slug.
        /// </param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="prId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2GitSourceVariant11(
            string repoId,
            global::Vercel.CreateDeploymentResponseVariant2GitSourceVariant11Type type,
            string? owner,
            string? repo,
            string? @ref,
            string? sha,
            double? prId)
        {
            this.Type = type;
            this.RepoId = repoId ?? throw new global::System.ArgumentNullException(nameof(repoId));
            this.Owner = owner;
            this.Repo = repo;
            this.Ref = @ref;
            this.Sha = sha;
            this.PrId = prId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2GitSourceVariant11" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2GitSourceVariant11()
        {
        }

    }
}