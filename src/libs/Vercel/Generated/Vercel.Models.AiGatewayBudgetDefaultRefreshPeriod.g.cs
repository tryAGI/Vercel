
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AiGatewayBudgetDefaultRefreshPeriod
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
    public static class AiGatewayBudgetDefaultRefreshPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayBudgetDefaultRefreshPeriod value)
        {
            return value switch
            {
                AiGatewayBudgetDefaultRefreshPeriod.Daily => "daily",
                AiGatewayBudgetDefaultRefreshPeriod.Monthly => "monthly",
                AiGatewayBudgetDefaultRefreshPeriod.None => "none",
                AiGatewayBudgetDefaultRefreshPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayBudgetDefaultRefreshPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => AiGatewayBudgetDefaultRefreshPeriod.Daily,
                "monthly" => AiGatewayBudgetDefaultRefreshPeriod.Monthly,
                "none" => AiGatewayBudgetDefaultRefreshPeriod.None,
                "weekly" => AiGatewayBudgetDefaultRefreshPeriod.Weekly,
                _ => null,
            };
        }
    }
}