
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant228BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant228BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant228BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant228BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant228BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant228BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant228BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant228BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant228BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant228BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant228BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant228BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}