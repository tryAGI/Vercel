
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant253BudgetPricingPlan
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
    public static class UserEventPayloadVariant253BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant253BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant253BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant253BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant253BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant253BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant253BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant253BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant253BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant253BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant253BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}