
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1GitSourceVariant17
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant1GitSourceVariant17TypeJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant1GitSourceVariant17Type Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("repoPushedAt")]
        public double? RepoPushedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1GitSourceVariant17" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="org"></param>
        /// <param name="repo"></param>
        /// <param name="type"></param>
        /// <param name="repoPushedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1GitSourceVariant17(
            string @ref,
            string sha,
            string org,
            string repo,
            global::Vercel.GetDeploymentResponseVariant1GitSourceVariant17Type type,
            double? repoPushedAt)
        {
            this.Type = type;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.RepoPushedAt = repoPushedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1GitSourceVariant17" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1GitSourceVariant17()
        {
        }
    }
}