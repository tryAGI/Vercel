
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant239BudgetPricingPlan
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
    public static class UserEventPayloadVariant239BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant239BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant239BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant239BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant239BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant239BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant239BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant239BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant239BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant239BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant239BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}