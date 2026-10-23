
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda8d456fca5d8a771PassportDeploymentType
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
    public static class AutoSDKShareda8d456fca5d8a771PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda8d456fca5d8a771PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShareda8d456fca5d8a771PassportDeploymentType.All => "all",
                AutoSDKShareda8d456fca5d8a771PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareda8d456fca5d8a771PassportDeploymentType.Preview => "preview",
                AutoSDKShareda8d456fca5d8a771PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda8d456fca5d8a771PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareda8d456fca5d8a771PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareda8d456fca5d8a771PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareda8d456fca5d8a771PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareda8d456fca5d8a771PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}