
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant227BudgetPricingPlan
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
    public static class UserEventPayloadVariant227BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant227BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant227BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant227BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant227BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant227BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant227BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant227BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant227BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant227BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant227BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}