
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationResponseVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationConfiguration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationResponseVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant3Type value)
        {
            return value switch
            {
                GetConfigurationResponseVariant3Type.IntegrationConfiguration => "integration-configuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "integration-configuration" => GetConfigurationResponseVariant3Type.IntegrationConfiguration,
                _ => null,
            };
        }
    }
}