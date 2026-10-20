
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede3c00aaf9d3a15beStatus
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
    public static class AutoSDKSharede3c00aaf9d3a15beStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede3c00aaf9d3a15beStatus value)
        {
            return value switch
            {
                AutoSDKSharede3c00aaf9d3a15beStatus.Completed => "completed",
                AutoSDKSharede3c00aaf9d3a15beStatus.Queued => "queued",
                AutoSDKSharede3c00aaf9d3a15beStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede3c00aaf9d3a15beStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKSharede3c00aaf9d3a15beStatus.Completed,
                "queued" => AutoSDKSharede3c00aaf9d3a15beStatus.Queued,
                "running" => AutoSDKSharede3c00aaf9d3a15beStatus.Running,
                _ => null,
            };
        }
    }
}