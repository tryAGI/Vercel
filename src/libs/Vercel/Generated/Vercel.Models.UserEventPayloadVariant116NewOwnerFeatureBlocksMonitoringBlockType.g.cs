
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerFeatureBlocksMonitoringBlockType
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
    public static class UserEventPayloadVariant116NewOwnerFeatureBlocksMonitoringBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerFeatureBlocksMonitoringBlockType value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerFeatureBlocksMonitoringBlockType.Hard => "hard",
                UserEventPayloadVariant116NewOwnerFeatureBlocksMonitoringBlockType.Soft => "soft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerFeatureBlocksMonitoringBlockType? ToEnum(string value)
        {
            return value switch
            {
                "hard" => UserEventPayloadVariant116NewOwnerFeatureBlocksMonitoringBlockType.Hard,
                "soft" => UserEventPayloadVariant116NewOwnerFeatureBlocksMonitoringBlockType.Soft,
                _ => null,
            };
        }
    }
}