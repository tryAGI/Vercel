
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType
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
    public static class AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShared0f99f1735f329c6cTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}