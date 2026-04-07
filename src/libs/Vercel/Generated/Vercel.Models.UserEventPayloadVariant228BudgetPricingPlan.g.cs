
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant228BudgetPricingPlan
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
    public static class UserEventPayloadVariant228BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant228BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant228BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant228BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant228BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant228BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant228BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant228BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant228BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant228BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant228BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}