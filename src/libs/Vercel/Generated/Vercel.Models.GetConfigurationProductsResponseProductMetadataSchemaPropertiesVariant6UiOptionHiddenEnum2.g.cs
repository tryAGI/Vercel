
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionHiddenEnum2
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
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionHiddenEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionHiddenEnum2 value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionHiddenEnum2.Create => "create",
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionHiddenEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionHiddenEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionHiddenEnum2.Create,
                "update" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionHiddenEnum2.Update,
                _ => null,
            };
        }
    }
}