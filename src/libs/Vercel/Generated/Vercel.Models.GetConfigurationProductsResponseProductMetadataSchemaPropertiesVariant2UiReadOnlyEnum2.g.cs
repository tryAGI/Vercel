
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum2
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
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum2 value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum2.Create => "create",
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum2.Create,
                "update" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant2UiReadOnlyEnum2.Update,
                _ => null,
            };
        }
    }
}