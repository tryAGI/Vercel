
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The current state of the rolling release<br/>
    /// Example: ACTIVE
    /// </summary>
    public enum GetRollingReleaseResponseRollingReleaseState
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
    public static class GetRollingReleaseResponseRollingReleaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseResponseRollingReleaseState value)
        {
            return value switch
            {
                GetRollingReleaseResponseRollingReleaseState.Aborted => "ABORTED",
                GetRollingReleaseResponseRollingReleaseState.Active => "ACTIVE",
                GetRollingReleaseResponseRollingReleaseState.Complete => "COMPLETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseResponseRollingReleaseState? ToEnum(string value)
        {
            return value switch
            {
                "ABORTED" => GetRollingReleaseResponseRollingReleaseState.Aborted,
                "ACTIVE" => GetRollingReleaseResponseRollingReleaseState.Active,
                "COMPLETE" => GetRollingReleaseResponseRollingReleaseState.Complete,
                _ => null,
            };
        }
    }
}