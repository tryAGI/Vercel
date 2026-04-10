
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Method used for the state change - 'totp': User set up TOTP authenticator - 'passkey': User registered a passkey - 'user_disabled': User disabled their own MFA - 'admin_removal': Admin removed MFA via backoffice - 'unknown': Method unknown (for pre-tracking events)
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod
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
    public static class UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod.AdminRemoval => "admin_removal",
                UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod.Passkey => "passkey",
                UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod.Totp => "totp",
                UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod.Unknown => "unknown",
                UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod.UserDisabled => "user_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod? ToEnum(string value)
        {
            return value switch
            {
                "admin_removal" => UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod.AdminRemoval,
                "passkey" => UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod.Passkey,
                "totp" => UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod.Totp,
                "unknown" => UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod.Unknown,
                "user_disabled" => UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemMethod.UserDisabled,
                _ => null,
            };
        }
    }
}