
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant230BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant230BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant230BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant230BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant230BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant230BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant230BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant230BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant230BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant230BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant230BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant230BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}