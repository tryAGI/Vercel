
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType
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
    public static class AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShared8e5249ecd42210edTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}