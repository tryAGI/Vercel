
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbPassportDeploymentType
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
    public static class AutoSDKSharedba7c6b12ca723bfbPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbPassportDeploymentType.All => "all",
                AutoSDKSharedba7c6b12ca723bfbPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedba7c6b12ca723bfbPassportDeploymentType.Preview => "preview",
                AutoSDKSharedba7c6b12ca723bfbPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedba7c6b12ca723bfbPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedba7c6b12ca723bfbPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedba7c6b12ca723bfbPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedba7c6b12ca723bfbPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}