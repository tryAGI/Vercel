
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeSlackShortcut
    {
        /// <summary>
        /// Where Slack exposes the shortcut.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ConnectConnectorUpdateDataTypeSlackShortcutTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcutType Type { get; set; }

        /// <summary>
        /// Shortcut display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Identifier included in the shortcut callback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbackId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallbackId { get; set; }

        /// <summary>
        /// Description shown for the shortcut in Slack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSlackShortcut" /> class.
        /// </summary>
        /// <param name="type">
        /// Where Slack exposes the shortcut.
        /// </param>
        /// <param name="name">
        /// Shortcut display name.
        /// </param>
        /// <param name="callbackId">
        /// Identifier included in the shortcut callback.
        /// </param>
        /// <param name="description">
        /// Description shown for the shortcut in Slack.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeSlackShortcut(
            global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcutType type,
            string name,
            string callbackId,
            string description)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CallbackId = callbackId ?? throw new global::System.ArgumentNullException(nameof(callbackId));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSlackShortcut" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeSlackShortcut()
        {
        }

    }
}