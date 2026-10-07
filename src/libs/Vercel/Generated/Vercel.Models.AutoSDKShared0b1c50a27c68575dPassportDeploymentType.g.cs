
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0b1c50a27c68575dPassportDeploymentType
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
    public static class AutoSDKShared0b1c50a27c68575dPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0b1c50a27c68575dPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared0b1c50a27c68575dPassportDeploymentType.All => "all",
                AutoSDKShared0b1c50a27c68575dPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared0b1c50a27c68575dPassportDeploymentType.Preview => "preview",
                AutoSDKShared0b1c50a27c68575dPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0b1c50a27c68575dPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared0b1c50a27c68575dPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared0b1c50a27c68575dPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared0b1c50a27c68575dPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared0b1c50a27c68575dPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}