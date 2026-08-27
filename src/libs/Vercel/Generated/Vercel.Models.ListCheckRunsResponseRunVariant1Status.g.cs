
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListCheckRunsResponseRunVariant1Status
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
    public static class ListCheckRunsResponseRunVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCheckRunsResponseRunVariant1Status value)
        {
            return value switch
            {
                ListCheckRunsResponseRunVariant1Status.Completed => "completed",
                ListCheckRunsResponseRunVariant1Status.Queued => "queued",
                ListCheckRunsResponseRunVariant1Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCheckRunsResponseRunVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListCheckRunsResponseRunVariant1Status.Completed,
                "queued" => ListCheckRunsResponseRunVariant1Status.Queued,
                "running" => ListCheckRunsResponseRunVariant1Status.Running,
                _ => null,
            };
        }
    }
}