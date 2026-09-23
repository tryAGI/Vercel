
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8422af433e1bf486ChecksState
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
    public static class AutoSDKShared8422af433e1bf486ChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8422af433e1bf486ChecksState value)
        {
            return value switch
            {
                AutoSDKShared8422af433e1bf486ChecksState.Completed => "completed",
                AutoSDKShared8422af433e1bf486ChecksState.Registered => "registered",
                AutoSDKShared8422af433e1bf486ChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8422af433e1bf486ChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKShared8422af433e1bf486ChecksState.Completed,
                "registered" => AutoSDKShared8422af433e1bf486ChecksState.Registered,
                "running" => AutoSDKShared8422af433e1bf486ChecksState.Running,
                _ => null,
            };
        }
    }
}