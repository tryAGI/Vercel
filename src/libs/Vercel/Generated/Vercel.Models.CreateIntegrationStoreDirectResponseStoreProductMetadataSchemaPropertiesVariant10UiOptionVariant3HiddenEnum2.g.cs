
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiOptionVariant3HiddenEnum2
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
    public static class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiOptionVariant3HiddenEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiOptionVariant3HiddenEnum2 value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiOptionVariant3HiddenEnum2.Create => "create",
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiOptionVariant3HiddenEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiOptionVariant3HiddenEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiOptionVariant3HiddenEnum2.Create,
                "update" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant10UiOptionVariant3HiddenEnum2.Update,
                _ => null,
            };
        }
    }
}