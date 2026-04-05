
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiHiddenEnum2
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiHiddenEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiHiddenEnum2 value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiHiddenEnum2.Create => "create",
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiHiddenEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiHiddenEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiHiddenEnum2.Create,
                "update" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiHiddenEnum2.Update,
                _ => null,
            };
        }
    }
}