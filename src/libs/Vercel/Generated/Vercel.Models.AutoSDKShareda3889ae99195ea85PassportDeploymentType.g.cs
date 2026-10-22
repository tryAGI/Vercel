
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85PassportDeploymentType
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
    public static class AutoSDKShareda3889ae99195ea85PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85PassportDeploymentType.All => "all",
                AutoSDKShareda3889ae99195ea85PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareda3889ae99195ea85PassportDeploymentType.Preview => "preview",
                AutoSDKShareda3889ae99195ea85PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareda3889ae99195ea85PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareda3889ae99195ea85PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareda3889ae99195ea85PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareda3889ae99195ea85PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}