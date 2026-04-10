
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerFeatureBlocksDataCacheBlockReason
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
    public static class UserEventPayloadVariant115NewOwnerFeatureBlocksDataCacheBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerFeatureBlocksDataCacheBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerFeatureBlocksDataCacheBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant115NewOwnerFeatureBlocksDataCacheBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant115NewOwnerFeatureBlocksDataCacheBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerFeatureBlocksDataCacheBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant115NewOwnerFeatureBlocksDataCacheBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant115NewOwnerFeatureBlocksDataCacheBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant115NewOwnerFeatureBlocksDataCacheBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}