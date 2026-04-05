
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1GitSourceVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant1GitSourceVariant13TypeJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant1GitSourceVariant13Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        public string? Repo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1GitSourceVariant13" /> class.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="repoId"></param>
        /// <param name="type"></param>
        /// <param name="org"></param>
        /// <param name="repo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1GitSourceVariant13(
            string host,
            string @ref,
            string sha,
            double repoId,
            global::Vercel.GetDeploymentResponseVariant1GitSourceVariant13Type type,
            string? org,
            string? repo)
        {
            this.Type = type;
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.RepoId = repoId;
            this.Org = org;
            this.Repo = repo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1GitSourceVariant13" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1GitSourceVariant13()
        {
        }
    }
}