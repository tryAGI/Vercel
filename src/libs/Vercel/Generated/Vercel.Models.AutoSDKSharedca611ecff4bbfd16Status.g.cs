
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedca611ecff4bbfd16Status
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
    public static class AutoSDKSharedca611ecff4bbfd16StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedca611ecff4bbfd16Status value)
        {
            return value switch
            {
                AutoSDKSharedca611ecff4bbfd16Status.Completed => "completed",
                AutoSDKSharedca611ecff4bbfd16Status.Queued => "queued",
                AutoSDKSharedca611ecff4bbfd16Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedca611ecff4bbfd16Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKSharedca611ecff4bbfd16Status.Completed,
                "queued" => AutoSDKSharedca611ecff4bbfd16Status.Queued,
                "running" => AutoSDKSharedca611ecff4bbfd16Status.Running,
                _ => null,
            };
        }
    }
}