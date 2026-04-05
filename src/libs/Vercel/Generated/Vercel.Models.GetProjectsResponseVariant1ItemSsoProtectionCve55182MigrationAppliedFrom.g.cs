
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFrom
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
    public static class GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFrom value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFrom.All => "all",
                GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFrom.Preview => "preview",
                GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFrom.All,
                "all_except_custom_domains" => GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectsResponseVariant1ItemSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}