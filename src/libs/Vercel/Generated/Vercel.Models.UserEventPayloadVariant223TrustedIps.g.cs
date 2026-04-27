
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant223TrustedIps
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
    public static class UserEventPayloadVariant223TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant223TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant223TrustedIps.All => "all",
                UserEventPayloadVariant223TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant223TrustedIps.Preview => "preview",
                UserEventPayloadVariant223TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant223TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant223TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant223TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant223TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant223TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant223TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant223TrustedIps.Production,
                _ => null,
            };
        }
    }
}