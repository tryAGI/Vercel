
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom
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
    public static class AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.All => "all",
                AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.Preview => "preview",
                AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.All,
                "all_except_custom_domains" => AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared94b26a5607c7a373SsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}