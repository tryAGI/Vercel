
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2GitSourceVariant18
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitMetadata")]
        public global::Vercel.CreateDeploymentResponseVariant2GitSourceVariant18CommitMetadata? CommitMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Org { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2GitSourceVariant18TypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2GitSourceVariant18Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2GitSourceVariant18" /> class.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="ref"></param>
        /// <param name="repo"></param>
        /// <param name="sha"></param>
        /// <param name="commitMetadata"></param>
        /// <param name="repoPushedAt"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2GitSourceVariant18(
            string org,
            string @ref,
            string repo,
            string sha,
            global::Vercel.CreateDeploymentResponseVariant2GitSourceVariant18CommitMetadata? commitMetadata,
            double? repoPushedAt,
            global::Vercel.CreateDeploymentResponseVariant2GitSourceVariant18Type type)
        {
            this.CommitMetadata = commitMetadata;
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.RepoPushedAt = repoPushedAt;
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2GitSourceVariant18" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2GitSourceVariant18()
        {
        }

    }
}