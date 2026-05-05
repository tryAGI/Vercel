
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant233TrustedIps
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
    public static class UserEventPayloadVariant233TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant233TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant233TrustedIps.All => "all",
                UserEventPayloadVariant233TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant233TrustedIps.Preview => "preview",
                UserEventPayloadVariant233TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant233TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant233TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant233TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant233TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant233TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant233TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant233TrustedIps.Production,
                _ => null,
            };
        }
    }
}