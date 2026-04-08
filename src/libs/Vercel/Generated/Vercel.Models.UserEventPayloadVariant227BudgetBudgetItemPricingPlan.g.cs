
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant227BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant227BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant227BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant227BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant227BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant227BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant227BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant227BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant227BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant227BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant227BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant227BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}