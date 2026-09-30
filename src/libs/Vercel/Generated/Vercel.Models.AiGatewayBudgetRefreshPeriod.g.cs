
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AiGatewayBudgetRefreshPeriod
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
    public static class AiGatewayBudgetRefreshPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayBudgetRefreshPeriod value)
        {
            return value switch
            {
                AiGatewayBudgetRefreshPeriod.Daily => "daily",
                AiGatewayBudgetRefreshPeriod.Monthly => "monthly",
                AiGatewayBudgetRefreshPeriod.None => "none",
                AiGatewayBudgetRefreshPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayBudgetRefreshPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => AiGatewayBudgetRefreshPeriod.Daily,
                "monthly" => AiGatewayBudgetRefreshPeriod.Monthly,
                "none" => AiGatewayBudgetRefreshPeriod.None,
                "weekly" => AiGatewayBudgetRefreshPeriod.Weekly,
                _ => null,
            };
        }
    }
}