
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant206PasswordProtectionEnumDeploymentType
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
    public static class UserEventPayloadVariant206PasswordProtectionEnumDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant206PasswordProtectionEnumDeploymentType value)
        {
            return value switch
            {
                UserEventPayloadVariant206PasswordProtectionEnumDeploymentType.All => "all",
                UserEventPayloadVariant206PasswordProtectionEnumDeploymentType.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant206PasswordProtectionEnumDeploymentType.Preview => "preview",
                UserEventPayloadVariant206PasswordProtectionEnumDeploymentType.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant206PasswordProtectionEnumDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant206PasswordProtectionEnumDeploymentType.All,
                "all_except_custom_domains" => UserEventPayloadVariant206PasswordProtectionEnumDeploymentType.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant206PasswordProtectionEnumDeploymentType.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant206PasswordProtectionEnumDeploymentType.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}