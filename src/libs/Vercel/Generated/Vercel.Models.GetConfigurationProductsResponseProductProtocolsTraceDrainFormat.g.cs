
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductProtocolsTraceDrainFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Proto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationProductsResponseProductProtocolsTraceDrainFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductProtocolsTraceDrainFormat value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductProtocolsTraceDrainFormat.Json => "json",
                GetConfigurationProductsResponseProductProtocolsTraceDrainFormat.Proto => "proto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductProtocolsTraceDrainFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => GetConfigurationProductsResponseProductProtocolsTraceDrainFormat.Json,
                "proto" => GetConfigurationProductsResponseProductProtocolsTraceDrainFormat.Proto,
                _ => null,
            };
        }
    }
}