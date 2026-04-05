
#nullable enable

namespace Vercel
{
    /// <summary>
    /// MFA configuration. When enabled, the user will be required to provide a second factor of authentication when logging in.
    /// </summary>
    public sealed partial class UserEventPayloadVariant114NewOwnerMfaConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledAt")]
        public double? EnabledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recoveryCodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RecoveryCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totp")]
        public global::Vercel.UserEventPayloadVariant114NewOwnerMfaConfigurationTotp? Totp { get; set; }

        /// <summary>
        /// History of MFA state changes (enabled/disabled events). Most recent events first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItem>? History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerMfaConfiguration" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="recoveryCodes"></param>
        /// <param name="enabledAt"></param>
        /// <param name="totp"></param>
        /// <param name="history">
        /// History of MFA state changes (enabled/disabled events). Most recent events first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant114NewOwnerMfaConfiguration(
            bool enabled,
            global::System.Collections.Generic.IList<string> recoveryCodes,
            double? enabledAt,
            global::Vercel.UserEventPayloadVariant114NewOwnerMfaConfigurationTotp? totp,
            global::System.Collections.Generic.IList<global::Vercel.UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItem>? history)
        {
            this.Enabled = enabled;
            this.EnabledAt = enabledAt;
            this.RecoveryCodes = recoveryCodes ?? throw new global::System.ArgumentNullException(nameof(recoveryCodes));
            this.Totp = totp;
            this.History = history;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerMfaConfiguration" /> class.
        /// </summary>
        public UserEventPayloadVariant114NewOwnerMfaConfiguration()
        {
        }
    }
}