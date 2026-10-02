
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared949b4255932cb64aSsoProtectionDeploymentType
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
    public static class AutoSDKShared949b4255932cb64aSsoProtectionDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared949b4255932cb64aSsoProtectionDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared949b4255932cb64aSsoProtectionDeploymentType.All => "all",
                AutoSDKShared949b4255932cb64aSsoProtectionDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared949b4255932cb64aSsoProtectionDeploymentType.Preview => "preview",
                AutoSDKShared949b4255932cb64aSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared949b4255932cb64aSsoProtectionDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared949b4255932cb64aSsoProtectionDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared949b4255932cb64aSsoProtectionDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared949b4255932cb64aSsoProtectionDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared949b4255932cb64aSsoProtectionDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}