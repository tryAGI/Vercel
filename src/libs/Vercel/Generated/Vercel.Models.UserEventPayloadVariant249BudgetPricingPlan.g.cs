
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant249BudgetPricingPlan
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
    public static class UserEventPayloadVariant249BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant249BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant249BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant249BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant249BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant249BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant249BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant249BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant249BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant249BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant249BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}