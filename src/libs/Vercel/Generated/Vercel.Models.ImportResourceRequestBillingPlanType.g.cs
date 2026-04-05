
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportResourceRequestBillingPlanType
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
    public static class ImportResourceRequestBillingPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportResourceRequestBillingPlanType value)
        {
            return value switch
            {
                ImportResourceRequestBillingPlanType.Prepayment => "prepayment",
                ImportResourceRequestBillingPlanType.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportResourceRequestBillingPlanType? ToEnum(string value)
        {
            return value switch
            {
                "prepayment" => ImportResourceRequestBillingPlanType.Prepayment,
                "subscription" => ImportResourceRequestBillingPlanType.Subscription,
                _ => null,
            };
        }
    }
}