
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant234BudgetPricingPlan
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
    public static class UserEventPayloadVariant234BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant234BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant234BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant234BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant234BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant234BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant234BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant234BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant234BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant234BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant234BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}