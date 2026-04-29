
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant249BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant249BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant249BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant249BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant249BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant249BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant249BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant249BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant249BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant249BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant249BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant249BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}