
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationResponseVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationConfiguration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationResponseVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant2Type value)
        {
            return value switch
            {
                GetConfigurationResponseVariant2Type.IntegrationConfiguration => "integration-configuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "integration-configuration" => GetConfigurationResponseVariant2Type.IntegrationConfiguration,
                _ => null,
            };
        }
    }
}