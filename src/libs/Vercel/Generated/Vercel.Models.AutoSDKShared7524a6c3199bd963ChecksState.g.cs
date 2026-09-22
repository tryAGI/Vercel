
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7524a6c3199bd963ChecksState
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
    public static class AutoSDKShared7524a6c3199bd963ChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7524a6c3199bd963ChecksState value)
        {
            return value switch
            {
                AutoSDKShared7524a6c3199bd963ChecksState.Completed => "completed",
                AutoSDKShared7524a6c3199bd963ChecksState.Registered => "registered",
                AutoSDKShared7524a6c3199bd963ChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7524a6c3199bd963ChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKShared7524a6c3199bd963ChecksState.Completed,
                "registered" => AutoSDKShared7524a6c3199bd963ChecksState.Registered,
                "running" => AutoSDKShared7524a6c3199bd963ChecksState.Running,
                _ => null,
            };
        }
    }
}