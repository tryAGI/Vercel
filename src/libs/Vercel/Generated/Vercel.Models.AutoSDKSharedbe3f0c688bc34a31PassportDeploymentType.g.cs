
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbe3f0c688bc34a31PassportDeploymentType
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
    public static class AutoSDKSharedbe3f0c688bc34a31PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbe3f0c688bc34a31PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedbe3f0c688bc34a31PassportDeploymentType.All => "all",
                AutoSDKSharedbe3f0c688bc34a31PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedbe3f0c688bc34a31PassportDeploymentType.Preview => "preview",
                AutoSDKSharedbe3f0c688bc34a31PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbe3f0c688bc34a31PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedbe3f0c688bc34a31PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedbe3f0c688bc34a31PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedbe3f0c688bc34a31PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedbe3f0c688bc34a31PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}