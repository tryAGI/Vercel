
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockReason
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
    public static class UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}