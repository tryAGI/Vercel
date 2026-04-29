
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason
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
    public static class UserEventPayloadVariant122NewOwnerFeatureBlocksImageOptimizationTransformationBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant122NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant122NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant122NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant122NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant122NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}