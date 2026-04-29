
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemAction
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
    public static class UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemAction value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemAction.Blocked => "blocked",
                UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemAction.HardBlocked => "hard-blocked",
                UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemAction.SoftBlocked => "soft-blocked",
                UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemAction.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemAction.Blocked,
                "hard-blocked" => UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemAction.HardBlocked,
                "soft-blocked" => UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemAction.SoftBlocked,
                "unblocked" => UserEventPayloadVariant122NewOwnerAbuseBlockHistoryItemAction.Unblocked,
                _ => null,
            };
        }
    }
}