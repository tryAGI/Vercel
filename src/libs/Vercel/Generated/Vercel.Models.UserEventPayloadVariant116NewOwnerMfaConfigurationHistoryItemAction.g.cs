
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The action that occurred
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemAction
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemAction value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemAction.Disabled => "disabled",
                UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemAction.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemAction.Disabled,
                "enabled" => UserEventPayloadVariant116NewOwnerMfaConfigurationHistoryItemAction.Enabled,
                _ => null,
            };
        }
    }
}