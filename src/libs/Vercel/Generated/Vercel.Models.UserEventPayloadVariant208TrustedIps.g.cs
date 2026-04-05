
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant208TrustedIps
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
    public static class UserEventPayloadVariant208TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant208TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant208TrustedIps.All => "all",
                UserEventPayloadVariant208TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant208TrustedIps.Preview => "preview",
                UserEventPayloadVariant208TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant208TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant208TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant208TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant208TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant208TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant208TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant208TrustedIps.Production,
                _ => null,
            };
        }
    }
}