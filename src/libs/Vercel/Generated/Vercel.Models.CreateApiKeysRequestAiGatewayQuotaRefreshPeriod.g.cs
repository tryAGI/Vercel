
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How often the quota refreshes.<br/>
    /// Default Value: none
    /// </summary>
    public enum CreateApiKeysRequestAiGatewayQuotaRefreshPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
        /// <summary>
        /// 
        /// </summary>
        Monthly,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateApiKeysRequestAiGatewayQuotaRefreshPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeysRequestAiGatewayQuotaRefreshPeriod value)
        {
            return value switch
            {
                CreateApiKeysRequestAiGatewayQuotaRefreshPeriod.Daily => "daily",
                CreateApiKeysRequestAiGatewayQuotaRefreshPeriod.Monthly => "monthly",
                CreateApiKeysRequestAiGatewayQuotaRefreshPeriod.None => "none",
                CreateApiKeysRequestAiGatewayQuotaRefreshPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeysRequestAiGatewayQuotaRefreshPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => CreateApiKeysRequestAiGatewayQuotaRefreshPeriod.Daily,
                "monthly" => CreateApiKeysRequestAiGatewayQuotaRefreshPeriod.Monthly,
                "none" => CreateApiKeysRequestAiGatewayQuotaRefreshPeriod.None,
                "weekly" => CreateApiKeysRequestAiGatewayQuotaRefreshPeriod.Weekly,
                _ => null,
            };
        }
    }
}