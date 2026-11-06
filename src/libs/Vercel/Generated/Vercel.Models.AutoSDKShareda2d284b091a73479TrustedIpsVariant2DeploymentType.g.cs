
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType
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
    public static class AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShareda2d284b091a73479TrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}