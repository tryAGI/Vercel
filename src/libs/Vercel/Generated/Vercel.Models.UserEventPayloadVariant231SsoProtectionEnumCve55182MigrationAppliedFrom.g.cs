
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFrom
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
    public static class UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFrom value)
        {
            return value switch
            {
                UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFrom.All => "all",
                UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFrom.Preview => "preview",
                UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFrom.All,
                "all_except_custom_domains" => UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant231SsoProtectionEnumCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}