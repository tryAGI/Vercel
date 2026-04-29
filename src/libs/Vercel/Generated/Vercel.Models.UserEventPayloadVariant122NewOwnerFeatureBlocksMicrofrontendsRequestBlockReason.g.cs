
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason
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
    public static class UserEventPayloadVariant122NewOwnerFeatureBlocksMicrofrontendsRequestBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant122NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.HardBlocked => "hard_blocked",
                UserEventPayloadVariant122NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant122NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant122NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.HardBlocked,
                "limits_exceeded" => UserEventPayloadVariant122NewOwnerFeatureBlocksMicrofrontendsRequestBlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}