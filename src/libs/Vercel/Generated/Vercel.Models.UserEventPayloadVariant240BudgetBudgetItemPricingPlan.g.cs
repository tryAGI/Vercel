
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant240BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant240BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant240BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant240BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant240BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant240BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant240BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant240BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant240BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant240BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant240BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant240BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}