
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationsResponseVariant2ItemType
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationConfiguration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationsResponseVariant2ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsResponseVariant2ItemType value)
        {
            return value switch
            {
                GetConfigurationsResponseVariant2ItemType.IntegrationConfiguration => "integration-configuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsResponseVariant2ItemType? ToEnum(string value)
        {
            return value switch
            {
                "integration-configuration" => GetConfigurationsResponseVariant2ItemType.IntegrationConfiguration,
                _ => null,
            };
        }
    }
}