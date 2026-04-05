
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateResourceRequestBillingPlanType
    {
        /// <summary>
        /// 
        /// </summary>
        Prepayment,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateResourceRequestBillingPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResourceRequestBillingPlanType value)
        {
            return value switch
            {
                UpdateResourceRequestBillingPlanType.Prepayment => "prepayment",
                UpdateResourceRequestBillingPlanType.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResourceRequestBillingPlanType? ToEnum(string value)
        {
            return value switch
            {
                "prepayment" => UpdateResourceRequestBillingPlanType.Prepayment,
                "subscription" => UpdateResourceRequestBillingPlanType.Subscription,
                _ => null,
            };
        }
    }
}