
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant240BudgetPricingPlan
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
    public static class UserEventPayloadVariant240BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant240BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant240BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant240BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant240BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant240BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant240BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant240BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant240BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant240BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant240BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}