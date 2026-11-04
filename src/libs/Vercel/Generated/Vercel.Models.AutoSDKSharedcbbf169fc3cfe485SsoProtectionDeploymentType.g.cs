
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentType
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
    public static class AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentType.All => "all",
                AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentType.Preview => "preview",
                AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedcbbf169fc3cfe485SsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}