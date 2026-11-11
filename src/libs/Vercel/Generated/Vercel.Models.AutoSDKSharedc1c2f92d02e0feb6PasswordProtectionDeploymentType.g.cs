
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentType
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
    public static class AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentType.All => "all",
                AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentType.Preview => "preview",
                AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedc1c2f92d02e0feb6PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}