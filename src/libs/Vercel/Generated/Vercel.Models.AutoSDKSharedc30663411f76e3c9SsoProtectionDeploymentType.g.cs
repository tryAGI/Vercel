
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentType
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
    public static class AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentType.All => "all",
                AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentType.Preview => "preview",
                AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedc30663411f76e3c9SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}