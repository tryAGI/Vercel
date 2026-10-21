
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentType
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
    public static class AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentType.All => "all",
                AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentType.Preview => "preview",
                AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared0d52d5fc16437df8SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}