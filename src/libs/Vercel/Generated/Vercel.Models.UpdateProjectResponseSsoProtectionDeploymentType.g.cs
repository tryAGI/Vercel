
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseSsoProtectionDeploymentType
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
    public static class UpdateProjectResponseSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSsoProtectionDeploymentType value)
        {
            return value switch
            {
                UpdateProjectResponseSsoProtectionDeploymentType.All => "all",
                UpdateProjectResponseSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateProjectResponseSsoProtectionDeploymentType.Preview => "preview",
                UpdateProjectResponseSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateProjectResponseSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => UpdateProjectResponseSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => UpdateProjectResponseSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateProjectResponseSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}