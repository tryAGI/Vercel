
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant211OldTrustedIps
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
    public static class UserEventPayloadVariant211OldTrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant211OldTrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant211OldTrustedIps.All => "all",
                UserEventPayloadVariant211OldTrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant211OldTrustedIps.Preview => "preview",
                UserEventPayloadVariant211OldTrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant211OldTrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant211OldTrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant211OldTrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant211OldTrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant211OldTrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant211OldTrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant211OldTrustedIps.Production,
                _ => null,
            };
        }
    }
}