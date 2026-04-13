
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockReason
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
    public static class UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}