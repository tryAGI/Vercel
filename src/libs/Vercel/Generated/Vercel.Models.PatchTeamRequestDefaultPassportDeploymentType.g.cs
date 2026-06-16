
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchTeamRequestDefaultPassportDeploymentType
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
    public static class PatchTeamRequestDefaultPassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDefaultPassportDeploymentType value)
        {
            return value switch
            {
                PatchTeamRequestDefaultPassportDeploymentType.All => "all",
                PatchTeamRequestDefaultPassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                PatchTeamRequestDefaultPassportDeploymentType.Preview => "preview",
                PatchTeamRequestDefaultPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDefaultPassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => PatchTeamRequestDefaultPassportDeploymentType.All,
                "all_except_custom_domains" => PatchTeamRequestDefaultPassportDeploymentType.AllExceptCustomDomains,
                "preview" => PatchTeamRequestDefaultPassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => PatchTeamRequestDefaultPassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}