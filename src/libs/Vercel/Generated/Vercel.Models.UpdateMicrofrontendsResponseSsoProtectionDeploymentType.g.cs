
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseSsoProtectionDeploymentType
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
    public static class UpdateMicrofrontendsResponseSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSsoProtectionDeploymentType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSsoProtectionDeploymentType.All => "all",
                UpdateMicrofrontendsResponseSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateMicrofrontendsResponseSsoProtectionDeploymentType.Preview => "preview",
                UpdateMicrofrontendsResponseSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateMicrofrontendsResponseSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => UpdateMicrofrontendsResponseSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => UpdateMicrofrontendsResponseSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateMicrofrontendsResponseSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}