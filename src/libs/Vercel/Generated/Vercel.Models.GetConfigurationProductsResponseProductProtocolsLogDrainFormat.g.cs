
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductProtocolsLogDrainFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Ndjson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationProductsResponseProductProtocolsLogDrainFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductProtocolsLogDrainFormat value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductProtocolsLogDrainFormat.Json => "json",
                GetConfigurationProductsResponseProductProtocolsLogDrainFormat.Ndjson => "ndjson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductProtocolsLogDrainFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetConfigurationProductsResponseProductProtocolsLogDrainFormat.Json,
                "ndjson" => GetConfigurationProductsResponseProductProtocolsLogDrainFormat.Ndjson,
                _ => null,
            };
        }
    }
}