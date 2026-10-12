
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponsePasswordProtectionDeploymentType
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
    public static class UpdateProjectResponsePasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponsePasswordProtectionDeploymentType value)
        {
            return value switch
            {
                UpdateProjectResponsePasswordProtectionDeploymentType.All => "all",
                UpdateProjectResponsePasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateProjectResponsePasswordProtectionDeploymentType.Preview => "preview",
                UpdateProjectResponsePasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponsePasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateProjectResponsePasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => UpdateProjectResponsePasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => UpdateProjectResponsePasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateProjectResponsePasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}