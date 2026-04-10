
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason
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
    public static class UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformationBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant115NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}