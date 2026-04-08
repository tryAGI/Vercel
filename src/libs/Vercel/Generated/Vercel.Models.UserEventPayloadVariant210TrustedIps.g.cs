
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant210TrustedIps
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
    public static class UserEventPayloadVariant210TrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant210TrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant210TrustedIps.All => "all",
                UserEventPayloadVariant210TrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant210TrustedIps.Preview => "preview",
                UserEventPayloadVariant210TrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant210TrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant210TrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant210TrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant210TrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant210TrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant210TrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant210TrustedIps.Production,
                _ => null,
            };
        }
    }
}