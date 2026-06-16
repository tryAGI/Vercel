
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12UiControl
    {
        /// <summary>
        /// 
        /// </summary>
        GitNamespace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12UiControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12UiControl value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12UiControl.GitNamespace => "git-namespace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12UiControl? ToEnum(string value)
        {
            return value switch
            {
                "git-namespace" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12UiControl.GitNamespace,
                _ => null,
            };
        }
    }
}