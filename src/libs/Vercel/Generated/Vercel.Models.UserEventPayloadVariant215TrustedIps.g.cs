
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant215TrustedIps
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
    public static class UserEventPayloadVariant215TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant215TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant215TrustedIps.All => "all",
                UserEventPayloadVariant215TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant215TrustedIps.Preview => "preview",
                UserEventPayloadVariant215TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant215TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant215TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant215TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant215TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant215TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant215TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant215TrustedIps.Production,
                _ => null,
            };
        }
    }
}