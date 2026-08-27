
#nullable enable

namespace Vercel
{
    /// <summary>
    /// What to do when the gate trips: pause the rollout, or roll it back.
    /// </summary>
    public enum CreateProjectResponseRollingReleaseGateAction
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
    public static class CreateProjectResponseRollingReleaseGateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseRollingReleaseGateAction value)
        {
            return value switch
            {
                CreateProjectResponseRollingReleaseGateAction.Pause => "pause",
                CreateProjectResponseRollingReleaseGateAction.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseRollingReleaseGateAction? ToEnum(string value)
        {
            return value switch
            {
                "pause" => CreateProjectResponseRollingReleaseGateAction.Pause,
                "rollback" => CreateProjectResponseRollingReleaseGateAction.Rollback,
                _ => null,
            };
        }
    }
}