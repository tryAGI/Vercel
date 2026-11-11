
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentType
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
    public static class AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentType.All => "all",
                AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentType.Preview => "preview",
                AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedc1c2f92d02e0feb6PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}