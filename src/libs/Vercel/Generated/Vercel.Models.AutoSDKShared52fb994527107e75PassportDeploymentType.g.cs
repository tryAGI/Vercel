
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared52fb994527107e75PassportDeploymentType
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
    public static class AutoSDKShared52fb994527107e75PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared52fb994527107e75PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared52fb994527107e75PassportDeploymentType.All => "all",
                AutoSDKShared52fb994527107e75PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared52fb994527107e75PassportDeploymentType.Preview => "preview",
                AutoSDKShared52fb994527107e75PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared52fb994527107e75PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared52fb994527107e75PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared52fb994527107e75PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared52fb994527107e75PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared52fb994527107e75PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}