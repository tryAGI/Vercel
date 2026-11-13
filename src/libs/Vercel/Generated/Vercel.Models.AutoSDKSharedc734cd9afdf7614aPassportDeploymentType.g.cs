
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc734cd9afdf7614aPassportDeploymentType
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
    public static class AutoSDKSharedc734cd9afdf7614aPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc734cd9afdf7614aPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedc734cd9afdf7614aPassportDeploymentType.All => "all",
                AutoSDKSharedc734cd9afdf7614aPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedc734cd9afdf7614aPassportDeploymentType.Preview => "preview",
                AutoSDKSharedc734cd9afdf7614aPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc734cd9afdf7614aPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedc734cd9afdf7614aPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedc734cd9afdf7614aPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedc734cd9afdf7614aPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedc734cd9afdf7614aPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}