
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType
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
    public static class AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShareda223f19b9c37327fTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}