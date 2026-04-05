
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerFeatureBlocksWebAnalyticsBlockReason
    {
        /// <summary>
        /// 
        /// </summary>
        AdminOverride,
        /// <summary>
        /// 
        /// </summary>
        HardBlocked,
        /// <summary>
        /// 
        /// </summary>
        LimitsExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant114NewOwnerFeatureBlocksWebAnalyticsBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerFeatureBlocksWebAnalyticsBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerFeatureBlocksWebAnalyticsBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant114NewOwnerFeatureBlocksWebAnalyticsBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant114NewOwnerFeatureBlocksWebAnalyticsBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerFeatureBlocksWebAnalyticsBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant114NewOwnerFeatureBlocksWebAnalyticsBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant114NewOwnerFeatureBlocksWebAnalyticsBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant114NewOwnerFeatureBlocksWebAnalyticsBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}