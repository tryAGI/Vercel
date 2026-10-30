
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Code channel settings for the managed Slack app. Updates preserve omitted settings.
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeSlackCodeChannels
    {
        /// <summary>
        /// Enable Slack code channels. Adds the code_channels:manage bot scope and, with triggers, the agent_session_stopped and message.session events. Defaults to false for new apps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSlackCodeChannels" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Enable Slack code channels. Adds the code_channels:manage bot scope and, with triggers, the agent_session_stopped and message.session events. Defaults to false for new apps.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeSlackCodeChannels(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSlackCodeChannels" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeSlackCodeChannels()
        {
        }

    }
}