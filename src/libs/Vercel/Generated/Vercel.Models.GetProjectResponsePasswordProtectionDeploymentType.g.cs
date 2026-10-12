
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponsePasswordProtectionDeploymentType
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
    public static class GetProjectResponsePasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponsePasswordProtectionDeploymentType value)
        {
            return value switch
            {
                GetProjectResponsePasswordProtectionDeploymentType.All => "all",
                GetProjectResponsePasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectResponsePasswordProtectionDeploymentType.Preview => "preview",
                GetProjectResponsePasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponsePasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectResponsePasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => GetProjectResponsePasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectResponsePasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectResponsePasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}