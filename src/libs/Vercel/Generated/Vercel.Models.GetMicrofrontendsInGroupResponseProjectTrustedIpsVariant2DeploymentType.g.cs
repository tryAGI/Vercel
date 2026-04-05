
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType
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
    public static class GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType.All => "all",
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType.All,
                "all_except_custom_domains" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType.AllExceptCustomDomains,
                "preview" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType.ProdDeploymentUrlsAndAllPreviews,
                "production" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant2DeploymentType.Production,
                _ => null,
            };
        }
    }
}