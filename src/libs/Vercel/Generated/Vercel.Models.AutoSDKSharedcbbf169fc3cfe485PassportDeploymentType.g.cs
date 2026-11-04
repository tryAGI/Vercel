
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcbbf169fc3cfe485PassportDeploymentType
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
    public static class AutoSDKSharedcbbf169fc3cfe485PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcbbf169fc3cfe485PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedcbbf169fc3cfe485PassportDeploymentType.All => "all",
                AutoSDKSharedcbbf169fc3cfe485PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedcbbf169fc3cfe485PassportDeploymentType.Preview => "preview",
                AutoSDKSharedcbbf169fc3cfe485PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcbbf169fc3cfe485PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedcbbf169fc3cfe485PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedcbbf169fc3cfe485PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedcbbf169fc3cfe485PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedcbbf169fc3cfe485PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}