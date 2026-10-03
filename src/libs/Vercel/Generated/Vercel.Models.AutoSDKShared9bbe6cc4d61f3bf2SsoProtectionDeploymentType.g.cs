
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentType
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentType.All => "all",
                AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentType.Preview => "preview",
                AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared9bbe6cc4d61f3bf2SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}