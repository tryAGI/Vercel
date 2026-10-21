
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared19aed0f0e253807cPassportDeploymentType
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
    public static class AutoSDKShared19aed0f0e253807cPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared19aed0f0e253807cPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared19aed0f0e253807cPassportDeploymentType.All => "all",
                AutoSDKShared19aed0f0e253807cPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared19aed0f0e253807cPassportDeploymentType.Preview => "preview",
                AutoSDKShared19aed0f0e253807cPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared19aed0f0e253807cPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared19aed0f0e253807cPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared19aed0f0e253807cPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared19aed0f0e253807cPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared19aed0f0e253807cPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}