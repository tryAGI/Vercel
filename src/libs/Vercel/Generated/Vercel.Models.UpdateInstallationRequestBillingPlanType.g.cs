
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateInstallationRequestBillingPlanType
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
    public static class UpdateInstallationRequestBillingPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInstallationRequestBillingPlanType value)
        {
            return value switch
            {
                UpdateInstallationRequestBillingPlanType.Prepayment => "prepayment",
                UpdateInstallationRequestBillingPlanType.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInstallationRequestBillingPlanType? ToEnum(string value)
        {
            return value switch
            {
                "prepayment" => UpdateInstallationRequestBillingPlanType.Prepayment,
                "subscription" => UpdateInstallationRequestBillingPlanType.Subscription,
                _ => null,
            };
        }
    }
}