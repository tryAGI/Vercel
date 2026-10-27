
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentType
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        AllExceptCustomDomains,
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        ProdDeploymentUrlsAndAllPreviews,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentType.All => "all",
                AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentType.Preview => "preview",
                AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared01d42c494b5636bbSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}