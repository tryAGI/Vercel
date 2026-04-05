
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCheckResponseStatus
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
    public static class GetCheckResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCheckResponseStatus value)
        {
            return value switch
            {
                GetCheckResponseStatus.Completed => "completed",
                GetCheckResponseStatus.Registered => "registered",
                GetCheckResponseStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCheckResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetCheckResponseStatus.Completed,
                "registered" => GetCheckResponseStatus.Registered,
                "running" => GetCheckResponseStatus.Running,
                _ => null,
            };
        }
    }
}