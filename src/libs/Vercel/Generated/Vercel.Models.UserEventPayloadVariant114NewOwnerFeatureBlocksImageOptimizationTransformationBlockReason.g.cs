
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason
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
    public static class UserEventPayloadVariant114NewOwnerFeatureBlocksImageOptimizationTransformationBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant114NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant114NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant114NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant114NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant114NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}