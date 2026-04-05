
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCheckResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Registered,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCheckResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCheckResponseStatus value)
        {
            return value switch
            {
                UpdateCheckResponseStatus.Completed => "completed",
                UpdateCheckResponseStatus.Registered => "registered",
                UpdateCheckResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCheckResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UpdateCheckResponseStatus.Completed,
                "registered" => UpdateCheckResponseStatus.Registered,
                "running" => UpdateCheckResponseStatus.Running,
                _ => null,
            };
        }
    }
}