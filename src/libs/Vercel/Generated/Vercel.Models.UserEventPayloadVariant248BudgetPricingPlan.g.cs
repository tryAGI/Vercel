
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant248BudgetPricingPlan
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
    public static class UserEventPayloadVariant248BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant248BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant248BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant248BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant248BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant248BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant248BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant248BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant248BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant248BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant248BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}