
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentType
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
    public static class AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentType.All => "all",
                AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentType.Preview => "preview",
                AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareda2d284b091a73479PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}