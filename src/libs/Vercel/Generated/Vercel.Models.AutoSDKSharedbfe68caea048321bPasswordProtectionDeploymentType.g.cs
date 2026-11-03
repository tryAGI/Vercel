
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType
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
    public static class AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType.All => "all",
                AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType.Preview => "preview",
                AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedbfe68caea048321bPasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}