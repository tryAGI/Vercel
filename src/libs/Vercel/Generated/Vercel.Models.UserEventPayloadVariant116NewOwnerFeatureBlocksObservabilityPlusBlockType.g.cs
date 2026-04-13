
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockType
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
    public static class UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockType value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockType.Hard => "hard",
                UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockType.Soft => "soft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockType? ToEnum(string value)
        {
            return value switch
            {
                "hard" => UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockType.Hard,
                "soft" => UserEventPayloadVariant116NewOwnerFeatureBlocksObservabilityPlusBlockType.Soft,
                _ => null,
            };
        }
    }
}