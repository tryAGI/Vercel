
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4PassportDeploymentType
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
    public static class AutoSDKSharedfe1f84289679c6c4PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4PassportDeploymentType.All => "all",
                AutoSDKSharedfe1f84289679c6c4PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedfe1f84289679c6c4PassportDeploymentType.Preview => "preview",
                AutoSDKSharedfe1f84289679c6c4PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedfe1f84289679c6c4PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedfe1f84289679c6c4PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedfe1f84289679c6c4PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedfe1f84289679c6c4PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}