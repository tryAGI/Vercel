
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc30663411f76e3c9PassportDeploymentType
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
    public static class AutoSDKSharedc30663411f76e3c9PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc30663411f76e3c9PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedc30663411f76e3c9PassportDeploymentType.All => "all",
                AutoSDKSharedc30663411f76e3c9PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedc30663411f76e3c9PassportDeploymentType.Preview => "preview",
                AutoSDKSharedc30663411f76e3c9PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc30663411f76e3c9PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedc30663411f76e3c9PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedc30663411f76e3c9PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedc30663411f76e3c9PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedc30663411f76e3c9PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}