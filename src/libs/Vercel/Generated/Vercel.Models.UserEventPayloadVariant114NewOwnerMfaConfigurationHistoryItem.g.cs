
#nullable enable

namespace Vercel
{
    /// <summary>
    /// History of MFA state changes (enabled/disabled events). Most recent events first.
    /// </summary>
    public sealed partial class UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItem
    {
        /// <summary>
        /// The action that occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemAction Action { get; set; }

        /// <summary>
        /// Unix timestamp (milliseconds) when the change occurred. May be null for events that occurred before history tracking was implemented.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// Method used for the state change - 'totp': User set up TOTP authenticator - 'passkey': User registered a passkey - 'user_disabled': User disabled their own MFA - 'admin_removal': Admin removed MFA via backoffice - 'unknown': Method unknown (for pre-tracking events)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod Method { get; set; }

        /// <summary>
        /// ID of the actor who made the change - For user actions: the user's own ID - For admin actions: the admin's user ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorId { get; set; }

        /// <summary>
        /// Type of actor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActorType ActorType { get; set; }

        /// <summary>
        /// Optional: Additional context or reason e.g., "Account recovery request - ticket #12345"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItem" /> class.
        /// </summary>
        /// <param name="action">
        /// The action that occurred
        /// </param>
        /// <param name="method">
        /// Method used for the state change - 'totp': User set up TOTP authenticator - 'passkey': User registered a passkey - 'user_disabled': User disabled their own MFA - 'admin_removal': Admin removed MFA via backoffice - 'unknown': Method unknown (for pre-tracking events)
        /// </param>
        /// <param name="actorId">
        /// ID of the actor who made the change - For user actions: the user's own ID - For admin actions: the admin's user ID
        /// </param>
        /// <param name="actorType">
        /// Type of actor
        /// </param>
        /// <param name="timestamp">
        /// Unix timestamp (milliseconds) when the change occurred. May be null for events that occurred before history tracking was implemented.
        /// </param>
        /// <param name="reason">
        /// Optional: Additional context or reason e.g., "Account recovery request - ticket #12345"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItem(
            global::Vercel.UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemAction action,
            global::Vercel.UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod method,
            string actorId,
            global::Vercel.UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActorType actorType,
            double? timestamp,
            string? reason)
        {
            this.Action = action;
            this.Timestamp = timestamp;
            this.Method = method;
            this.ActorId = actorId ?? throw new global::System.ArgumentNullException(nameof(actorId));
            this.ActorType = actorType;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItem" /> class.
        /// </summary>
        public UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItem()
        {
        }
    }
}