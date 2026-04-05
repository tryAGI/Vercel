
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant5UiOptionDisabledEnum2
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
    public static class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant5UiOptionDisabledEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant5UiOptionDisabledEnum2 value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant5UiOptionDisabledEnum2.Create => "create",
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant5UiOptionDisabledEnum2.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant5UiOptionDisabledEnum2? ToEnum(string value)
        {
            return value switch
            {
                "create" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant5UiOptionDisabledEnum2.Create,
                "update" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant5UiOptionDisabledEnum2.Update,
                _ => null,
            };
        }
    }
}