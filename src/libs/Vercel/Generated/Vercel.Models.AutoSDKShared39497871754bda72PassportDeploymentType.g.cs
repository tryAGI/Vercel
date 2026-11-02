
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39497871754bda72PassportDeploymentType
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
    public static class AutoSDKShared39497871754bda72PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39497871754bda72PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared39497871754bda72PassportDeploymentType.All => "all",
                AutoSDKShared39497871754bda72PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared39497871754bda72PassportDeploymentType.Preview => "preview",
                AutoSDKShared39497871754bda72PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39497871754bda72PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared39497871754bda72PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared39497871754bda72PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared39497871754bda72PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared39497871754bda72PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}