
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f99f1735f329c6cPassportDeploymentType
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
    public static class AutoSDKShared0f99f1735f329c6cPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f99f1735f329c6cPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared0f99f1735f329c6cPassportDeploymentType.All => "all",
                AutoSDKShared0f99f1735f329c6cPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared0f99f1735f329c6cPassportDeploymentType.Preview => "preview",
                AutoSDKShared0f99f1735f329c6cPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f99f1735f329c6cPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared0f99f1735f329c6cPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared0f99f1735f329c6cPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared0f99f1735f329c6cPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared0f99f1735f329c6cPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}