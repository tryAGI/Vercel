
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerFeatureBlocksDataCacheBlockReason
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
    public static class UserEventPayloadVariant122NewOwnerFeatureBlocksDataCacheBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerFeatureBlocksDataCacheBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerFeatureBlocksDataCacheBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant122NewOwnerFeatureBlocksDataCacheBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant122NewOwnerFeatureBlocksDataCacheBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerFeatureBlocksDataCacheBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant122NewOwnerFeatureBlocksDataCacheBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant122NewOwnerFeatureBlocksDataCacheBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant122NewOwnerFeatureBlocksDataCacheBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}