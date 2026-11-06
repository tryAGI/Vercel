
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda2d284b091a73479PassportDeploymentType
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
    public static class AutoSDKShareda2d284b091a73479PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda2d284b091a73479PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShareda2d284b091a73479PassportDeploymentType.All => "all",
                AutoSDKShareda2d284b091a73479PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareda2d284b091a73479PassportDeploymentType.Preview => "preview",
                AutoSDKShareda2d284b091a73479PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda2d284b091a73479PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareda2d284b091a73479PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareda2d284b091a73479PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareda2d284b091a73479PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareda2d284b091a73479PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}