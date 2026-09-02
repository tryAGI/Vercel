
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeSlackSlashCommand
    {
        /// <summary>
        /// Slash command including its leading slash.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Command { get; set; }

        /// <summary>
        /// Description shown for the slash command in Slack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Optional usage hint shown for the slash command.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageHint")]
        public string? UsageHint { get; set; }

        /// <summary>
        /// Whether Slack should escape command arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldEscape")]
        public bool? ShouldEscape { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSlackSlashCommand" /> class.
        /// </summary>
        /// <param name="command">
        /// Slash command including its leading slash.
        /// </param>
        /// <param name="description">
        /// Description shown for the slash command in Slack.
        /// </param>
        /// <param name="usageHint">
        /// Optional usage hint shown for the slash command.
        /// </param>
        /// <param name="shouldEscape">
        /// Whether Slack should escape command arguments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeSlackSlashCommand(
            string command,
            string description,
            string? usageHint,
            bool? shouldEscape)
        {
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.UsageHint = usageHint;
            this.ShouldEscape = shouldEscape;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSlackSlashCommand" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeSlackSlashCommand()
        {
        }

    }
}