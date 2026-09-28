
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fPassportDeploymentType
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
    public static class AutoSDKShareda223f19b9c37327fPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fPassportDeploymentType.All => "all",
                AutoSDKShareda223f19b9c37327fPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareda223f19b9c37327fPassportDeploymentType.Preview => "preview",
                AutoSDKShareda223f19b9c37327fPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareda223f19b9c37327fPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareda223f19b9c37327fPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareda223f19b9c37327fPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareda223f19b9c37327fPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}