
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseFlagsDefinitions2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseFlagsDefinitionsOption>? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseFlagsDefinitions2" /> class.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="url"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseFlagsDefinitions2(
            global::System.Collections.Generic.IList<global::Vercel.CancelDeploymentResponseFlagsDefinitionsOption>? options,
            string? url,
            string? description)
        {
            this.Options = options;
            this.Url = url;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseFlagsDefinitions2" /> class.
        /// </summary>
        public CancelDeploymentResponseFlagsDefinitions2()
        {
        }
    }
}