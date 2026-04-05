
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object containing the deployment's metadata. Multiple key-value pairs can be attached to a deployment<br/>
    /// Example: {"foo":"bar"}
    /// </summary>
    public sealed partial class CreateDeploymentRequestMeta
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}