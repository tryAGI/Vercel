
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentType
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
    public static class AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentType.All => "all",
                AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentType.Preview => "preview",
                AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedd5e5cf9c62b8ab7fPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}