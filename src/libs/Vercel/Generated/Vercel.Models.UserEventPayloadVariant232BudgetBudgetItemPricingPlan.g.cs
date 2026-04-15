
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant232BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant232BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant232BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant232BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant232BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant232BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant232BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant232BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant232BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant232BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant232BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant232BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}