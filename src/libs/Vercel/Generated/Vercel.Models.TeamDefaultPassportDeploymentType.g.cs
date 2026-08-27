
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Passport configuration for new projects in this team.
    /// </summary>
    public enum TeamDefaultPassportDeploymentType
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
    public static class TeamDefaultPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDefaultPassportDeploymentType value)
        {
            return value switch
            {
                TeamDefaultPassportDeploymentType.All => "all",
                TeamDefaultPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                TeamDefaultPassportDeploymentType.Preview => "preview",
                TeamDefaultPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDefaultPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => TeamDefaultPassportDeploymentType.All,
                "all_except_custom_domains" => TeamDefaultPassportDeploymentType.AllExceptCustomDomains,
                "preview" => TeamDefaultPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => TeamDefaultPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}