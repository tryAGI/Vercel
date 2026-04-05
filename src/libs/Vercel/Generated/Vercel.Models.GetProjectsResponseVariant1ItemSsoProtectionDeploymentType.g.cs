
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSsoProtectionDeploymentType
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
    public static class GetProjectsResponseVariant1ItemSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSsoProtectionDeploymentType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSsoProtectionDeploymentType.All => "all",
                GetProjectsResponseVariant1ItemSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectsResponseVariant1ItemSsoProtectionDeploymentType.Preview => "preview",
                GetProjectsResponseVariant1ItemSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectsResponseVariant1ItemSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => GetProjectsResponseVariant1ItemSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectsResponseVariant1ItemSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectsResponseVariant1ItemSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}