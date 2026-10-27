
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429ed81b15078f20PassportDeploymentType
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
    public static class AutoSDKShared429ed81b15078f20PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429ed81b15078f20PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared429ed81b15078f20PassportDeploymentType.All => "all",
                AutoSDKShared429ed81b15078f20PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared429ed81b15078f20PassportDeploymentType.Preview => "preview",
                AutoSDKShared429ed81b15078f20PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429ed81b15078f20PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared429ed81b15078f20PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared429ed81b15078f20PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared429ed81b15078f20PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared429ed81b15078f20PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}