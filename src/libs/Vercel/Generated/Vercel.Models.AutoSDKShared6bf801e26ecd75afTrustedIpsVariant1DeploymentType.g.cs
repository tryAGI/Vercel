
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType
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
    public static class AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType.All => "all",
                AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType.Preview => "preview",
                AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}