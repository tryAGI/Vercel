
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared718513e9caf47539PassportDeploymentType
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
    public static class AutoSDKShared718513e9caf47539PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared718513e9caf47539PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared718513e9caf47539PassportDeploymentType.All => "all",
                AutoSDKShared718513e9caf47539PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared718513e9caf47539PassportDeploymentType.Preview => "preview",
                AutoSDKShared718513e9caf47539PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared718513e9caf47539PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared718513e9caf47539PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared718513e9caf47539PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared718513e9caf47539PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared718513e9caf47539PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}