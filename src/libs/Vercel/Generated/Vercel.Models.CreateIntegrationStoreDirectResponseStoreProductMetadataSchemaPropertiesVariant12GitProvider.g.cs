
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12GitProvider
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
    public static class CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12GitProvider value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12GitProvider.Bitbucket => "bitbucket",
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12GitProvider.Github => "github",
                CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12GitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12GitProvider.Bitbucket,
                "github" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12GitProvider.Github,
                "gitlab" => CreateIntegrationStoreDirectResponseStoreProductMetadataSchemaPropertiesVariant12GitProvider.Gitlab,
                _ => null,
            };
        }
    }
}