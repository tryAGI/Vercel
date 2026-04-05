
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Specify if the Trusted IPs will apply to every Deployment Target or just Preview
    /// </summary>
    public enum UpdateProjectRequestTrustedIpsDeploymentType
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
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestTrustedIpsDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestTrustedIpsDeploymentType value)
        {
            return value switch
            {
                UpdateProjectRequestTrustedIpsDeploymentType.All => "all",
                UpdateProjectRequestTrustedIpsDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateProjectRequestTrustedIpsDeploymentType.Preview => "preview",
                UpdateProjectRequestTrustedIpsDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UpdateProjectRequestTrustedIpsDeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestTrustedIpsDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateProjectRequestTrustedIpsDeploymentType.All,
                "all_except_custom_domains" => UpdateProjectRequestTrustedIpsDeploymentType.AllExceptCustomDomains,
                "preview" => UpdateProjectRequestTrustedIpsDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateProjectRequestTrustedIpsDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => UpdateProjectRequestTrustedIpsDeploymentType.Production,
                _ => null,
            };
        }
    }
}