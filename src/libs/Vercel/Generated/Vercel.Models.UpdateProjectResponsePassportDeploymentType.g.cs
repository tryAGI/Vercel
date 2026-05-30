
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponsePassportDeploymentType
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
    public static class UpdateProjectResponsePassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponsePassportDeploymentType value)
        {
            return value switch
            {
                UpdateProjectResponsePassportDeploymentType.All => "all",
                UpdateProjectResponsePassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateProjectResponsePassportDeploymentType.Preview => "preview",
                UpdateProjectResponsePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponsePassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateProjectResponsePassportDeploymentType.All,
                "all_except_custom_domains" => UpdateProjectResponsePassportDeploymentType.AllExceptCustomDomains,
                "preview" => UpdateProjectResponsePassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateProjectResponsePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}