
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant237BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant237BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant237BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant237BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant237BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant237BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant237BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant237BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant237BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant237BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant237BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant237BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}