
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39d2a20705988a8dPassportDeploymentType
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
    public static class AutoSDKShared39d2a20705988a8dPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39d2a20705988a8dPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared39d2a20705988a8dPassportDeploymentType.All => "all",
                AutoSDKShared39d2a20705988a8dPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared39d2a20705988a8dPassportDeploymentType.Preview => "preview",
                AutoSDKShared39d2a20705988a8dPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39d2a20705988a8dPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared39d2a20705988a8dPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared39d2a20705988a8dPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared39d2a20705988a8dPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared39d2a20705988a8dPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}