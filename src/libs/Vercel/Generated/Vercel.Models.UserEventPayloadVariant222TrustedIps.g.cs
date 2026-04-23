
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant222TrustedIps
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
    public static class UserEventPayloadVariant222TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant222TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant222TrustedIps.All => "all",
                UserEventPayloadVariant222TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant222TrustedIps.Preview => "preview",
                UserEventPayloadVariant222TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant222TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant222TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant222TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant222TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant222TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant222TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant222TrustedIps.Production,
                _ => null,
            };
        }
    }
}