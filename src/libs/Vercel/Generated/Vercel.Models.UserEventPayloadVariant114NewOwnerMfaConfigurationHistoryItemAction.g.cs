
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The action that occurred
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemAction
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
    public static class UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemAction value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemAction.Disabled => "disabled",
                UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemAction.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemAction.Disabled,
                "enabled" => UserEventPayloadVariant114NewOwnerMfaConfigurationHistoryItemAction.Enabled,
                _ => null,
            };
        }
    }
}