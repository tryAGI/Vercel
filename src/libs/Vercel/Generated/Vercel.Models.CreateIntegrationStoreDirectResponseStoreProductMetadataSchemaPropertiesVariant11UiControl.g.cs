
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiControl
    {
        /// <summary>
        /// 
        /// </summary>
        Domain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiControl value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiControl.Domain => "domain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiControl? ToEnum(string value)
        {
            return value switch
            {
                "domain" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11UiControl.Domain,
                _ => null,
            };
        }
    }
}