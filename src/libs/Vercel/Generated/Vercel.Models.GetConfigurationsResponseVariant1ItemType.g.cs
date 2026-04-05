
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationsResponseVariant1ItemType
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationConfiguration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationsResponseVariant1ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationsResponseVariant1ItemType value)
        {
            return value switch
            {
                GetConfigurationsResponseVariant1ItemType.IntegrationConfiguration => "integration-configuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationsResponseVariant1ItemType? ToEnum(string value)
        {
            return value switch
            {
                "integration-configuration" => GetConfigurationsResponseVariant1ItemType.IntegrationConfiguration,
                _ => null,
            };
        }
    }
}