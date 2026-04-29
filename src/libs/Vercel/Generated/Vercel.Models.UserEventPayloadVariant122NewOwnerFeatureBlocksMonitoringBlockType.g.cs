
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerFeatureBlocksMonitoringBlockType
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
    public static class UserEventPayloadVariant122NewOwnerFeatureBlocksMonitoringBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerFeatureBlocksMonitoringBlockType value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerFeatureBlocksMonitoringBlockType.Hard => "hard",
                UserEventPayloadVariant122NewOwnerFeatureBlocksMonitoringBlockType.Soft => "soft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerFeatureBlocksMonitoringBlockType? ToEnum(string value)
        {
            return value switch
            {
                "hard" => UserEventPayloadVariant122NewOwnerFeatureBlocksMonitoringBlockType.Hard,
                "soft" => UserEventPayloadVariant122NewOwnerFeatureBlocksMonitoringBlockType.Soft,
                _ => null,
            };
        }
    }
}