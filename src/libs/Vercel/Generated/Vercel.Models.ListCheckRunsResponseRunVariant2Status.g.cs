
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCheckRunsResponseRunVariant2Status
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
    public static class ListCheckRunsResponseRunVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant2Status value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant2Status.Completed => "completed",
                ListCheckRunsResponseRunVariant2Status.Queued => "queued",
                ListCheckRunsResponseRunVariant2Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListCheckRunsResponseRunVariant2Status.Completed,
                "queued" => ListCheckRunsResponseRunVariant2Status.Queued,
                "running" => ListCheckRunsResponseRunVariant2Status.Running,
                _ => null,
            };
        }
    }
}