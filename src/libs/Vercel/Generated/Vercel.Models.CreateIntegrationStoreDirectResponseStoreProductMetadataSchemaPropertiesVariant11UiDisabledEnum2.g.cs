
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiDisabledEnum2
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
    public static class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiDisabledEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiDisabledEnum2 value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiDisabledEnum2.Create => "create",
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiDisabledEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiDisabledEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiDisabledEnum2.Create,
                "update" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiDisabledEnum2.Update,
                _ => null,
            };
        }
    }
}