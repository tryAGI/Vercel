
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Allows custom git sources (local folder mounted to the container) in test mode
    /// </summary>
    public sealed partial class CancelDeploymentResponseGitSourceVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseGitSourceVariant11TypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseGitSourceVariant11Type Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("gitUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GitUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseGitSourceVariant11" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="sha"></param>
        /// <param name="gitUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseGitSourceVariant11(
            string @ref,
            string sha,
            string gitUrl,
            global::Vercel.CancelDeploymentResponseGitSourceVariant11Type type)
        {
            this.Type = type;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.GitUrl = gitUrl ?? throw new global::System.ArgumentNullException(nameof(gitUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseGitSourceVariant11" /> class.
        /// </summary>
        public CancelDeploymentResponseGitSourceVariant11()
        {
        }
    }
}