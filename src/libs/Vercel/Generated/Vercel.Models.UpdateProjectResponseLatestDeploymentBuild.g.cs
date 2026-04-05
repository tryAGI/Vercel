
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectResponseLatestDeploymentBuild
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Use { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest")]
        public string? Dest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseLatestDeploymentBuild" /> class.
        /// </summary>
        /// <param name="use"></param>
        /// <param name="src"></param>
        /// <param name="dest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseLatestDeploymentBuild(
            string use,
            string? src,
            string? dest)
        {
            this.Use = use ?? throw new global::System.ArgumentNullException(nameof(use));
            this.Src = src;
            this.Dest = dest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseLatestDeploymentBuild" /> class.
        /// </summary>
        public UpdateProjectResponseLatestDeploymentBuild()
        {
        }
    }
}