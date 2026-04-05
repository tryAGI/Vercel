
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2Type value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2Type.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "number" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant2Type.Number,
                _ => null,
            };
        }
    }
}