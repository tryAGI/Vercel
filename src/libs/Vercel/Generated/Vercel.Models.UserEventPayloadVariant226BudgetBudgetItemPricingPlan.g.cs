
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant226BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant226BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant226BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant226BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant226BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant226BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant226BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant226BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant226BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant226BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant226BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant226BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}