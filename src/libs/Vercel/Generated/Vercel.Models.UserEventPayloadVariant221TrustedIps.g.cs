
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant221TrustedIps
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
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant221TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant221TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant221TrustedIps.All => "all",
                UserEventPayloadVariant221TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant221TrustedIps.Preview => "preview",
                UserEventPayloadVariant221TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant221TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant221TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant221TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant221TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant221TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant221TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant221TrustedIps.Production,
                _ => null,
            };
        }
    }
}