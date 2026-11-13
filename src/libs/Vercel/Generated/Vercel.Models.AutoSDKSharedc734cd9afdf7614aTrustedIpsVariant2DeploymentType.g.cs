
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType
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
    public static class AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}