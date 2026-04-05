
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant192OldPasswordProtectionEnum2
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
    public static class UserEventPayloadVariant192OldPasswordProtectionEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant192OldPasswordProtectionEnum2 value)
        {
            return value switch
            {
                UserEventPayloadVariant192OldPasswordProtectionEnum2.All => "all",
                UserEventPayloadVariant192OldPasswordProtectionEnum2.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant192OldPasswordProtectionEnum2.Preview => "preview",
                UserEventPayloadVariant192OldPasswordProtectionEnum2.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant192OldPasswordProtectionEnum2? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant192OldPasswordProtectionEnum2.All,
                "all_except_custom_domains" => UserEventPayloadVariant192OldPasswordProtectionEnum2.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant192OldPasswordProtectionEnum2.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant192OldPasswordProtectionEnum2.ProdDeploymentUrlsAndAllPreviews,
                _ => null,
            };
        }
    }
}