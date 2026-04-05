
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Filter by rolling release state
    /// </summary>
    public enum GetRollingReleaseState
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
    public static class GetRollingReleaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseState value)
        {
            return value switch
            {
                GetRollingReleaseState.Aborted => "ABORTED",
                GetRollingReleaseState.Active => "ACTIVE",
                GetRollingReleaseState.Complete => "COMPLETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseState? ToEnum(string value)
        {
            return value switch
            {
                "ABORTED" => GetRollingReleaseState.Aborted,
                "ACTIVE" => GetRollingReleaseState.Active,
                "COMPLETE" => GetRollingReleaseState.Complete,
                _ => null,
            };
        }
    }
}