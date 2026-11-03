
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8e5249ecd42210edPassportDeploymentType
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
    public static class AutoSDKShared8e5249ecd42210edPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8e5249ecd42210edPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared8e5249ecd42210edPassportDeploymentType.All => "all",
                AutoSDKShared8e5249ecd42210edPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared8e5249ecd42210edPassportDeploymentType.Preview => "preview",
                AutoSDKShared8e5249ecd42210edPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8e5249ecd42210edPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared8e5249ecd42210edPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared8e5249ecd42210edPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared8e5249ecd42210edPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared8e5249ecd42210edPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}