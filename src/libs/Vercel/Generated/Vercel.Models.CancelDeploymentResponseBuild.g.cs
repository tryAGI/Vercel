
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseBuild
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Env { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseBuild" /> class.
        /// </summary>
        /// <param name="env"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseBuild(
            global::System.Collections.Generic.IList<string> env)
        {
            this.Env = env ?? throw new global::System.ArgumentNullException(nameof(env));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseBuild" /> class.
        /// </summary>
        public CancelDeploymentResponseBuild()
        {
        }
    }
}