
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant213TrustedIps
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
    public static class UserEventPayloadVariant213TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant213TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant213TrustedIps.All => "all",
                UserEventPayloadVariant213TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant213TrustedIps.Preview => "preview",
                UserEventPayloadVariant213TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant213TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant213TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant213TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant213TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant213TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant213TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant213TrustedIps.Production,
                _ => null,
            };
        }
    }
}