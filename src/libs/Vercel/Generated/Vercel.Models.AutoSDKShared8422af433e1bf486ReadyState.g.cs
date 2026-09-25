
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8422af433e1bf486ReadyState
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
    public static class AutoSDKShared8422af433e1bf486ReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8422af433e1bf486ReadyState value)
        {
            return value switch
            {
                AutoSDKShared8422af433e1bf486ReadyState.Blocked => "BLOCKED",
                AutoSDKShared8422af433e1bf486ReadyState.Building => "BUILDING",
                AutoSDKShared8422af433e1bf486ReadyState.Canceled => "CANCELED",
                AutoSDKShared8422af433e1bf486ReadyState.Error => "ERROR",
                AutoSDKShared8422af433e1bf486ReadyState.Initializing => "INITIALIZING",
                AutoSDKShared8422af433e1bf486ReadyState.Queued => "QUEUED",
                AutoSDKShared8422af433e1bf486ReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8422af433e1bf486ReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => AutoSDKShared8422af433e1bf486ReadyState.Blocked,
                "BUILDING" => AutoSDKShared8422af433e1bf486ReadyState.Building,
                "CANCELED" => AutoSDKShared8422af433e1bf486ReadyState.Canceled,
                "ERROR" => AutoSDKShared8422af433e1bf486ReadyState.Error,
                "INITIALIZING" => AutoSDKShared8422af433e1bf486ReadyState.Initializing,
                "QUEUED" => AutoSDKShared8422af433e1bf486ReadyState.Queued,
                "READY" => AutoSDKShared8422af433e1bf486ReadyState.Ready,
                _ => null,
            };
        }
    }
}