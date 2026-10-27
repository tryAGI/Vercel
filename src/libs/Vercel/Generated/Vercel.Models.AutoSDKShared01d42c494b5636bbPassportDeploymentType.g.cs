
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared01d42c494b5636bbPassportDeploymentType
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
    public static class AutoSDKShared01d42c494b5636bbPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared01d42c494b5636bbPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared01d42c494b5636bbPassportDeploymentType.All => "all",
                AutoSDKShared01d42c494b5636bbPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared01d42c494b5636bbPassportDeploymentType.Preview => "preview",
                AutoSDKShared01d42c494b5636bbPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared01d42c494b5636bbPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared01d42c494b5636bbPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared01d42c494b5636bbPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared01d42c494b5636bbPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared01d42c494b5636bbPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}