
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1BlockReason
    {
        /// <summary>
        /// 
        /// </summary>
        LimitsExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1BlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1BlockReason value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1BlockReason.LimitsExceeded => "limits_exceeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1BlockReason? ToEnum(string value)
        {
            return value switch
            {
                "limits_exceeded" => UserEventPayloadVariant116NewOwnerFeatureBlocksRedisVariant1BlockReason.LimitsExceeded,
                _ => null,
            };
        }
    }
}