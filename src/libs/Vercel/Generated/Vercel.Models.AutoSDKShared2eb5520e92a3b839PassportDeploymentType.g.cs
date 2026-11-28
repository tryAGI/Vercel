
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2eb5520e92a3b839PassportDeploymentType
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
    public static class AutoSDKShared2eb5520e92a3b839PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2eb5520e92a3b839PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared2eb5520e92a3b839PassportDeploymentType.All => "all",
                AutoSDKShared2eb5520e92a3b839PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared2eb5520e92a3b839PassportDeploymentType.Preview => "preview",
                AutoSDKShared2eb5520e92a3b839PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2eb5520e92a3b839PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared2eb5520e92a3b839PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared2eb5520e92a3b839PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared2eb5520e92a3b839PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared2eb5520e92a3b839PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}