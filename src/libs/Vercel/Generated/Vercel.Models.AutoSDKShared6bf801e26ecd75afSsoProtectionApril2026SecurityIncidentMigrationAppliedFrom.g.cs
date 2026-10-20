
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom
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
    public static class AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.All => "all",
                AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.Preview => "preview",
                AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.All,
                "all_except_custom_domains" => AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared6bf801e26ecd75afSsoProtectionApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}