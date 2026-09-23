
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbca3e7a986162538ReadyState
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
    public static class AutoSDKSharedbca3e7a986162538ReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbca3e7a986162538ReadyState value)
        {
            return value switch
            {
                AutoSDKSharedbca3e7a986162538ReadyState.Blocked => "BLOCKED",
                AutoSDKSharedbca3e7a986162538ReadyState.Building => "BUILDING",
                AutoSDKSharedbca3e7a986162538ReadyState.Canceled => "CANCELED",
                AutoSDKSharedbca3e7a986162538ReadyState.Error => "ERROR",
                AutoSDKSharedbca3e7a986162538ReadyState.Initializing => "INITIALIZING",
                AutoSDKSharedbca3e7a986162538ReadyState.Queued => "QUEUED",
                AutoSDKSharedbca3e7a986162538ReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbca3e7a986162538ReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => AutoSDKSharedbca3e7a986162538ReadyState.Blocked,
                "BUILDING" => AutoSDKSharedbca3e7a986162538ReadyState.Building,
                "CANCELED" => AutoSDKSharedbca3e7a986162538ReadyState.Canceled,
                "ERROR" => AutoSDKSharedbca3e7a986162538ReadyState.Error,
                "INITIALIZING" => AutoSDKSharedbca3e7a986162538ReadyState.Initializing,
                "QUEUED" => AutoSDKSharedbca3e7a986162538ReadyState.Queued,
                "READY" => AutoSDKSharedbca3e7a986162538ReadyState.Ready,
                _ => null,
            };
        }
    }
}