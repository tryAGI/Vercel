
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bPassportDeploymentType
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
    public static class AutoSDKShared26233794f6c8981bPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bPassportDeploymentType.All => "all",
                AutoSDKShared26233794f6c8981bPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared26233794f6c8981bPassportDeploymentType.Preview => "preview",
                AutoSDKShared26233794f6c8981bPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared26233794f6c8981bPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared26233794f6c8981bPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared26233794f6c8981bPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared26233794f6c8981bPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}