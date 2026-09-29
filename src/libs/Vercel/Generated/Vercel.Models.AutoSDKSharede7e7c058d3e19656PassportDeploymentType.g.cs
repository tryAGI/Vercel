
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede7e7c058d3e19656PassportDeploymentType
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
    public static class AutoSDKSharede7e7c058d3e19656PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede7e7c058d3e19656PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharede7e7c058d3e19656PassportDeploymentType.All => "all",
                AutoSDKSharede7e7c058d3e19656PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharede7e7c058d3e19656PassportDeploymentType.Preview => "preview",
                AutoSDKSharede7e7c058d3e19656PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede7e7c058d3e19656PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharede7e7c058d3e19656PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharede7e7c058d3e19656PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharede7e7c058d3e19656PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharede7e7c058d3e19656PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}