
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Builder selected by the resolver.
    /// </summary>
    public sealed partial class CancelDeploymentResponseServiceVariant2Builder
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
        public global::Vercel.CancelDeploymentResponseServiceVariant2BuilderConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2Builder" /> class.
        /// </summary>
        /// <param name="use"></param>
        /// <param name="src"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseServiceVariant2Builder(
            string use,
            string? src,
            global::Vercel.CancelDeploymentResponseServiceVariant2BuilderConfig? config)
        {
            this.Use = use ?? throw new global::System.ArgumentNullException(nameof(use));
            this.Src = src;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2Builder" /> class.
        /// </summary>
        public CancelDeploymentResponseServiceVariant2Builder()
        {
        }

    }
}