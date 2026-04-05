
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationResponseVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationConfiguration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationResponseVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant1Type value)
        {
            return value switch
            {
                GetConfigurationResponseVariant1Type.IntegrationConfiguration => "integration-configuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "integration-configuration" => GetConfigurationResponseVariant1Type.IntegrationConfiguration,
                _ => null,
            };
        }
    }
}