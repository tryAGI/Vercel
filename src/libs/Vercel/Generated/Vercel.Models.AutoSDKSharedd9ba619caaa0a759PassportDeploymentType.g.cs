
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759PassportDeploymentType
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
    public static class AutoSDKSharedd9ba619caaa0a759PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759PassportDeploymentType.All => "all",
                AutoSDKSharedd9ba619caaa0a759PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedd9ba619caaa0a759PassportDeploymentType.Preview => "preview",
                AutoSDKSharedd9ba619caaa0a759PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedd9ba619caaa0a759PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedd9ba619caaa0a759PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedd9ba619caaa0a759PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedd9ba619caaa0a759PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}