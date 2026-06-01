
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant12GitProvider
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
    public static class GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant12GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant12GitProvider value)
        {
            return value switch
            {
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant12GitProvider.Bitbucket => "bitbucket",
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant12GitProvider.Github => "github",
                GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant12GitProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant12GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant12GitProvider.Bitbucket,
                "github" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant12GitProvider.Github,
                "gitlab" => GetConfigurationProductsResponseProductMetadataSchemaPropertiesVariant12GitProvider.Gitlab,
                _ => null,
            };
        }
    }
}