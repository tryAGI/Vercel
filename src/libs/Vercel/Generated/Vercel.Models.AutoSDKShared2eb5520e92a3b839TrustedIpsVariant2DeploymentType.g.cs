
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType
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
    public static class AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType.All => "all",
                AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType.Preview => "preview",
                AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShared2eb5520e92a3b839TrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}