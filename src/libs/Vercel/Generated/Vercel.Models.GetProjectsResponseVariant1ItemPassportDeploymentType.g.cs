
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemPassportDeploymentType
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
    public static class GetProjectsResponseVariant1ItemPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemPassportDeploymentType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemPassportDeploymentType.All => "all",
                GetProjectsResponseVariant1ItemPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectsResponseVariant1ItemPassportDeploymentType.Preview => "preview",
                GetProjectsResponseVariant1ItemPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectsResponseVariant1ItemPassportDeploymentType.All,
                "all_except_custom_domains" => GetProjectsResponseVariant1ItemPassportDeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectsResponseVariant1ItemPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectsResponseVariant1ItemPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}