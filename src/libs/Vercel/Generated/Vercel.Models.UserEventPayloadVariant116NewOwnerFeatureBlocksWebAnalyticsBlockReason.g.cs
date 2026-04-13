
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalyticsBlockReason
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
    public static class UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalyticsBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalyticsBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalyticsBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalyticsBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalyticsBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalyticsBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalyticsBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalyticsBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant116NewOwnerFeatureBlocksWebAnalyticsBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}