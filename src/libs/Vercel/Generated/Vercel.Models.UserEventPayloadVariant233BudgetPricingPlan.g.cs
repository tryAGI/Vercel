
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant233BudgetPricingPlan
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
    public static class UserEventPayloadVariant233BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant233BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant233BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant233BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant233BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant233BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant233BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant233BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant233BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant233BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant233BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}