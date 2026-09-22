
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType
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
    public static class AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}