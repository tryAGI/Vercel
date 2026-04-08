
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant210OldTrustedIps
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
    public static class UserEventPayloadVariant210OldTrustedIpsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant210OldTrustedIps value)
        {
            return value switch
            {
                UserEventPayloadVariant210OldTrustedIps.All => "all",
                UserEventPayloadVariant210OldTrustedIps.AllExceptCustomDomains => "all_except_custom_domains",
                UserEventPayloadVariant210OldTrustedIps.Preview => "preview",
                UserEventPayloadVariant210OldTrustedIps.ProdDeploymentUrlsAndAllPreviews => "prod_deployment_urls_and_all_previews",
                UserEventPayloadVariant210OldTrustedIps.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant210OldTrustedIps? ToEnum(string value)
        {
            return value switch
            {
                "all" => UserEventPayloadVariant210OldTrustedIps.All,
                "all_except_custom_domains" => UserEventPayloadVariant210OldTrustedIps.AllExceptCustomDomains,
                "preview" => UserEventPayloadVariant210OldTrustedIps.Preview,
                "prod_deployment_urls_and_all_previews" => UserEventPayloadVariant210OldTrustedIps.ProdDeploymentUrlsAndAllPreviews,
                "production" => UserEventPayloadVariant210OldTrustedIps.Production,
                _ => null,
            };
        }
    }
}