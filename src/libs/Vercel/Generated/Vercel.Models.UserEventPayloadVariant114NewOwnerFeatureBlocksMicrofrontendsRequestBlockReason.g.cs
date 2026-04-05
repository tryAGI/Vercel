
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason
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
    public static class UserEventPayloadVariant114NewOwnerFeatureBlocksMicrofrontendsRequestBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant114NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant114NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant114NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant114NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant114NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}