
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The current status of the check
    /// </summary>
    public enum UpdateCheckRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckRequestStatus value)
        {
            return value switch
            {
                UpdateCheckRequestStatus.Completed => "completed",
                UpdateCheckRequestStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UpdateCheckRequestStatus.Completed,
                "running" => UpdateCheckRequestStatus.Running,
                _ => null,
            };
        }
    }
}