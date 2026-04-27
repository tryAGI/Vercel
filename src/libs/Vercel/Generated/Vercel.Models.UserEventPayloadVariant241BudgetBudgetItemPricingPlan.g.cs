
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant241BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant241BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant241BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant241BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant241BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant241BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant241BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant241BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant241BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant241BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant241BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant241BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}