
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType
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
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}