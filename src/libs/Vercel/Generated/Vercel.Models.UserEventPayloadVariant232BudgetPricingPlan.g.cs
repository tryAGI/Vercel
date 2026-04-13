
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant232BudgetPricingPlan
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
    public static class UserEventPayloadVariant232BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant232BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant232BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant232BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant232BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant232BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant232BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant232BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant232BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant232BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant232BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}