
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemAction
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
    public static class UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemAction value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemAction.Blocked => "blocked",
                UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemAction.HardBlocked => "hard-blocked",
                UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemAction.SoftBlocked => "soft-blocked",
                UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemAction.Unblocked => "unblocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemAction.Blocked,
                "hard-blocked" => UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemAction.HardBlocked,
                "soft-blocked" => UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemAction.SoftBlocked,
                "unblocked" => UserEventPayloadVariant114NewOwnerAbuseBlockHistoryItemAction.Unblocked,
                _ => null,
            };
        }
    }
}