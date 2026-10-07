
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared223443184387411fPassportDeploymentType
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
    public static class AutoSDKShared223443184387411fPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared223443184387411fPassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared223443184387411fPassportDeploymentType.All => "all",
                AutoSDKShared223443184387411fPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared223443184387411fPassportDeploymentType.Preview => "preview",
                AutoSDKShared223443184387411fPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared223443184387411fPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared223443184387411fPassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared223443184387411fPassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared223443184387411fPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared223443184387411fPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}