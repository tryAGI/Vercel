
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionDisabledEnum2
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
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionDisabledEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionDisabledEnum2 value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionDisabledEnum2.Create => "create",
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionDisabledEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionDisabledEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionDisabledEnum2.Create,
                "update" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant6UiOptionDisabledEnum2.Update,
                _ => null,
            };
        }
    }
}