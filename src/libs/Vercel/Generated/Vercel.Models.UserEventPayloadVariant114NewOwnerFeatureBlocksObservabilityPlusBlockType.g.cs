
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockType
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
    public static class UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockType value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockType.Hard => "hard",
                UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockType.Soft => "soft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockType? ToEnum(string value)
        {
            return value switch
            {
                "hard" => UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockType.Hard,
                "soft" => UserEventPayloadVariant114NewOwnerFeatureBlocksObservabilityPlusBlockType.Soft,
                _ => null,
            };
        }
    }
}