
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpsertAiGatewayBudgetDefaultRequestRefreshPeriod
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
    public static class UpsertAiGatewayBudgetDefaultRequestRefreshPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertAiGatewayBudgetDefaultRequestRefreshPeriod value)
        {
            return value switch
            {
                UpsertAiGatewayBudgetDefaultRequestRefreshPeriod.Daily => "daily",
                UpsertAiGatewayBudgetDefaultRequestRefreshPeriod.Monthly => "monthly",
                UpsertAiGatewayBudgetDefaultRequestRefreshPeriod.None => "none",
                UpsertAiGatewayBudgetDefaultRequestRefreshPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertAiGatewayBudgetDefaultRequestRefreshPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => UpsertAiGatewayBudgetDefaultRequestRefreshPeriod.Daily,
                "monthly" => UpsertAiGatewayBudgetDefaultRequestRefreshPeriod.Monthly,
                "none" => UpsertAiGatewayBudgetDefaultRequestRefreshPeriod.None,
                "weekly" => UpsertAiGatewayBudgetDefaultRequestRefreshPeriod.Weekly,
                _ => null,
            };
        }
    }
}