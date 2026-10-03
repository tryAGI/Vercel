
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom
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
    public static class AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom value)
        {
            return value switch
            {
                AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.All => "all",
                AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.Preview => "preview",
                AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.All,
                "all_except_custom_domains" => AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared8d2a365a5da335dfSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}