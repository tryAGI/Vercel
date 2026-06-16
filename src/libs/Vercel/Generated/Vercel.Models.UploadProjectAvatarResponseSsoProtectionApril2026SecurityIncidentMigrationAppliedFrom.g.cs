
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom
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
    public static class UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.All => "all",
                UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.Preview => "preview",
                UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.All,
                "all_except_custom_domains" => UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => UploadProjectAvatarResponseSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}