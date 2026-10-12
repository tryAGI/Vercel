
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType
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
    public static class GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType.All => "all",
                GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => GetMicrofrontendsInGroupResponseProjectPasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}