
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6da23cf13a2bd202PassportDeploymentType
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
    public static class AutoSDKShared6da23cf13a2bd202PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6da23cf13a2bd202PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared6da23cf13a2bd202PassportDeploymentType.All => "all",
                AutoSDKShared6da23cf13a2bd202PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared6da23cf13a2bd202PassportDeploymentType.Preview => "preview",
                AutoSDKShared6da23cf13a2bd202PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6da23cf13a2bd202PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared6da23cf13a2bd202PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared6da23cf13a2bd202PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared6da23cf13a2bd202PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared6da23cf13a2bd202PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}