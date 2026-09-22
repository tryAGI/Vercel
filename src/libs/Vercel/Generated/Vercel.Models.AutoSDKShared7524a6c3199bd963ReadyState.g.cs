
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7524a6c3199bd963ReadyState
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        Building,
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Initializing,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7524a6c3199bd963ReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7524a6c3199bd963ReadyState value)
        {
            return value switch
            {
                AutoSDKShared7524a6c3199bd963ReadyState.Blocked => "BLOCKED",
                AutoSDKShared7524a6c3199bd963ReadyState.Building => "BUILDING",
                AutoSDKShared7524a6c3199bd963ReadyState.Canceled => "CANCELED",
                AutoSDKShared7524a6c3199bd963ReadyState.Error => "ERROR",
                AutoSDKShared7524a6c3199bd963ReadyState.Initializing => "INITIALIZING",
                AutoSDKShared7524a6c3199bd963ReadyState.Queued => "QUEUED",
                AutoSDKShared7524a6c3199bd963ReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7524a6c3199bd963ReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => AutoSDKShared7524a6c3199bd963ReadyState.Blocked,
                "BUILDING" => AutoSDKShared7524a6c3199bd963ReadyState.Building,
                "CANCELED" => AutoSDKShared7524a6c3199bd963ReadyState.Canceled,
                "ERROR" => AutoSDKShared7524a6c3199bd963ReadyState.Error,
                "INITIALIZING" => AutoSDKShared7524a6c3199bd963ReadyState.Initializing,
                "QUEUED" => AutoSDKShared7524a6c3199bd963ReadyState.Queued,
                "READY" => AutoSDKShared7524a6c3199bd963ReadyState.Ready,
                _ => null,
            };
        }
    }
}