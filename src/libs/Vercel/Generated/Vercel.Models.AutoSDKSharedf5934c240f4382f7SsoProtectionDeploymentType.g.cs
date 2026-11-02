
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType
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
    public static class AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType.All => "all",
                AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType.Preview => "preview",
                AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedf5934c240f4382f7SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}