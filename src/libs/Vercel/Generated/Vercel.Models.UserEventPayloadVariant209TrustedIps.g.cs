
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant209TrustedIps
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
    public static class UserEventPayloadVariant209TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant209TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant209TrustedIps.All => "all",
                UserEventPayloadVariant209TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant209TrustedIps.Preview => "preview",
                UserEventPayloadVariant209TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant209TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant209TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant209TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant209TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant209TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant209TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant209TrustedIps.Production,
                _ => null,
            };
        }
    }
}