
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddf9dcf09167540b7PassportDeploymentType
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
    public static class AutoSDKShareddf9dcf09167540b7PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddf9dcf09167540b7PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShareddf9dcf09167540b7PassportDeploymentType.All => "all",
                AutoSDKShareddf9dcf09167540b7PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShareddf9dcf09167540b7PassportDeploymentType.Preview => "preview",
                AutoSDKShareddf9dcf09167540b7PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddf9dcf09167540b7PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShareddf9dcf09167540b7PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShareddf9dcf09167540b7PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShareddf9dcf09167540b7PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShareddf9dcf09167540b7PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}