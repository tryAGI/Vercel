
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The action that occurred
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemAction
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
    public static class UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemAction value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemAction.Disabled => "disabled",
                UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemAction.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemAction.Disabled,
                "enabled" => UserEventPayloadVariant122NewOwnerMfaConfigurationHistoryItemAction.Enabled,
                _ => null,
            };
        }
    }
}