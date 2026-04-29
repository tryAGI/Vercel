
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom
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
    public static class UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom value)
        {
            return value switch
            {
                UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom.All => "all",
                UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom.Preview => "preview",
                UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom.All,
                "all_except_custom_domains" => UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant229OldSsoProtectionEnumApril2026SecurityIncidentMigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}