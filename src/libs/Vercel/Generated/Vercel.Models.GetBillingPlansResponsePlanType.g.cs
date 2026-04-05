
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBillingPlansResponsePlanType
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
    public static class GetBillingPlansResponsePlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBillingPlansResponsePlanType value)
        {
            return value switch
            {
                GetBillingPlansResponsePlanType.Prepayment => "prepayment",
                GetBillingPlansResponsePlanType.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBillingPlansResponsePlanType? ToEnum(string value)
        {
            return value switch
            {
                "prepayment" => GetBillingPlansResponsePlanType.Prepayment,
                "subscription" => GetBillingPlansResponsePlanType.Subscription,
                _ => null,
            };
        }
    }
}