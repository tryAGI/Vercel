
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared290e0be6a2cc986eReadyState
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
    public static class AutoSDKShared290e0be6a2cc986eReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared290e0be6a2cc986eReadyState value)
        {
            return value switch
            {
                AutoSDKShared290e0be6a2cc986eReadyState.Blocked => "BLOCKED",
                AutoSDKShared290e0be6a2cc986eReadyState.Building => "BUILDING",
                AutoSDKShared290e0be6a2cc986eReadyState.Canceled => "CANCELED",
                AutoSDKShared290e0be6a2cc986eReadyState.Error => "ERROR",
                AutoSDKShared290e0be6a2cc986eReadyState.Initializing => "INITIALIZING",
                AutoSDKShared290e0be6a2cc986eReadyState.Queued => "QUEUED",
                AutoSDKShared290e0be6a2cc986eReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared290e0be6a2cc986eReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => AutoSDKShared290e0be6a2cc986eReadyState.Blocked,
                "BUILDING" => AutoSDKShared290e0be6a2cc986eReadyState.Building,
                "CANCELED" => AutoSDKShared290e0be6a2cc986eReadyState.Canceled,
                "ERROR" => AutoSDKShared290e0be6a2cc986eReadyState.Error,
                "INITIALIZING" => AutoSDKShared290e0be6a2cc986eReadyState.Initializing,
                "QUEUED" => AutoSDKShared290e0be6a2cc986eReadyState.Queued,
                "READY" => AutoSDKShared290e0be6a2cc986eReadyState.Ready,
                _ => null,
            };
        }
    }
}