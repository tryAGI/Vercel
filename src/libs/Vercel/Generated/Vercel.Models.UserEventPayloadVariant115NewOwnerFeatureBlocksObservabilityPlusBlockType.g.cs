
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockType
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
    public static class UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockType value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockType.Hard => "hard",
                UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockType.Soft => "soft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockType? ToEnum(string value)
        {
            return value switch
            {
                "hard" => UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockType.Hard,
                "soft" => UserEventPayloadVariant115NewOwnerFeatureBlocksObservabilityPlusBlockType.Soft,
                _ => null,
            };
        }
    }
}