
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Trigger-specific credentials (e.g. webhook signing secret). Validated and encrypted against the trigger type definition.
    /// </summary>
    public sealed partial class ConnectCreateConnectorRequestTriggerData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}