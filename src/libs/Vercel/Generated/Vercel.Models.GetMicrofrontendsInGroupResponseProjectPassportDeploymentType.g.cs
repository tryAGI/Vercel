
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectPassportDeploymentType
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
    public static class GetMicrofrontendsInGroupResponseProjectPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectPassportDeploymentType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectPassportDeploymentType.All => "all",
                GetMicrofrontendsInGroupResponseProjectPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetMicrofrontendsInGroupResponseProjectPassportDeploymentType.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetMicrofrontendsInGroupResponseProjectPassportDeploymentType.All,
                "all_except_custom_domains" => GetMicrofrontendsInGroupResponseProjectPassportDeploymentType.AllExceptCustomDomains,
                "preview" => GetMicrofrontendsInGroupResponseProjectPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetMicrofrontendsInGroupResponseProjectPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}