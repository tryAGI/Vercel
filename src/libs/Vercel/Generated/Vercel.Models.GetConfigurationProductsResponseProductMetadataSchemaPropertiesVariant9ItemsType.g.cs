
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9ItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9ItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9ItemsType value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9ItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9ItemsType? ToEnum(string value)
        {
            return value switch
            {
                "string" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant9ItemsType.String,
                _ => null,
            };
        }
    }
}