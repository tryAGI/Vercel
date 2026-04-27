
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant243BudgetPricingPlan
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
    public static class UserEventPayloadVariant243BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant243BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant243BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant243BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant243BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant243BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant243BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant243BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant243BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant243BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant243BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}