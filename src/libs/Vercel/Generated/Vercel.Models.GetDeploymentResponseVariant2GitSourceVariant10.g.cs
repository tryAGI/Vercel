
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant2GitSourceVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2GitSourceVariant10TypeJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2GitSourceVariant10Type Type { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoPushedAt")]
        public double? RepoPushedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

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
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2GitSourceVariant10" /> class.
        /// </summary>
        /// <param name="sha"></param>
        /// <param name="type"></param>
        /// <param name="org"></param>
        /// <param name="repo"></param>
        /// <param name="repoPushedAt"></param>
        /// <param name="ref"></param>
        /// <param name="prId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant2GitSourceVariant10(
            string sha,
            global::Vercel.GetDeploymentResponseVariant2GitSourceVariant10Type type,
            string? org,
            string? repo,
            double? repoPushedAt,
            string? @ref,
            double? prId)
        {
            this.Type = type;
            this.Org = org;
            this.Repo = repo;
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.RepoPushedAt = repoPushedAt;
            this.Ref = @ref;
            this.PrId = prId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2GitSourceVariant10" /> class.
        /// </summary>
        public GetDeploymentResponseVariant2GitSourceVariant10()
        {
        }
    }
}