
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFrom
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
    public static class AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFrom value)
        {
            return value switch
            {
                AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFrom.All => "all",
                AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFrom.Preview => "preview",
                AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFrom.All,
                "all_except_custom_domains" => AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedfc5823c22a1eaa2bSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}