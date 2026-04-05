
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The status of the Network.
    /// </summary>
    public enum NetworkStatus
    {
        /// <summary>
        /// 
        /// </summary>
        CreateInProgress,
        /// <summary>
        /// 
        /// </summary>
        DeleteInProgress,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NetworkStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NetworkStatus value)
        {
            return value switch
            {
                NetworkStatus.CreateInProgress => "create_in_progress",
                NetworkStatus.DeleteInProgress => "delete_in_progress",
                NetworkStatus.Error => "error",
                NetworkStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NetworkStatus? ToEnum(string value)
        {
            return value switch
            {
                "create_in_progress" => NetworkStatus.CreateInProgress,
                "delete_in_progress" => NetworkStatus.DeleteInProgress,
                "error" => NetworkStatus.Error,
                "ready" => NetworkStatus.Ready,
                _ => null,
            };
        }
    }
}