
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentType
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
    public static class AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentType.All => "all",
                AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentType.Preview => "preview",
                AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareda3889ae99195ea85PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}