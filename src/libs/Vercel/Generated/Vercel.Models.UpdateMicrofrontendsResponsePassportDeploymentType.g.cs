
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponsePassportDeploymentType
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
    public static class UpdateMicrofrontendsResponsePassportDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponsePassportDeploymentType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponsePassportDeploymentType.All => "all",
                UpdateMicrofrontendsResponsePassportDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UpdateMicrofrontendsResponsePassportDeploymentType.Preview => "preview",
                UpdateMicrofrontendsResponsePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponsePassportDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UpdateMicrofrontendsResponsePassportDeploymentType.All,
                "all_except_custom_domains" => UpdateMicrofrontendsResponsePassportDeploymentType.AllExceptCustomDomains,
                "preview" => UpdateMicrofrontendsResponsePassportDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UpdateMicrofrontendsResponsePassportDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}