
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default Value: monthly
    /// </summary>
    public enum UpsertAiGatewayBudgetRequestRefreshPeriod
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
    public static class UpsertAiGatewayBudgetRequestRefreshPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertAiGatewayBudgetRequestRefreshPeriod value)
        {
            return value switch
            {
                UpsertAiGatewayBudgetRequestRefreshPeriod.Daily => "daily",
                UpsertAiGatewayBudgetRequestRefreshPeriod.Monthly => "monthly",
                UpsertAiGatewayBudgetRequestRefreshPeriod.None => "none",
                UpsertAiGatewayBudgetRequestRefreshPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertAiGatewayBudgetRequestRefreshPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => UpsertAiGatewayBudgetRequestRefreshPeriod.Daily,
                "monthly" => UpsertAiGatewayBudgetRequestRefreshPeriod.Monthly,
                "none" => UpsertAiGatewayBudgetRequestRefreshPeriod.None,
                "weekly" => UpsertAiGatewayBudgetRequestRefreshPeriod.Weekly,
                _ => null,
            };
        }
    }
}