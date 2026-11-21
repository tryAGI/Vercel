
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType
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
    public static class AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}