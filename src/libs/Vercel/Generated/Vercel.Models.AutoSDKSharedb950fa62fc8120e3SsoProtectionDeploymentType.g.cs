
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType.All => "all",
                AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType.Preview => "preview",
                AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedb950fa62fc8120e3SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}