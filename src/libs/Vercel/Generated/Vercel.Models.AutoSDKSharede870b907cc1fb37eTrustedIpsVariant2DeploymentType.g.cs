
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType
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
    public static class AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKSharede870b907cc1fb37eTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}