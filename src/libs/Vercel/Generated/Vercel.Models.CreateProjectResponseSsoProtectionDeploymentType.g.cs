
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseSsoProtectionDeploymentType
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
    public static class CreateProjectResponseSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSsoProtectionDeploymentType value)
        {
            return value switch
            {
                CreateProjectResponseSsoProtectionDeploymentType.All => "all",
                CreateProjectResponseSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                CreateProjectResponseSsoProtectionDeploymentType.Preview => "preview",
                CreateProjectResponseSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateProjectResponseSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => CreateProjectResponseSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => CreateProjectResponseSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => CreateProjectResponseSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}