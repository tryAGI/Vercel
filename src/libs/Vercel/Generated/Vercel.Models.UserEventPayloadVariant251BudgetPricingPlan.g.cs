
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant251BudgetPricingPlan
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
    public static class UserEventPayloadVariant251BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant251BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant251BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant251BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant251BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant251BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant251BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant251BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant251BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant251BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant251BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}