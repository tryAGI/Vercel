
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant229BudgetPricingPlan
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
    public static class UserEventPayloadVariant229BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant229BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant229BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant229BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant229BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant229BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant229BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant229BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant229BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant229BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant229BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}