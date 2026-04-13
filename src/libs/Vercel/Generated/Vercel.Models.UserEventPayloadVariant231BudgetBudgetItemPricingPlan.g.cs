
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant231BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant231BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant231BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant231BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant231BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant231BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant231BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant231BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant231BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant231BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant231BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant231BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}