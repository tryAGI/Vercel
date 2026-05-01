
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant252BudgetPricingPlan
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
    public static class UserEventPayloadVariant252BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant252BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant252BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant252BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant252BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant252BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant252BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant252BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant252BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant252BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant252BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}