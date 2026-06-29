
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The current state of the rolling release<br/>
    /// Example: ACTIVE
    /// </summary>
    public enum StartRollingReleaseResponseRollingReleaseState
    {
        /// <summary>
        /// 
        /// </summary>
        Aborted,
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Complete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartRollingReleaseResponseRollingReleaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartRollingReleaseResponseRollingReleaseState value)
        {
            return value switch
            {
                StartRollingReleaseResponseRollingReleaseState.Aborted => "ABORTED",
                StartRollingReleaseResponseRollingReleaseState.Active => "ACTIVE",
                StartRollingReleaseResponseRollingReleaseState.Complete => "COMPLETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartRollingReleaseResponseRollingReleaseState? ToEnum(string value)
        {
            return value switch
            {
                "ABORTED" => StartRollingReleaseResponseRollingReleaseState.Aborted,
                "ACTIVE" => StartRollingReleaseResponseRollingReleaseState.Active,
                "COMPLETE" => StartRollingReleaseResponseRollingReleaseState.Complete,
                _ => null,
            };
        }
    }
}