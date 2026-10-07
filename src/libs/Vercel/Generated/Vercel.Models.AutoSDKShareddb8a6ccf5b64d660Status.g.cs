
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddb8a6ccf5b64d660Status
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
    public static class AutoSDKShareddb8a6ccf5b64d660StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddb8a6ccf5b64d660Status value)
        {
            return value switch
            {
                AutoSDKShareddb8a6ccf5b64d660Status.Completed => "completed",
                AutoSDKShareddb8a6ccf5b64d660Status.Queued => "queued",
                AutoSDKShareddb8a6ccf5b64d660Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddb8a6ccf5b64d660Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKShareddb8a6ccf5b64d660Status.Completed,
                "queued" => AutoSDKShareddb8a6ccf5b64d660Status.Queued,
                "running" => AutoSDKShareddb8a6ccf5b64d660Status.Running,
                _ => null,
            };
        }
    }
}