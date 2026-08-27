
#nullable enable

namespace Vercel
{
    /// <summary>
    /// What to do when the gate trips: pause the rollout, or roll it back.
    /// </summary>
    public enum UpdateProjectResponseRollingReleaseGateAction
    {
        /// <summary>
        /// pause the rollout, or roll it back.
        /// </summary>
        Pause,
        /// <summary>
        ///
        /// </summary>
        Rollback,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseRollingReleaseGateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseRollingReleaseGateAction value)
        {
            return value switch
            {
                UpdateProjectResponseRollingReleaseGateAction.Pause => "pause",
                UpdateProjectResponseRollingReleaseGateAction.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseRollingReleaseGateAction? ToEnum(string value)
        {
            return value switch
            {
                "pause" => UpdateProjectResponseRollingReleaseGateAction.Pause,
                "rollback" => UpdateProjectResponseRollingReleaseGateAction.Rollback,
                _ => null,
            };
        }
    }
}