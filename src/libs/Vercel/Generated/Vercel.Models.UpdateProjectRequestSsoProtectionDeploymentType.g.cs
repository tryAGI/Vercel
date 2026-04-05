
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Specify if the Vercel Authentication (SSO Protection) will apply to every Deployment Target or just Preview<br/>
    /// Default Value: preview
    /// </summary>
    public enum UpdateProjectRequestSsoProtectionDeploymentType
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
    public static class UpdateProjectRequestSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestSsoProtectionDeploymentType value)
        {
            return value switch
            {
                UpdateProjectRequestSsoProtectionDeploymentType.All => "all",
                UpdateProjectRequestSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateProjectRequestSsoProtectionDeploymentType.Preview => "preview",
                UpdateProjectRequestSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateProjectRequestSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => UpdateProjectRequestSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => UpdateProjectRequestSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateProjectRequestSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}