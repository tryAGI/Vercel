
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProvider
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
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProvider value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProvider.Bitbucket => "bitbucket",
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProvider.Github => "github",
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProvider.Bitbucket,
                "github" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProvider.Github,
                "gitlab" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant11GitProvider.Gitlab,
                _ => null,
            };
        }
    }
}