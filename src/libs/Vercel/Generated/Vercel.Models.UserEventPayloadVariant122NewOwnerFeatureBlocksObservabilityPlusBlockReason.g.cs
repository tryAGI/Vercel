
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockReason
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
    public static class UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}