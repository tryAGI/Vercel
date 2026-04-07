
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When set to `PAUSED`, the rollout is frozen at the current percentage until continued.
    /// </summary>
    public enum ApproveRollingReleaseStageResponseRollingReleaseSubstate
    {
        /// <summary>
        /// 
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApproveRollingReleaseStageResponseRollingReleaseSubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApproveRollingReleaseStageResponseRollingReleaseSubstate value)
        {
            return value switch
            {
                ApproveRollingReleaseStageResponseRollingReleaseSubstate.Paused => "PAUSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApproveRollingReleaseStageResponseRollingReleaseSubstate? ToEnum(string value)
        {
            return value switch
            {
                "PAUSED" => ApproveRollingReleaseStageResponseRollingReleaseSubstate.Paused,
                _ => null,
            };
        }
    }
}