
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRollingReleaseBillingStatusResponseVariant1Reason
    {
        /// <summary>
        /// 
        /// </summary>
        PlanNotSupported,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRollingReleaseBillingStatusResponseVariant1ReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseBillingStatusResponseVariant1Reason value)
        {
            return value switch
            {
                GetRollingReleaseBillingStatusResponseVariant1Reason.PlanNotSupported => "plan_not_supported",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseBillingStatusResponseVariant1Reason? ToEnum(string value)
        {
            return value switch
            {
                "plan_not_supported" => GetRollingReleaseBillingStatusResponseVariant1Reason.PlanNotSupported,
                _ => null,
            };
        }
    }
}