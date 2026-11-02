
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom
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
    public static class AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom value)
        {
            return value switch
            {
                AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom.All => "all",
                AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom.Preview => "preview",
                AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom.All,
                "all_except_custom_domains" => AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedf5934c240f4382f7SsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}