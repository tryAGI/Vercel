
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponsePassportDeploymentType
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
    public static class CreateProjectResponsePassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponsePassportDeploymentType value)
        {
            return value switch
            {
                CreateProjectResponsePassportDeploymentType.All => "all",
                CreateProjectResponsePassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                CreateProjectResponsePassportDeploymentType.Preview => "preview",
                CreateProjectResponsePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponsePassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateProjectResponsePassportDeploymentType.All,
                "all_except_custom_domains" => CreateProjectResponsePassportDeploymentType.AllExceptCustomDomains,
                "preview" => CreateProjectResponsePassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => CreateProjectResponsePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}