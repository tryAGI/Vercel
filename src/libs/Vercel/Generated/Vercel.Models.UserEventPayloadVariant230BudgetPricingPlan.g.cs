
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant230BudgetPricingPlan
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
    public static class UserEventPayloadVariant230BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant230BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant230BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant230BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant230BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant230BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant230BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant230BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant230BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant230BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant230BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}