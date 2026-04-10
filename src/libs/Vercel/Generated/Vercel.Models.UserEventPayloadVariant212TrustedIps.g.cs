
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant212TrustedIps
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
    public static class UserEventPayloadVariant212TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant212TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant212TrustedIps.All => "all",
                UserEventPayloadVariant212TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant212TrustedIps.Preview => "preview",
                UserEventPayloadVariant212TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant212TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant212TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant212TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant212TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant212TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant212TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant212TrustedIps.Production,
                _ => null,
            };
        }
    }
}