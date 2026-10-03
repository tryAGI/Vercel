
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentType
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
    public static class AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentType.All => "all",
                AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentType.Preview => "preview",
                AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared8d2a365a5da335dfSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}