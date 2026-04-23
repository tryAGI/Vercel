
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant241BudgetPricingPlan
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
    public static class UserEventPayloadVariant241BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant241BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant241BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant241BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant241BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant241BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant241BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant241BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant241BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant241BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant241BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}