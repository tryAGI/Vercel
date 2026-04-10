
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant211TrustedIps
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
    public static class UserEventPayloadVariant211TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant211TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant211TrustedIps.All => "all",
                UserEventPayloadVariant211TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant211TrustedIps.Preview => "preview",
                UserEventPayloadVariant211TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant211TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant211TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant211TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant211TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant211TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant211TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant211TrustedIps.Production,
                _ => null,
            };
        }
    }
}