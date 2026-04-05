
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseBuild2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseBuild2" /> class.
        /// </summary>
        /// <param name="use"></param>
        /// <param name="src"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseBuild2(
            string use,
            string? src,
            object? config)
        {
            this.Use = use ?? throw new global::System.ArgumentNullException(nameof(use));
            this.Src = src;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseBuild2" /> class.
        /// </summary>
        public CreateDeploymentResponseBuild2()
        {
        }
    }
}