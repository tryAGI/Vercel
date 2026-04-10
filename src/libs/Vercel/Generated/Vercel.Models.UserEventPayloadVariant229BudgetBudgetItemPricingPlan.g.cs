
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant229BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant229BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant229BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant229BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant229BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant229BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant229BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant229BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant229BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant229BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant229BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant229BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}