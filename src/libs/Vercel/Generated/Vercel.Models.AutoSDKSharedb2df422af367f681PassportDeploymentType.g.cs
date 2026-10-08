
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb2df422af367f681PassportDeploymentType
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
    public static class AutoSDKSharedb2df422af367f681PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb2df422af367f681PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharedb2df422af367f681PassportDeploymentType.All => "all",
                AutoSDKSharedb2df422af367f681PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharedb2df422af367f681PassportDeploymentType.Preview => "preview",
                AutoSDKSharedb2df422af367f681PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb2df422af367f681PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharedb2df422af367f681PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharedb2df422af367f681PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharedb2df422af367f681PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharedb2df422af367f681PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}