
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSsoProtectionDeploymentType
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
    public static class GetProjectsResponseVariant3ProjectSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSsoProtectionDeploymentType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSsoProtectionDeploymentType.All => "all",
                GetProjectsResponseVariant3ProjectSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectsResponseVariant3ProjectSsoProtectionDeploymentType.Preview => "preview",
                GetProjectsResponseVariant3ProjectSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectsResponseVariant3ProjectSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => GetProjectsResponseVariant3ProjectSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectsResponseVariant3ProjectSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectsResponseVariant3ProjectSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}