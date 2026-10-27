
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentType
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
    public static class AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentType.All => "all",
                AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentType.Preview => "preview",
                AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared429ed81b15078f20PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}