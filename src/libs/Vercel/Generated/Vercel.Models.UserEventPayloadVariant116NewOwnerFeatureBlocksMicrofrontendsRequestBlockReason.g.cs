
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason
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
    public static class UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequestBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant116NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}