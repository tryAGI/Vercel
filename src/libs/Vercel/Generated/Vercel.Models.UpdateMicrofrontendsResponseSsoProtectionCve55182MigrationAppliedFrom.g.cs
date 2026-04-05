
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFrom
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
    public static class UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFrom value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFrom.All => "all",
                UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFrom.Preview => "preview",
                UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFrom.All,
                "all_except_custom_domains" => UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateMicrofrontendsResponseSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}