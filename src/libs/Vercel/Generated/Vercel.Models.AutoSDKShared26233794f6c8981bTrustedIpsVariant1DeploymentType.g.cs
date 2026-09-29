
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType
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
    public static class AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShared26233794f6c8981bTrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}