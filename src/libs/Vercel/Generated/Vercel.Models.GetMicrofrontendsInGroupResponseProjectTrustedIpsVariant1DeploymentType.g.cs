
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType
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
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType.All => "all",
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType.All,
                "all_except_custom_domains" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType.AllExceptCustomDomains,
                "preview" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1DeploymentType.Production,
                _ => null,
            };
        }
    }
}