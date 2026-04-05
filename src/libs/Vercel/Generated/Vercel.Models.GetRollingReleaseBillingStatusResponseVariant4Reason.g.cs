
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRollingReleaseBillingStatusResponseVariant4Reason
    {
        /// <summary>
        /// 
        /// </summary>
        AvailableSlots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRollingReleaseBillingStatusResponseVariant4ReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseBillingStatusResponseVariant4Reason value)
        {
            return value switch
            {
                GetRollingReleaseBillingStatusResponseVariant4Reason.AvailableSlots => "available_slots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseBillingStatusResponseVariant4Reason? ToEnum(string value)
        {
            return value switch
            {
                "available_slots" => GetRollingReleaseBillingStatusResponseVariant4Reason.AvailableSlots,
                _ => null,
            };
        }
    }
}