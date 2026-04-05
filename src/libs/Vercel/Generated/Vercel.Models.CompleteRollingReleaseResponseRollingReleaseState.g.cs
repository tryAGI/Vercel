
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The current state of the rolling release<br/>
    /// Example: ACTIVE
    /// </summary>
    public enum CompleteRollingReleaseResponseRollingReleaseState
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
    public static class CompleteRollingReleaseResponseRollingReleaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteRollingReleaseResponseRollingReleaseState value)
        {
            return value switch
            {
                CompleteRollingReleaseResponseRollingReleaseState.Aborted => "ABORTED",
                CompleteRollingReleaseResponseRollingReleaseState.Active => "ACTIVE",
                CompleteRollingReleaseResponseRollingReleaseState.Complete => "COMPLETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteRollingReleaseResponseRollingReleaseState? ToEnum(string value)
        {
            return value switch
            {
                "ABORTED" => CompleteRollingReleaseResponseRollingReleaseState.Aborted,
                "ACTIVE" => CompleteRollingReleaseResponseRollingReleaseState.Active,
                "COMPLETE" => CompleteRollingReleaseResponseRollingReleaseState.Complete,
                _ => null,
            };
        }
    }
}