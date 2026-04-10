
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant209OldSsoProtectionEnumDeploymentType
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
    public static class UserEventPayloadVariant209OldSsoProtectionEnumDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant209OldSsoProtectionEnumDeploymentType value)
        {
            return value switch
            {
                UserEventPayloadVariant209OldSsoProtectionEnumDeploymentType.All => "all",
                UserEventPayloadVariant209OldSsoProtectionEnumDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant209OldSsoProtectionEnumDeploymentType.Preview => "preview",
                UserEventPayloadVariant209OldSsoProtectionEnumDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant209OldSsoProtectionEnumDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant209OldSsoProtectionEnumDeploymentType.All,
                "all_except_custom_domains" => UserEventPayloadVariant209OldSsoProtectionEnumDeploymentType.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant209OldSsoProtectionEnumDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant209OldSsoProtectionEnumDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}