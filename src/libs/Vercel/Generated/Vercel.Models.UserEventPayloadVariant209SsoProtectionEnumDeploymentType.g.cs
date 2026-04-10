
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant209SsoProtectionEnumDeploymentType
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
    public static class UserEventPayloadVariant209SsoProtectionEnumDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant209SsoProtectionEnumDeploymentType value)
        {
            return value switch
            {
                UserEventPayloadVariant209SsoProtectionEnumDeploymentType.All => "all",
                UserEventPayloadVariant209SsoProtectionEnumDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant209SsoProtectionEnumDeploymentType.Preview => "preview",
                UserEventPayloadVariant209SsoProtectionEnumDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant209SsoProtectionEnumDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant209SsoProtectionEnumDeploymentType.All,
                "all_except_custom_domains" => UserEventPayloadVariant209SsoProtectionEnumDeploymentType.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant209SsoProtectionEnumDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant209SsoProtectionEnumDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}