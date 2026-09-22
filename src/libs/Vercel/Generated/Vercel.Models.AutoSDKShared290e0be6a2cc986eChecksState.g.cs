
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared290e0be6a2cc986eChecksState
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Registered,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared290e0be6a2cc986eChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared290e0be6a2cc986eChecksState value)
        {
            return value switch
            {
                AutoSDKShared290e0be6a2cc986eChecksState.Completed => "completed",
                AutoSDKShared290e0be6a2cc986eChecksState.Registered => "registered",
                AutoSDKShared290e0be6a2cc986eChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared290e0be6a2cc986eChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKShared290e0be6a2cc986eChecksState.Completed,
                "registered" => AutoSDKShared290e0be6a2cc986eChecksState.Registered,
                "running" => AutoSDKShared290e0be6a2cc986eChecksState.Running,
                _ => null,
            };
        }
    }
}