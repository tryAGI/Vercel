
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponsePassportDeploymentType
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
    public static class GetProjectResponsePassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponsePassportDeploymentType value)
        {
            return value switch
            {
                GetProjectResponsePassportDeploymentType.All => "all",
                GetProjectResponsePassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectResponsePassportDeploymentType.Preview => "preview",
                GetProjectResponsePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponsePassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectResponsePassportDeploymentType.All,
                "all_except_custom_domains" => GetProjectResponsePassportDeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectResponsePassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectResponsePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}