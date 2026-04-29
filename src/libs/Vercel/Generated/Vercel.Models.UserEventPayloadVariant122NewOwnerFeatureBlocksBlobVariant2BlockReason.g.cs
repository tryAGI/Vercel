
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant2BlockReason
    {
        /// <summary>
        /// 
        /// </summary>
        AdminOverride,
        /// <summary>
        /// 
        /// </summary>
        HardBlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant2BlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant2BlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant2BlockReason.AdminOverride => "admin_override",
                UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant2BlockReason.HardBlocked => "hard_blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant2BlockReason? ToEnum(string value)
        {
            return value switch
            {
                "admin_override" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant2BlockReason.AdminOverride,
                "hard_blocked" => UserEventPayloadVariant122NewOwnerFeatureBlocksBlobVariant2BlockReason.HardBlocked,
                _ => null,
            };
        }
    }
}