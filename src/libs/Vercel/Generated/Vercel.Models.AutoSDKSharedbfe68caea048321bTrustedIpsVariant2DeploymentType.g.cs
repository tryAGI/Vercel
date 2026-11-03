
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType
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
    public static class AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKSharedbfe68caea048321bTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}