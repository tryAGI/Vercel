
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Specify if the Vercel Authentication (SSO Protection) will apply to every Deployment Target or just Preview<br/>
    /// Default Value: preview
    /// </summary>
    public enum PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentType
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
    public static class PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentType value)
        {
            return value switch
            {
                PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentType.All => "all",
                PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentType.Preview => "preview",
                PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => PatchTeamRequestDefaultDeploymentProtectionSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}