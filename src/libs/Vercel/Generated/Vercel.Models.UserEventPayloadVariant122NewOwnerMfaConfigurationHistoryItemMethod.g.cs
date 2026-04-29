
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Method used for the state change - 'totp': User set up TOTP authenticator - 'passkey': User registered a passkey - 'user_disabled': User disabled their own MFA - 'admin_removal': Admin removed MFA via backoffice - 'unknown': Method unknown (for pre-tracking events)
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod
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
    public static class UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod.AdminRemoval => "admin_removal",
                UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod.Passkey => "passkey",
                UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod.Totp => "totp",
                UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod.Unknown => "unknown",
                UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod.UserDisabled => "user_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod? ToEnum(string value)
        {
            return value switch
            {
                "admin_removal" => UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod.AdminRemoval,
                "passkey" => UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod.Passkey,
                "totp" => UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod.Totp,
                "unknown" => UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod.Unknown,
                "user_disabled" => UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemMethod.UserDisabled,
                _ => null,
            };
        }
    }
}