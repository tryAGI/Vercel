
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant233OldTrustedIps
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
    public static class UserEventPayloadVariant233OldTrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant233OldTrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant233OldTrustedIps.All => "all",
                UserEventPayloadVariant233OldTrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant233OldTrustedIps.Preview => "preview",
                UserEventPayloadVariant233OldTrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant233OldTrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant233OldTrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant233OldTrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant233OldTrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant233OldTrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant233OldTrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant233OldTrustedIps.Production,
                _ => null,
            };
        }
    }
}