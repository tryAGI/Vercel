
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentType
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
    public static class AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentType.All => "all",
                AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentType.Preview => "preview",
                AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareda3889ae99195ea85SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}