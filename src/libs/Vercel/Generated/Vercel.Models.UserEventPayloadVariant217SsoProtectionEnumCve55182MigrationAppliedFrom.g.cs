
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFrom
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
    public static class UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFrom value)
        {
            return value switch
            {
                UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFrom.All => "all",
                UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFrom.Preview => "preview",
                UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFrom.All,
                "all_except_custom_domains" => UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant217SsoProtectionEnumCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}