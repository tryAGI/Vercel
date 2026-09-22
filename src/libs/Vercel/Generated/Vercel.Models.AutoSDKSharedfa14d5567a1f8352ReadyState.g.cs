
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum AutoSDKSharedfa14d5567a1f8352ReadyState
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
    public static class AutoSDKSharedfa14d5567a1f8352ReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa14d5567a1f8352ReadyState value)
        {
            return value switch
            {
                AutoSDKSharedfa14d5567a1f8352ReadyState.Blocked => "BLOCKED",
                AutoSDKSharedfa14d5567a1f8352ReadyState.Building => "BUILDING",
                AutoSDKSharedfa14d5567a1f8352ReadyState.Canceled => "CANCELED",
                AutoSDKSharedfa14d5567a1f8352ReadyState.Error => "ERROR",
                AutoSDKSharedfa14d5567a1f8352ReadyState.Initializing => "INITIALIZING",
                AutoSDKSharedfa14d5567a1f8352ReadyState.Queued => "QUEUED",
                AutoSDKSharedfa14d5567a1f8352ReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa14d5567a1f8352ReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => AutoSDKSharedfa14d5567a1f8352ReadyState.Blocked,
                "BUILDING" => AutoSDKSharedfa14d5567a1f8352ReadyState.Building,
                "CANCELED" => AutoSDKSharedfa14d5567a1f8352ReadyState.Canceled,
                "ERROR" => AutoSDKSharedfa14d5567a1f8352ReadyState.Error,
                "INITIALIZING" => AutoSDKSharedfa14d5567a1f8352ReadyState.Initializing,
                "QUEUED" => AutoSDKSharedfa14d5567a1f8352ReadyState.Queued,
                "READY" => AutoSDKSharedfa14d5567a1f8352ReadyState.Ready,
                _ => null,
            };
        }
    }
}