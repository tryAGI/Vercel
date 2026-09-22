
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7PassportDeploymentType
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
    public static class AutoSDKShared061b01d29a72e8d7PassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7PassportDeploymentType value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7PassportDeploymentType.All => "all",
                AutoSDKShared061b01d29a72e8d7PassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                AutoSDKShared061b01d29a72e8d7PassportDeploymentType.Preview => "preview",
                AutoSDKShared061b01d29a72e8d7PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7PassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared061b01d29a72e8d7PassportDeploymentType.All,
                "all_except_custom_domains" => AutoSDKShared061b01d29a72e8d7PassportDeploymentType.AllExceptCustomDomains,
                "preview" => AutoSDKShared061b01d29a72e8d7PassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => AutoSDKShared061b01d29a72e8d7PassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}