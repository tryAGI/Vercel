
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcdc721d768aa23c0PassportDeploymentType
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
    public static class AutoSDKSharedcdc721d768aa23c0PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcdc721d768aa23c0PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedcdc721d768aa23c0PassportDeploymentType.All => "all",
                AutoSDKSharedcdc721d768aa23c0PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedcdc721d768aa23c0PassportDeploymentType.Preview => "preview",
                AutoSDKSharedcdc721d768aa23c0PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcdc721d768aa23c0PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedcdc721d768aa23c0PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedcdc721d768aa23c0PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedcdc721d768aa23c0PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedcdc721d768aa23c0PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}