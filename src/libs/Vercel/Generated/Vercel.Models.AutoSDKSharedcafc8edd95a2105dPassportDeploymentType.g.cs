
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcafc8edd95a2105dPassportDeploymentType
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
    public static class AutoSDKSharedcafc8edd95a2105dPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcafc8edd95a2105dPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedcafc8edd95a2105dPassportDeploymentType.All => "all",
                AutoSDKSharedcafc8edd95a2105dPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedcafc8edd95a2105dPassportDeploymentType.Preview => "preview",
                AutoSDKSharedcafc8edd95a2105dPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcafc8edd95a2105dPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedcafc8edd95a2105dPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedcafc8edd95a2105dPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedcafc8edd95a2105dPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedcafc8edd95a2105dPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}