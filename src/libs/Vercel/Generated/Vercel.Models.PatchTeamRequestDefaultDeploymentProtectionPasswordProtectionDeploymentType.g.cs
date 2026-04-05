
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Specify if the password will apply to every Deployment Target or just Preview
    /// </summary>
    public enum PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType
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
    public static class PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType value)
        {
            return value switch
            {
                PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType.All => "all",
                PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType.Preview => "preview",
                PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}