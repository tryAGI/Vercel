
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFrom
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
    public static class AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFrom value)
        {
            return value switch
            {
                AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFrom.All => "all",
                AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFrom.Preview => "preview",
                AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFrom.All,
                "all_except_custom_domains" => AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared8d2a365a5da335dfSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}