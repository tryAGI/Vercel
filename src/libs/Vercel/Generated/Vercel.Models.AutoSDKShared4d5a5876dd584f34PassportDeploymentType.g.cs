
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4d5a5876dd584f34PassportDeploymentType
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
    public static class AutoSDKShared4d5a5876dd584f34PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4d5a5876dd584f34PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared4d5a5876dd584f34PassportDeploymentType.All => "all",
                AutoSDKShared4d5a5876dd584f34PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared4d5a5876dd584f34PassportDeploymentType.Preview => "preview",
                AutoSDKShared4d5a5876dd584f34PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4d5a5876dd584f34PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared4d5a5876dd584f34PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared4d5a5876dd584f34PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared4d5a5876dd584f34PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared4d5a5876dd584f34PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}