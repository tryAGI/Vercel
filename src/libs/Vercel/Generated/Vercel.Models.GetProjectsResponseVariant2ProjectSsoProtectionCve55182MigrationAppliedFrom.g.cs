
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom
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
    public static class GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom.All => "all",
                GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains => "all_except_custom_domains",
                GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom.Preview => "preview",
                GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom.All,
                "all_except_custom_domains" => GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom.AllExceptCustomDomains,
                "preview" => GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom.Preview,
                "prod_deployment_urls_and_all_previews" => GetProjectsResponseVariant2ProjectSsoProtectionCve55182MigrationAppliedFrom.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}