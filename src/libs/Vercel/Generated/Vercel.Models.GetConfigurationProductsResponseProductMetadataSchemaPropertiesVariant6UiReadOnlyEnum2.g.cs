
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiReadOnlyEnum2
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
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiReadOnlyEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiReadOnlyEnum2 value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiReadOnlyEnum2.Create => "create",
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiReadOnlyEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiReadOnlyEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiReadOnlyEnum2.Create,
                "update" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiReadOnlyEnum2.Update,
                _ => null,
            };
        }
    }
}