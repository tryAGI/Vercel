
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Specify if the password will apply to every Deployment Target or just Preview
    /// </summary>
    public enum UpdateProjectRequestPasswordProtectionDeploymentType
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
    public static class UpdateProjectRequestPasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestPasswordProtectionDeploymentType value)
        {
            return value switch
            {
                UpdateProjectRequestPasswordProtectionDeploymentType.All => "all",
                UpdateProjectRequestPasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateProjectRequestPasswordProtectionDeploymentType.Preview => "preview",
                UpdateProjectRequestPasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestPasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateProjectRequestPasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => UpdateProjectRequestPasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => UpdateProjectRequestPasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateProjectRequestPasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}