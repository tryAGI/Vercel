
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedebbc2ea34af24e22Status
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
    public static class AutoSDKSharedebbc2ea34af24e22StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedebbc2ea34af24e22Status value)
        {
            return value switch
            {
                AutoSDKSharedebbc2ea34af24e22Status.Completed => "completed",
                AutoSDKSharedebbc2ea34af24e22Status.Queued => "queued",
                AutoSDKSharedebbc2ea34af24e22Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedebbc2ea34af24e22Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKSharedebbc2ea34af24e22Status.Completed,
                "queued" => AutoSDKSharedebbc2ea34af24e22Status.Queued,
                "running" => AutoSDKSharedebbc2ea34af24e22Status.Running,
                _ => null,
            };
        }
    }
}