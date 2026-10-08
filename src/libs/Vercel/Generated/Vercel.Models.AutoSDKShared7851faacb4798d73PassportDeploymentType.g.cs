
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7851faacb4798d73PassportDeploymentType
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
    public static class AutoSDKShared7851faacb4798d73PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7851faacb4798d73PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared7851faacb4798d73PassportDeploymentType.All => "all",
                AutoSDKShared7851faacb4798d73PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared7851faacb4798d73PassportDeploymentType.Preview => "preview",
                AutoSDKShared7851faacb4798d73PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7851faacb4798d73PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared7851faacb4798d73PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared7851faacb4798d73PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared7851faacb4798d73PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared7851faacb4798d73PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}