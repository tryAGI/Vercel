
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerFeatureBlocksMonitoringBlockType
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
    public static class UserEventPayloadVariant114NewOwnerFeatureBlocksMonitoringBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerFeatureBlocksMonitoringBlockType value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerFeatureBlocksMonitoringBlockType.Hard => "hard",
                UserEventPayloadVariant114NewOwnerFeatureBlocksMonitoringBlockType.Soft => "soft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerFeatureBlocksMonitoringBlockType? ToEnum(string value)
        {
            return value switch
            {
                "hard" => UserEventPayloadVariant114NewOwnerFeatureBlocksMonitoringBlockType.Hard,
                "soft" => UserEventPayloadVariant114NewOwnerFeatureBlocksMonitoringBlockType.Soft,
                _ => null,
            };
        }
    }
}