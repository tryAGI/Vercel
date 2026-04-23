
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant239BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant239BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant239BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant239BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant239BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant239BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant239BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant239BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant239BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant239BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant239BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant239BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}