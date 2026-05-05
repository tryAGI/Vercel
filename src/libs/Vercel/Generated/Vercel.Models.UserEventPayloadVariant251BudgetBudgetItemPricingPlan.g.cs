
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant251BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant251BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant251BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant251BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant251BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant251BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant251BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant251BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant251BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant251BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}