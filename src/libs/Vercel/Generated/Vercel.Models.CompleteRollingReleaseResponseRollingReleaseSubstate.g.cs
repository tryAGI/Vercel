
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When set to `PAUSED`, the rollout is frozen at the current percentage until continued.
    /// </summary>
    public enum CompleteRollingReleaseResponseRollingReleaseSubstate
    {
        /// <summary>
        /// 
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompleteRollingReleaseResponseRollingReleaseSubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteRollingReleaseResponseRollingReleaseSubstate value)
        {
            return value switch
            {
                CompleteRollingReleaseResponseRollingReleaseSubstate.Paused => "PAUSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteRollingReleaseResponseRollingReleaseSubstate? ToEnum(string value)
        {
            return value switch
            {
                "PAUSED" => CompleteRollingReleaseResponseRollingReleaseSubstate.Paused,
                _ => null,
            };
        }
    }
}