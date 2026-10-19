
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType
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
    public static class AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShared94b26a5607c7a373TrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}