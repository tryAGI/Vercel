
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectPassportDeploymentType
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
    public static class GetProjectsResponseVariant3ProjectPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectPassportDeploymentType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectPassportDeploymentType.All => "all",
                GetProjectsResponseVariant3ProjectPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectsResponseVariant3ProjectPassportDeploymentType.Preview => "preview",
                GetProjectsResponseVariant3ProjectPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectsResponseVariant3ProjectPassportDeploymentType.All,
                "all_except_custom_domains" => GetProjectsResponseVariant3ProjectPassportDeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectsResponseVariant3ProjectPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectsResponseVariant3ProjectPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}