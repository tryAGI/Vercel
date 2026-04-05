
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainRequestStatus value)
        {
            return value switch
            {
                UpdateDrainRequestStatus.Disabled => "disabled",
                UpdateDrainRequestStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UpdateDrainRequestStatus.Disabled,
                "enabled" => UpdateDrainRequestStatus.Enabled,
                _ => null,
            };
        }
    }
}