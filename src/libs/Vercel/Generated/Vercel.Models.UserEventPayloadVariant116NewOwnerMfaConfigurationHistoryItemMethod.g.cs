
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Method used for the state change - 'totp': User set up TOTP authenticator - 'passkey': User registered a passkey - 'user_disabled': User disabled their own MFA - 'admin_removal': Admin removed MFA via backoffice - 'unknown': Method unknown (for pre-tracking events)
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod
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
    public static class UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod.AdminRemoval => "admin_removal",
                UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod.Passkey => "passkey",
                UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod.Totp => "totp",
                UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod.Unknown => "unknown",
                UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod.UserDisabled => "user_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod? ToEnum(string value)
        {
            return value switch
            {
                "admin_removal" => UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod.AdminRemoval,
                "passkey" => UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod.Passkey,
                "totp" => UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod.Totp,
                "unknown" => UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod.Unknown,
                "user_disabled" => UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemMethod.UserDisabled,
                _ => null,
            };
        }
    }
}