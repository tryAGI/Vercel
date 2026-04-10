
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalyticsBlockReason
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
    public static class UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalyticsBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalyticsBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalyticsBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalyticsBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalyticsBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalyticsBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalyticsBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalyticsBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant115NewOwnerFeatureBlocksWebAnalyticsBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}