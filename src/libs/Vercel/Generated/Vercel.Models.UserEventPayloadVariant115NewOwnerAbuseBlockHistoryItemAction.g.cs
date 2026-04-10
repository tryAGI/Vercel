
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemAction
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
    public static class UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemAction value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemAction.Blocked => "blocked",
                UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemAction.HardBlocked => "hard-blocked",
                UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemAction.SoftBlocked => "soft-blocked",
                UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemAction.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemAction.Blocked,
                "hard-blocked" => UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemAction.HardBlocked,
                "soft-blocked" => UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemAction.SoftBlocked,
                "unblocked" => UserEventPayloadVariant115NewOwnerAbuseBlockHistoryItemAction.Unblocked,
                _ => null,
            };
        }
    }
}