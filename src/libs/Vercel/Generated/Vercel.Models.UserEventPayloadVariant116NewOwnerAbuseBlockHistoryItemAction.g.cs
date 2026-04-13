
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
        /// <summary>
        /// 
        /// </summary>
        HardBlocked,
        /// <summary>
        /// 
        /// </summary>
        SoftBlocked,
        /// <summary>
        /// 
        /// </summary>
        Unblocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction.Blocked => "blocked",
                UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction.HardBlocked => "hard-blocked",
                UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction.SoftBlocked => "soft-blocked",
                UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction.Blocked,
                "hard-blocked" => UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction.HardBlocked,
                "soft-blocked" => UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction.SoftBlocked,
                "unblocked" => UserEventPayloadVariant116NewOwnerAbuseBlockHistoryItemAction.Unblocked,
                _ => null,
            };
        }
    }
}