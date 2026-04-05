
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectRequestSsoProtectionDeploymentType
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
    public static class CreateProjectRequestSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestSsoProtectionDeploymentType value)
        {
            return value switch
            {
                CreateProjectRequestSsoProtectionDeploymentType.All => "all",
                CreateProjectRequestSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                CreateProjectRequestSsoProtectionDeploymentType.Preview => "preview",
                CreateProjectRequestSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateProjectRequestSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => CreateProjectRequestSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => CreateProjectRequestSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => CreateProjectRequestSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}