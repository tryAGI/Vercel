
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373PassportDeploymentType
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
    public static class AutoSDKShared94b26a5607c7a373PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373PassportDeploymentType.All => "all",
                AutoSDKShared94b26a5607c7a373PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared94b26a5607c7a373PassportDeploymentType.Preview => "preview",
                AutoSDKShared94b26a5607c7a373PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared94b26a5607c7a373PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared94b26a5607c7a373PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared94b26a5607c7a373PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared94b26a5607c7a373PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}