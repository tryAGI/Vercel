
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum2
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
    public static class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum2 value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum2.Create => "create",
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum2.Create,
                "update" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2UiHiddenEnum2.Update,
                _ => null,
            };
        }
    }
}