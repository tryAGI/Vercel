
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentType
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
    public static class AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentType.All => "all",
                AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentType.Preview => "preview",
                AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharede0e23f3391031fa6SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}