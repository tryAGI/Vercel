
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant247BudgetBudgetItemPricingPlan
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
    public static class UserEventPayloadVariant247BudgetBudgetItemPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant247BudgetBudgetItemPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant247BudgetBudgetItemPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant247BudgetBudgetItemPricingPlan.Platform => "platform",
                UserEventPayloadVariant247BudgetBudgetItemPricingPlan.Plus => "plus",
                UserEventPayloadVariant247BudgetBudgetItemPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant247BudgetBudgetItemPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant247BudgetBudgetItemPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant247BudgetBudgetItemPricingPlan.Platform,
                "plus" => UserEventPayloadVariant247BudgetBudgetItemPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant247BudgetBudgetItemPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}