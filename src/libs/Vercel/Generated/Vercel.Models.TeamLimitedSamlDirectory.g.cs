
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Information for the Directory Sync configuration.
    /// </summary>
    public sealed partial class TeamLimitedSamlDirectory
    {
        /// <summary>
        /// The Identity Provider "type", for example Okta.<br/>
        /// Example: OktaSAML
        /// </summary>
        /// <example>OktaSAML</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Current state of the connection.<br/>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the configuration was connected.<br/>
        /// Example: 1611796915677L
        /// </summary>
        /// <example>1611796915677L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConnectedAt { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the last webhook event was received from WorkOS.<br/>
        /// Example: 1611796915677L
        /// </summary>
        /// <example>1611796915677L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastReceivedWebhookEvent")]
        public double? LastReceivedWebhookEvent { get; set; }

        /// <summary>
        /// Timestamp (in milliseconds) of when the last directory sync was performed.<br/>
        /// Example: 1611796915677L
        /// </summary>
        /// <example>1611796915677L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSyncedAt")]
        public double? LastSyncedAt { get; set; }

        /// <summary>
        /// Controls whether directory sync events are processed. - 'SETUP': Directory connected but role mappings not yet configured. Events are acknowledged but not processed. - 'ACTIVE': Fully configured. Events are processed normally. - undefined: Legacy directory (pre-feature), treat as 'ACTIVE' for backwards compatibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syncState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.TeamLimitedSamlDirectorySyncStateJsonConverter))]
        public global::Vercel.TeamLimitedSamlDirectorySyncState? SyncState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLimitedSamlDirectory" /> class.
        /// </summary>
        /// <param name="type">
        /// The Identity Provider "type", for example Okta.<br/>
        /// Example: OktaSAML
        /// </param>
        /// <param name="state">
        /// Current state of the connection.<br/>
        /// Example: active
        /// </param>
        /// <param name="connectedAt">
        /// Timestamp (in milliseconds) of when the configuration was connected.<br/>
        /// Example: 1611796915677L
        /// </param>
        /// <param name="lastReceivedWebhookEvent">
        /// Timestamp (in milliseconds) of when the last webhook event was received from WorkOS.<br/>
        /// Example: 1611796915677L
        /// </param>
        /// <param name="lastSyncedAt">
        /// Timestamp (in milliseconds) of when the last directory sync was performed.<br/>
        /// Example: 1611796915677L
        /// </param>
        /// <param name="syncState">
        /// Controls whether directory sync events are processed. - 'SETUP': Directory connected but role mappings not yet configured. Events are acknowledged but not processed. - 'ACTIVE': Fully configured. Events are processed normally. - undefined: Legacy directory (pre-feature), treat as 'ACTIVE' for backwards compatibility.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamLimitedSamlDirectory(
            string type,
            string state,
            double connectedAt,
            double? lastReceivedWebhookEvent,
            double? lastSyncedAt,
            global::Vercel.TeamLimitedSamlDirectorySyncState? syncState)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.ConnectedAt = connectedAt;
            this.LastReceivedWebhookEvent = lastReceivedWebhookEvent;
            this.LastSyncedAt = lastSyncedAt;
            this.SyncState = syncState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLimitedSamlDirectory" /> class.
        /// </summary>
        public TeamLimitedSamlDirectory()
        {
        }
    }
}