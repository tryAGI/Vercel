
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1006e75c11b11a21PassportDeploymentType
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
    public static class AutoSDKShared1006e75c11b11a21PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1006e75c11b11a21PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared1006e75c11b11a21PassportDeploymentType.All => "all",
                AutoSDKShared1006e75c11b11a21PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared1006e75c11b11a21PassportDeploymentType.Preview => "preview",
                AutoSDKShared1006e75c11b11a21PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1006e75c11b11a21PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared1006e75c11b11a21PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared1006e75c11b11a21PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared1006e75c11b11a21PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared1006e75c11b11a21PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}