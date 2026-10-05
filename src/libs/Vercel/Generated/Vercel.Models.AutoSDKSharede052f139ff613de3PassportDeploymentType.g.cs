
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede052f139ff613de3PassportDeploymentType
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
    public static class AutoSDKSharede052f139ff613de3PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede052f139ff613de3PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharede052f139ff613de3PassportDeploymentType.All => "all",
                AutoSDKSharede052f139ff613de3PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharede052f139ff613de3PassportDeploymentType.Preview => "preview",
                AutoSDKSharede052f139ff613de3PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede052f139ff613de3PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharede052f139ff613de3PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharede052f139ff613de3PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharede052f139ff613de3PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharede052f139ff613de3PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}