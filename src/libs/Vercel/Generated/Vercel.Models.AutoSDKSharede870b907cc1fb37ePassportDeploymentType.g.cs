
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37ePassportDeploymentType
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
    public static class AutoSDKSharede870b907cc1fb37ePassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37ePassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37ePassportDeploymentType.All => "all",
                AutoSDKSharede870b907cc1fb37ePassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharede870b907cc1fb37ePassportDeploymentType.Preview => "preview",
                AutoSDKSharede870b907cc1fb37ePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37ePassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharede870b907cc1fb37ePassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharede870b907cc1fb37ePassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharede870b907cc1fb37ePassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharede870b907cc1fb37ePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}