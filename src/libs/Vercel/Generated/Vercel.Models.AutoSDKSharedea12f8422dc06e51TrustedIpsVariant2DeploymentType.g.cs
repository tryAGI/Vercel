
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType
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
    public static class AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKSharedea12f8422dc06e51TrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}