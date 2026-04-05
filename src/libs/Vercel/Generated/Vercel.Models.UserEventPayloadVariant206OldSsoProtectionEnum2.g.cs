
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant206OldSsoProtectionEnum2
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
    public static class UserEventPayloadVariant206OldSsoProtectionEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant206OldSsoProtectionEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant206OldSsoProtectionEnum2.All => "all",
                UserEventPayloadVariant206OldSsoProtectionEnum2.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant206OldSsoProtectionEnum2.Preview => "preview",
                UserEventPayloadVariant206OldSsoProtectionEnum2.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant206OldSsoProtectionEnum2? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant206OldSsoProtectionEnum2.All,
                "all_except_custom_domains" => UserEventPayloadVariant206OldSsoProtectionEnum2.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant206OldSsoProtectionEnum2.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant206OldSsoProtectionEnum2.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}