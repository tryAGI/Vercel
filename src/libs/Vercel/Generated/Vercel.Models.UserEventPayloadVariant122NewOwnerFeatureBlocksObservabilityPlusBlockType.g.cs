
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Hard,
        /// <summary>
        /// 
        /// </summary>
        Soft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockType value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockType.Hard => "hard",
                UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockType.Soft => "soft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockType? ToEnum(string value)
        {
            return value switch
            {
                "hard" => UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockType.Hard,
                "soft" => UserEventPayloadVariant122NewOwnerFeatureBlocksObservabilityPlusBlockType.Soft,
                _ => null,
            };
        }
    }
}