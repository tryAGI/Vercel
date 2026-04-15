
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant238BudgetPricingPlan
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
    public static class UserEventPayloadVariant238BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant238BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant238BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant238BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant238BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant238BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant238BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant238BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant238BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant238BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant238BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}