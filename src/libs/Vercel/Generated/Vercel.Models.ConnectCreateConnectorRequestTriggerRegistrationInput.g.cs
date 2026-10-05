
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Additional registration inputs, validated by the trigger driver. Requires triggers: true. Shared verification credentials are read from triggerData.
    /// </summary>
    public sealed partial class ConnectCreateConnectorRequestTriggerRegistrationInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}