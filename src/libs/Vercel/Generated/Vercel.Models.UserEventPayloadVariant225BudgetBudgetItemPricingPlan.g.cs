
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant225BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant225BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant225BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant225BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant225BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant225BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant225BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant225BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant225BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant225BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant225BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant225BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}