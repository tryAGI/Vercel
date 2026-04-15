
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant219TrustedIps
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
    public static class UserEventPayloadVariant219TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant219TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant219TrustedIps.All => "all",
                UserEventPayloadVariant219TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant219TrustedIps.Preview => "preview",
                UserEventPayloadVariant219TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant219TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant219TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant219TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant219TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant219TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant219TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant219TrustedIps.Production,
                _ => null,
            };
        }
    }
}