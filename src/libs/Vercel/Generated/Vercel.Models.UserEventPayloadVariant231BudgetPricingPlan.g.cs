
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant231BudgetPricingPlan
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
    public static class UserEventPayloadVariant231BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant231BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant231BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant231BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant231BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant231BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant231BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant231BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant231BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant231BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant231BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}