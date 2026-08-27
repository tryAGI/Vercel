
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum UpdateProjectRequestPassportDeploymentType
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
    public static class UpdateProjectRequestPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestPassportDeploymentType value)
        {
            return value switch
            {
                UpdateProjectRequestPassportDeploymentType.All => "all",
                UpdateProjectRequestPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateProjectRequestPassportDeploymentType.Preview => "preview",
                UpdateProjectRequestPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateProjectRequestPassportDeploymentType.All,
                "all_except_custom_domains" => UpdateProjectRequestPassportDeploymentType.AllExceptCustomDomains,
                "preview" => UpdateProjectRequestPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateProjectRequestPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}