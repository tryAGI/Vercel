
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant242BudgetPricingPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Legacy,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Unbundled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant242BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant242BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant242BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant242BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant242BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant242BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant242BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant242BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant242BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant242BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant242BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}