
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341PassportDeploymentType
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
    public static class AutoSDKShared8b163ed62d2bb341PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341PassportDeploymentType.All => "all",
                AutoSDKShared8b163ed62d2bb341PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared8b163ed62d2bb341PassportDeploymentType.Preview => "preview",
                AutoSDKShared8b163ed62d2bb341PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared8b163ed62d2bb341PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared8b163ed62d2bb341PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared8b163ed62d2bb341PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared8b163ed62d2bb341PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}