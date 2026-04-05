
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant208OldTrustedIps
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
    public static class UserEventPayloadVariant208OldTrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant208OldTrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant208OldTrustedIps.All => "all",
                UserEventPayloadVariant208OldTrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant208OldTrustedIps.Preview => "preview",
                UserEventPayloadVariant208OldTrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant208OldTrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant208OldTrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant208OldTrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant208OldTrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant208OldTrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant208OldTrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant208OldTrustedIps.Production,
                _ => null,
            };
        }
    }
}