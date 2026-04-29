
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant231TrustedIps
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
    public static class UserEventPayloadVariant231TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant231TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant231TrustedIps.All => "all",
                UserEventPayloadVariant231TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant231TrustedIps.Preview => "preview",
                UserEventPayloadVariant231TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant231TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant231TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant231TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant231TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant231TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant231TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant231TrustedIps.Production,
                _ => null,
            };
        }
    }
}