
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentType
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
    public static class AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentType.All => "all",
                AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentType.Preview => "preview",
                AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared2eb5520e92a3b839PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}