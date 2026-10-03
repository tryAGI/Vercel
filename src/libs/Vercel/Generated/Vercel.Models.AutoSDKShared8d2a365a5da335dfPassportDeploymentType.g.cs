
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8d2a365a5da335dfPassportDeploymentType
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
    public static class AutoSDKShared8d2a365a5da335dfPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8d2a365a5da335dfPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared8d2a365a5da335dfPassportDeploymentType.All => "all",
                AutoSDKShared8d2a365a5da335dfPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared8d2a365a5da335dfPassportDeploymentType.Preview => "preview",
                AutoSDKShared8d2a365a5da335dfPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8d2a365a5da335dfPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared8d2a365a5da335dfPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared8d2a365a5da335dfPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared8d2a365a5da335dfPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared8d2a365a5da335dfPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}