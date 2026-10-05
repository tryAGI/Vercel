
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared87d88207314b07b3Status
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
    public static class AutoSDKShared87d88207314b07b3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared87d88207314b07b3Status value)
        {
            return value switch
            {
                AutoSDKShared87d88207314b07b3Status.Completed => "completed",
                AutoSDKShared87d88207314b07b3Status.Queued => "queued",
                AutoSDKShared87d88207314b07b3Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared87d88207314b07b3Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKShared87d88207314b07b3Status.Completed,
                "queued" => AutoSDKShared87d88207314b07b3Status.Queued,
                "running" => AutoSDKShared87d88207314b07b3Status.Running,
                _ => null,
            };
        }
    }
}