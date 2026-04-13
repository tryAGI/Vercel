
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant214TrustedIps
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
    public static class UserEventPayloadVariant214TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant214TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant214TrustedIps.All => "all",
                UserEventPayloadVariant214TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant214TrustedIps.Preview => "preview",
                UserEventPayloadVariant214TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant214TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant214TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant214TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant214TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant214TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant214TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant214TrustedIps.Production,
                _ => null,
            };
        }
    }
}