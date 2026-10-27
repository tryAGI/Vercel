
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentType
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
    public static class AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentType.All => "all",
                AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentType.Preview => "preview",
                AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedfc5823c22a1eaa2bPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}