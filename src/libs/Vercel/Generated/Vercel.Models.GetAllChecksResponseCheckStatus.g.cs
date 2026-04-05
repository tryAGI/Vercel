
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllChecksResponseCheckStatus
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
    public static class GetAllChecksResponseCheckStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChecksResponseCheckStatus value)
        {
            return value switch
            {
                GetAllChecksResponseCheckStatus.Completed => "completed",
                GetAllChecksResponseCheckStatus.Registered => "registered",
                GetAllChecksResponseCheckStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChecksResponseCheckStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetAllChecksResponseCheckStatus.Completed,
                "registered" => GetAllChecksResponseCheckStatus.Registered,
                "running" => GetAllChecksResponseCheckStatus.Running,
                _ => null,
            };
        }
    }
}