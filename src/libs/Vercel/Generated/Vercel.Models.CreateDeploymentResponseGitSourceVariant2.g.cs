
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseGitSourceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseGitSourceVariant2TypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseGitSourceVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repo { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseGitSourceVariant2" /> class.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repo"></param>
        /// <param name="type"></param>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="prId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseGitSourceVariant2(
            string org,
            string repo,
            global::Vercel.CreateDeploymentResponseGitSourceVariant2Type type,
            string? @ref,
            string? sha,
            double? prId)
        {
            this.Type = type;
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Ref = @ref;
            this.Sha = sha;
            this.PrId = prId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseGitSourceVariant2" /> class.
        /// </summary>
        public CreateDeploymentResponseGitSourceVariant2()
        {
        }
    }
}