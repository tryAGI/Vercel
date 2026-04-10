
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockType
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
    public static class UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockType value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockType.Hard => "hard",
                UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockType.Soft => "soft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockType? ToEnum(string value)
        {
            return value switch
            {
                "hard" => UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockType.Hard,
                "soft" => UserEventPayloadVariant115NewOwnerFeatureBlocksMonitoringBlockType.Soft,
                _ => null,
            };
        }
    }
}