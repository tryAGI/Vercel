
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant232TrustedIps
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
    public static class UserEventPayloadVariant232TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant232TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant232TrustedIps.All => "all",
                UserEventPayloadVariant232TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant232TrustedIps.Preview => "preview",
                UserEventPayloadVariant232TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant232TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant232TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant232TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant232TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant232TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant232TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant232TrustedIps.Production,
                _ => null,
            };
        }
    }
}