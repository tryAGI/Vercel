
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentType
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
    public static class AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentType.All => "all",
                AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentType.Preview => "preview",
                AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareddf9dcf09167540b7SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}