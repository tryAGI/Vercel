
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason
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
    public static class UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformationBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant116NewOwnerFeatureBlocksImageOptimizationTransformationBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}