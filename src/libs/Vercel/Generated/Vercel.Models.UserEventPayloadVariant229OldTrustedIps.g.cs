
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant229OldTrustedIps
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
    public static class UserEventPayloadVariant229OldTrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant229OldTrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant229OldTrustedIps.All => "all",
                UserEventPayloadVariant229OldTrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant229OldTrustedIps.Preview => "preview",
                UserEventPayloadVariant229OldTrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant229OldTrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant229OldTrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant229OldTrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant229OldTrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant229OldTrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant229OldTrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant229OldTrustedIps.Production,
                _ => null,
            };
        }
    }
}