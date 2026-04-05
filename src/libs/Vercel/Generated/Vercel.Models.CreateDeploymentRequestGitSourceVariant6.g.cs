
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentRequestGitSourceVariant6
    {
        /// <summary>
        /// Example: 987654321
        /// </summary>
        /// <example>987654321</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<double?, string> ProjectId { get; set; }

        /// <summary>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentRequestGitSourceVariant6TypeJsonConverter))]
        public global::Vercel.CreateDeploymentRequestGitSourceVariant6Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitSourceVariant6" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Example: 987654321
        /// </param>
        /// <param name="ref">
        /// Example: main
        /// </param>
        /// <param name="sha">
        /// Example: a1b2c3d4e5f6g7h8i9j0k1l2m3n4o5p6q7r8s9t0
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentRequestGitSourceVariant6(
            global::Vercel.OneOf<double?, string> projectId,
            string @ref,
            string? sha,
            global::Vercel.CreateDeploymentRequestGitSourceVariant6Type type)
        {
            this.ProjectId = projectId;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Sha = sha;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentRequestGitSourceVariant6" /> class.
        /// </summary>
        public CreateDeploymentRequestGitSourceVariant6()
        {
        }
    }
}