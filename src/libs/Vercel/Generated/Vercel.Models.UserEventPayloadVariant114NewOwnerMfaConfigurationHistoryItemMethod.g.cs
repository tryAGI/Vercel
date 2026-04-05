
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Method used for the state change - 'totp': User set up TOTP authenticator - 'passkey': User registered a passkey - 'user_disabled': User disabled their own MFA - 'admin_removal': Admin removed MFA via backoffice - 'unknown': Method unknown (for pre-tracking events)
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod
    {
        /// <summary>
        /// User set up TOTP authenticator - 'passkey': User registered a passkey - 'user_disabled': User disabled their own MFA - 'admin_removal': Admin removed MFA via backoffice - 'unknown': Method unknown (for pre-tracking events)
        /// </summary>
        AdminRemoval,
        /// <summary>
        /// User set up TOTP authenticator - 'passkey': User registered a passkey - 'user_disabled': User disabled their own MFA - 'admin_removal': Admin removed MFA via backoffice - 'unknown': Method unknown (for pre-tracking events)
        /// </summary>
        Passkey,
        /// <summary>
        /// User set up TOTP authenticator - 'passkey': User registered a passkey - 'user_disabled': User disabled their own MFA - 'admin_removal': Admin removed MFA via backoffice - 'unknown': Method unknown (for pre-tracking events)
        /// </summary>
        Totp,
        /// <summary>
        /// User set up TOTP authenticator - 'passkey': User registered a passkey - 'user_disabled': User disabled their own MFA - 'admin_removal': Admin removed MFA via backoffice - 'unknown': Method unknown (for pre-tracking events)
        /// </summary>
        Unknown,
        /// <summary>
        /// User set up TOTP authenticator - 'passkey': User registered a passkey - 'user_disabled': User disabled their own MFA - 'admin_removal': Admin removed MFA via backoffice - 'unknown': Method unknown (for pre-tracking events)
        /// </summary>
        UserDisabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod.AdminRemoval => "admin_removal",
                UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod.Passkey => "passkey",
                UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod.Totp => "totp",
                UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod.Unknown => "unknown",
                UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod.UserDisabled => "user_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod? ToEnum(string value)
        {
            return value switch
            {
                "admin_removal" => UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod.AdminRemoval,
                "passkey" => UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod.Passkey,
                "totp" => UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod.Totp,
                "unknown" => UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod.Unknown,
                "user_disabled" => UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemMethod.UserDisabled,
                _ => null,
            };
        }
    }
}