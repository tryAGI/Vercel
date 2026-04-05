
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRollingReleaseBillingStatusResponseVariant2AvailableSlots
    {
        /// <summary>
        /// 
        /// </summary>
        Unlimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRollingReleaseBillingStatusResponseVariant2AvailableSlotsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseBillingStatusResponseVariant2AvailableSlots value)
        {
            return value switch
            {
                GetRollingReleaseBillingStatusResponseVariant2AvailableSlots.Unlimited => "unlimited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseBillingStatusResponseVariant2AvailableSlots? ToEnum(string value)
        {
            return value switch
            {
                "unlimited" => GetRollingReleaseBillingStatusResponseVariant2AvailableSlots.Unlimited,
                _ => null,
            };
        }
    }
}