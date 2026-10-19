
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectBoxesResponseDaemonStatus
    {
        /// <summary>
        ///
        /// </summary>
        Ready,
        /// <summary>
        ///
        /// </summary>
        Reconciling,
        /// <summary>
        ///
        /// </summary>
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectBoxesResponseDaemonStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectBoxesResponseDaemonStatus value)
        {
            return value switch
            {
                GetProjectBoxesResponseDaemonStatus.Ready => "ready",
                GetProjectBoxesResponseDaemonStatus.Reconciling => "reconciling",
                GetProjectBoxesResponseDaemonStatus.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectBoxesResponseDaemonStatus? ToEnum(string value)
        {
            return value switch
            {
                "ready" => GetProjectBoxesResponseDaemonStatus.Ready,
                "reconciling" => GetProjectBoxesResponseDaemonStatus.Reconciling,
                "stopped" => GetProjectBoxesResponseDaemonStatus.Stopped,
                _ => null,
            };
        }
    }
}