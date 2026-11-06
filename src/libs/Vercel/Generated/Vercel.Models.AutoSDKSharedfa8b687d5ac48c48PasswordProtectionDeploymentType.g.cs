
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentType
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
    public static class AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentType.All => "all",
                AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentType.Preview => "preview",
                AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedfa8b687d5ac48c48PasswordProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}