
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom
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
    public static class AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.All => "all",
                AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.Preview => "preview",
                AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.All,
                "all_except_custom_domains" => AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedbfe68caea048321bSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}