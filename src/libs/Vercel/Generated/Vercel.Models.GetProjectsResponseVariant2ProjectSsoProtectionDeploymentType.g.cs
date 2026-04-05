
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType
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
    public static class GetProjectsResponseVariant2ProjectSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType.All => "all",
                GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType.Preview => "preview",
                GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectsResponseVariant2ProjectSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}