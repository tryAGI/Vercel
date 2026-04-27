
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant221SsoProtectionEnumDeploymentType
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
    public static class UserEventPayloadVariant221SsoProtectionEnumDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant221SsoProtectionEnumDeploymentType value)
        {
            return value switch
            {
                UserEventPayloadVariant221SsoProtectionEnumDeploymentType.All => "all",
                UserEventPayloadVariant221SsoProtectionEnumDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant221SsoProtectionEnumDeploymentType.Preview => "preview",
                UserEventPayloadVariant221SsoProtectionEnumDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant221SsoProtectionEnumDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant221SsoProtectionEnumDeploymentType.All,
                "all_except_custom_domains" => UserEventPayloadVariant221SsoProtectionEnumDeploymentType.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant221SsoProtectionEnumDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant221SsoProtectionEnumDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}