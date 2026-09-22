
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0feeac66613930d1Status
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
    public static class AutoSDKShared0feeac66613930d1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0feeac66613930d1Status value)
        {
            return value switch
            {
                AutoSDKShared0feeac66613930d1Status.Completed => "completed",
                AutoSDKShared0feeac66613930d1Status.Queued => "queued",
                AutoSDKShared0feeac66613930d1Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0feeac66613930d1Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKShared0feeac66613930d1Status.Completed,
                "queued" => AutoSDKShared0feeac66613930d1Status.Queued,
                "running" => AutoSDKShared0feeac66613930d1Status.Running,
                _ => null,
            };
        }
    }
}