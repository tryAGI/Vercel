
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType
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
    public static class AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}