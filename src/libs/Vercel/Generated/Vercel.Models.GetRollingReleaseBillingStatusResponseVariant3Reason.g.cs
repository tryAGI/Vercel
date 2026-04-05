
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRollingReleaseBillingStatusResponseVariant3Reason
    {
        /// <summary>
        /// 
        /// </summary>
        NoAvailableSlots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRollingReleaseBillingStatusResponseVariant3ReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseBillingStatusResponseVariant3Reason value)
        {
            return value switch
            {
                GetRollingReleaseBillingStatusResponseVariant3Reason.NoAvailableSlots => "no_available_slots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseBillingStatusResponseVariant3Reason? ToEnum(string value)
        {
            return value switch
            {
                "no_available_slots" => GetRollingReleaseBillingStatusResponseVariant3Reason.NoAvailableSlots,
                _ => null,
            };
        }
    }
}