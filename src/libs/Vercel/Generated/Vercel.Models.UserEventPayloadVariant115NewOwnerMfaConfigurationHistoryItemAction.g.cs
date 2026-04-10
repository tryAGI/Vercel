
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The action that occurred
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemAction
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
    public static class UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemAction value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemAction.Disabled => "disabled",
                UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemAction.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemAction.Disabled,
                "enabled" => UserEventPayloadVariant115NewOwnerMfaConfigurationHistoryItemAction.Enabled,
                _ => null,
            };
        }
    }
}