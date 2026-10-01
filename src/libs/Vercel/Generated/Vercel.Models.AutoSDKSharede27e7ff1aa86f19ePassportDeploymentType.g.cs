
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede27e7ff1aa86f19ePassportDeploymentType
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
    public static class AutoSDKSharede27e7ff1aa86f19ePassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede27e7ff1aa86f19ePassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKSharede27e7ff1aa86f19ePassportDeploymentType.All => "all",
                AutoSDKSharede27e7ff1aa86f19ePassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKSharede27e7ff1aa86f19ePassportDeploymentType.Preview => "preview",
                AutoSDKSharede27e7ff1aa86f19ePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede27e7ff1aa86f19ePassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKSharede27e7ff1aa86f19ePassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKSharede27e7ff1aa86f19ePassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKSharede27e7ff1aa86f19ePassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKSharede27e7ff1aa86f19ePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}