
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerFeatureBlocksSourceImagesBlockReason
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
    public static class UserEventPayloadVariant114NewOwnerFeatureBlocksSourceImagesBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerFeatureBlocksSourceImagesBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerFeatureBlocksSourceImagesBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant114NewOwnerFeatureBlocksSourceImagesBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant114NewOwnerFeatureBlocksSourceImagesBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerFeatureBlocksSourceImagesBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant114NewOwnerFeatureBlocksSourceImagesBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant114NewOwnerFeatureBlocksSourceImagesBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant114NewOwnerFeatureBlocksSourceImagesBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}