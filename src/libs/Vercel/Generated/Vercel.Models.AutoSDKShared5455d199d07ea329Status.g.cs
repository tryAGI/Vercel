
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5455d199d07ea329Status
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
    public static class AutoSDKShared5455d199d07ea329StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5455d199d07ea329Status value)
        {
            return value switch
            {
                AutoSDKShared5455d199d07ea329Status.Completed => "completed",
                AutoSDKShared5455d199d07ea329Status.Queued => "queued",
                AutoSDKShared5455d199d07ea329Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5455d199d07ea329Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKShared5455d199d07ea329Status.Completed,
                "queued" => AutoSDKShared5455d199d07ea329Status.Queued,
                "running" => AutoSDKShared5455d199d07ea329Status.Running,
                _ => null,
            };
        }
    }
}