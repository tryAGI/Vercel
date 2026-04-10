
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant195PasswordProtectionEnumDeploymentType
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
    public static class UserEventPayloadVariant195PasswordProtectionEnumDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant195PasswordProtectionEnumDeploymentType value)
        {
            return value switch
            {
                UserEventPayloadVariant195PasswordProtectionEnumDeploymentType.All => "all",
                UserEventPayloadVariant195PasswordProtectionEnumDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant195PasswordProtectionEnumDeploymentType.Preview => "preview",
                UserEventPayloadVariant195PasswordProtectionEnumDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant195PasswordProtectionEnumDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant195PasswordProtectionEnumDeploymentType.All,
                "all_except_custom_domains" => UserEventPayloadVariant195PasswordProtectionEnumDeploymentType.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant195PasswordProtectionEnumDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant195PasswordProtectionEnumDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}