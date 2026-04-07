
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When set to `PAUSED`, the rollout is frozen at the current percentage until continued.
    /// </summary>
    public enum GetRollingReleaseResponseRollingReleaseSubstate
    {
        /// <summary>
        /// 
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRollingReleaseResponseRollingReleaseSubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseResponseRollingReleaseSubstate value)
        {
            return value switch
            {
                GetRollingReleaseResponseRollingReleaseSubstate.Paused => "PAUSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseResponseRollingReleaseSubstate? ToEnum(string value)
        {
            return value switch
            {
                "PAUSED" => GetRollingReleaseResponseRollingReleaseSubstate.Paused,
                _ => null,
            };
        }
    }
}