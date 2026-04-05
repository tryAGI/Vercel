
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCheckRunsResponseRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunStatus value)
        {
            return value switch
            {
                ListCheckRunsResponseRunStatus.Completed => "completed",
                ListCheckRunsResponseRunStatus.Queued => "queued",
                ListCheckRunsResponseRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListCheckRunsResponseRunStatus.Completed,
                "queued" => ListCheckRunsResponseRunStatus.Queued,
                "running" => ListCheckRunsResponseRunStatus.Running,
                _ => null,
            };
        }
    }
}