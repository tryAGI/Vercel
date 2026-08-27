
#nullable enable

namespace Vercel
{
    /// <summary>
    /// What to do when the gate trips: pause the rollout, or roll it back.
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectRollingReleaseGateAction
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
    public static class GetProjectsResponseVariant3ProjectRollingReleaseGateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectRollingReleaseGateAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectRollingReleaseGateAction.Pause => "pause",
                GetProjectsResponseVariant3ProjectRollingReleaseGateAction.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectRollingReleaseGateAction? ToEnum(string value)
        {
            return value switch
            {
                "pause" => GetProjectsResponseVariant3ProjectRollingReleaseGateAction.Pause,
                "rollback" => GetProjectsResponseVariant3ProjectRollingReleaseGateAction.Rollback,
                _ => null,
            };
        }
    }
}