
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The acive pricing plan the team is billed with
    /// </summary>
    public enum UserEventPayloadVariant237BudgetPricingPlan
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
    public static class UserEventPayloadVariant237BudgetPricingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant237BudgetPricingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant237BudgetPricingPlan.Legacy => "legacy",
                UserEventPayloadVariant237BudgetPricingPlan.Platform => "platform",
                UserEventPayloadVariant237BudgetPricingPlan.Plus => "plus",
                UserEventPayloadVariant237BudgetPricingPlan.Unbundled => "unbundled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant237BudgetPricingPlan? ToEnum(string value)
        {
            return value switch
            {
                "legacy" => UserEventPayloadVariant237BudgetPricingPlan.Legacy,
                "platform" => UserEventPayloadVariant237BudgetPricingPlan.Platform,
                "plus" => UserEventPayloadVariant237BudgetPricingPlan.Plus,
                "unbundled" => UserEventPayloadVariant237BudgetPricingPlan.Unbundled,
                _ => null,
            };
        }
    }
}