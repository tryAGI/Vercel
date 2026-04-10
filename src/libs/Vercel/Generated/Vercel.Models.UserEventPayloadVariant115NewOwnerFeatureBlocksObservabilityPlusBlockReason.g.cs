
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockReason
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
    public static class UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}