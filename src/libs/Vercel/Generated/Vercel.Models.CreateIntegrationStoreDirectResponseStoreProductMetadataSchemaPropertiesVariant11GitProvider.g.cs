
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11GitProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11GitProvider value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11GitProvider.Bitbucket => "bitbucket",
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11GitProvider.Github => "github",
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11GitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11GitProvider.Bitbucket,
                "github" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11GitProvider.Github,
                "gitlab" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant11GitProvider.Gitlab,
                _ => null,
            };
        }
    }
}