
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant197PasswordProtectionEnum2
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
    public static class UserEventPayloadVariant197PasswordProtectionEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant197PasswordProtectionEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant197PasswordProtectionEnum2.All => "all",
                UserEventPayloadVariant197PasswordProtectionEnum2.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant197PasswordProtectionEnum2.Preview => "preview",
                UserEventPayloadVariant197PasswordProtectionEnum2.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant197PasswordProtectionEnum2? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant197PasswordProtectionEnum2.All,
                "all_except_custom_domains" => UserEventPayloadVariant197PasswordProtectionEnum2.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant197PasswordProtectionEnum2.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant197PasswordProtectionEnum2.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}