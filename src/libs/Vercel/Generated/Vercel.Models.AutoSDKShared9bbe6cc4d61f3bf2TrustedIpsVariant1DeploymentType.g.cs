
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}