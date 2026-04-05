
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseSsoProtectionDeploymentType
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
    public static class GetProjectResponseSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSsoProtectionDeploymentType value)
        {
            return value switch
            {
                GetProjectResponseSsoProtectionDeploymentType.All => "all",
                GetProjectResponseSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectResponseSsoProtectionDeploymentType.Preview => "preview",
                GetProjectResponseSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectResponseSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => GetProjectResponseSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => GetProjectResponseSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectResponseSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}