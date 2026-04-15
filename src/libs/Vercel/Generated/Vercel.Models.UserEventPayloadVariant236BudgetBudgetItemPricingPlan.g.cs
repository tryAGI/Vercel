
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant236BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant236BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant236BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant236BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant236BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant236BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant236BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant236BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant236BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant236BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant236BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant236BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}