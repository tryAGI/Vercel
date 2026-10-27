
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdPassportDeploymentType
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
    public static class AutoSDKSharedc9c79e81839bbccdPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdPassportDeploymentType.All => "all",
                AutoSDKSharedc9c79e81839bbccdPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedc9c79e81839bbccdPassportDeploymentType.Preview => "preview",
                AutoSDKSharedc9c79e81839bbccdPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedc9c79e81839bbccdPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedc9c79e81839bbccdPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedc9c79e81839bbccdPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedc9c79e81839bbccdPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}