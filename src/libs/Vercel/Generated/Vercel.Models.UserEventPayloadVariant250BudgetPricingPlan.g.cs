
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant250BudgetPricingPlan
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
    public static class UserEventPayloadVariant250BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant250BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant250BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant250BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant250BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant250BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant250BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant250BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant250BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant250BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant250BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}