
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentType
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
    public static class GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentType.All => "all",
                GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentType.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetMicrofrontendsInGroupResponseProjectSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}