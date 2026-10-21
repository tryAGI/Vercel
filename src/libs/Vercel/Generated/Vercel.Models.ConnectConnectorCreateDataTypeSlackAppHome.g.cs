
#nullable enable

namespace Vercel
{
    /// <summary>
    /// App Home settings for the managed Slack app. Updates preserve omitted settings.
    /// </summary>
    public sealed partial class ConnectConnectorCreateDataTypeSlackAppHome
    {
        /// <summary>
        /// Enable the Home tab for views.publish. Defaults to false for new apps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homeTabEnabled")]
        public bool? HomeTabEnabled { get; set; }

        /// <summary>
        /// Enable the Messages tab. Defaults to true for new apps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messagesTabEnabled")]
        public bool? MessagesTabEnabled { get; set; }

        /// <summary>
        /// Make the Messages tab read-only. Defaults to false for new apps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messagesTabReadOnlyEnabled")]
        public bool? MessagesTabReadOnlyEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSlackAppHome" /> class.
        /// </summary>
        /// <param name="homeTabEnabled">
        /// Enable the Home tab for views.publish. Defaults to false for new apps.
        /// </param>
        /// <param name="messagesTabEnabled">
        /// Enable the Messages tab. Defaults to true for new apps.
        /// </param>
        /// <param name="messagesTabReadOnlyEnabled">
        /// Make the Messages tab read-only. Defaults to false for new apps.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorCreateDataTypeSlackAppHome(
            bool? homeTabEnabled,
            bool? messagesTabEnabled,
            bool? messagesTabReadOnlyEnabled)
        {
            this.HomeTabEnabled = homeTabEnabled;
            this.MessagesTabEnabled = messagesTabEnabled;
            this.MessagesTabReadOnlyEnabled = messagesTabReadOnlyEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorCreateDataTypeSlackAppHome" /> class.
        /// </summary>
        public ConnectConnectorCreateDataTypeSlackAppHome()
        {
        }

    }
}