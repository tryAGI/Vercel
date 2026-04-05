
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant226BudgetPricingPlan
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
    public static class UserEventPayloadVariant226BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant226BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant226BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant226BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant226BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant226BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant226BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant226BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant226BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant226BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant226BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}