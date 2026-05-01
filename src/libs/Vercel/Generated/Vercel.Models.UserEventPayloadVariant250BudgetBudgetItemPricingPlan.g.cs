
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant250BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant250BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant250BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant250BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant250BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant250BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant250BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant250BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant250BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant250BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant250BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant250BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}