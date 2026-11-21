
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1134f969ff3cc06cPassportDeploymentType
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
    public static class AutoSDKShared1134f969ff3cc06cPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1134f969ff3cc06cPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared1134f969ff3cc06cPassportDeploymentType.All => "all",
                AutoSDKShared1134f969ff3cc06cPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared1134f969ff3cc06cPassportDeploymentType.Preview => "preview",
                AutoSDKShared1134f969ff3cc06cPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1134f969ff3cc06cPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared1134f969ff3cc06cPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared1134f969ff3cc06cPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared1134f969ff3cc06cPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared1134f969ff3cc06cPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}