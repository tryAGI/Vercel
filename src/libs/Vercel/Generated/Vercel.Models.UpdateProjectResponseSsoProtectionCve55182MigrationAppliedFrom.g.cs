
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFrom
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
    public static class UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFrom value)
        {
            return value switch
            {
                UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFrom.All => "all",
                UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFrom.Preview => "preview",
                UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFrom.All,
                "all_except_custom_domains" => UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateProjectResponseSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}