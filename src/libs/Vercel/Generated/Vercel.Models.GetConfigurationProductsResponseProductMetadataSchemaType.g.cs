
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationProductsResponseProductMetadataSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaType value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "object" => GetConfigurationProductsResponseProductMetadataSchemaType.Object,
                _ => null,
            };
        }
    }
}