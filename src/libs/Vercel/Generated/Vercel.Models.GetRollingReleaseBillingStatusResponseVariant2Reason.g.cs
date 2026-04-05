
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRollingReleaseBillingStatusResponseVariant2Reason
    {
        /// <summary>
        /// 
        /// </summary>
        UnlimitedSlots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRollingReleaseBillingStatusResponseVariant2ReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseBillingStatusResponseVariant2Reason value)
        {
            return value switch
            {
                GetRollingReleaseBillingStatusResponseVariant2Reason.UnlimitedSlots => "unlimited_slots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseBillingStatusResponseVariant2Reason? ToEnum(string value)
        {
            return value switch
            {
                "unlimited_slots" => GetRollingReleaseBillingStatusResponseVariant2Reason.UnlimitedSlots,
                _ => null,
            };
        }
    }
}