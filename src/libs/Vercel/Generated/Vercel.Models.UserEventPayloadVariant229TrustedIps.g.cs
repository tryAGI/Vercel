
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant229TrustedIps
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
    public static class UserEventPayloadVariant229TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant229TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant229TrustedIps.All => "all",
                UserEventPayloadVariant229TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant229TrustedIps.Preview => "preview",
                UserEventPayloadVariant229TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant229TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant229TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant229TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant229TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant229TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant229TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant229TrustedIps.Production,
                _ => null,
            };
        }
    }
}