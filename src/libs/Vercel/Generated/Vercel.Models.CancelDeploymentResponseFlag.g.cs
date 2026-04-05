
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Flags defined in the Build Output API, used by this deployment. Primarily used by the Toolbar to know about the used flags.
    /// </summary>
    public sealed partial class CancelDeploymentResponseFlag
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}