
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectPassportDeploymentType
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
    public static class GetProjectsResponseVariant2ProjectPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectPassportDeploymentType value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectPassportDeploymentType.All => "all",
                GetProjectsResponseVariant2ProjectPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectsResponseVariant2ProjectPassportDeploymentType.Preview => "preview",
                GetProjectsResponseVariant2ProjectPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectsResponseVariant2ProjectPassportDeploymentType.All,
                "all_except_custom_domains" => GetProjectsResponseVariant2ProjectPassportDeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectsResponseVariant2ProjectPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectsResponseVariant2ProjectPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}