
#nullable enable

namespace Vercel
{
    /// <summary>
    /// What to do when the gate trips: pause the rollout, or roll it back.
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectRollingReleaseGateAction
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
    public static class GetProjectsResponseVariant2ProjectRollingReleaseGateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectRollingReleaseGateAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectRollingReleaseGateAction.Pause => "pause",
                GetProjectsResponseVariant2ProjectRollingReleaseGateAction.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectRollingReleaseGateAction? ToEnum(string value)
        {
            return value switch
            {
                "pause" => GetProjectsResponseVariant2ProjectRollingReleaseGateAction.Pause,
                "rollback" => GetProjectsResponseVariant2ProjectRollingReleaseGateAction.Rollback,
                _ => null,
            };
        }
    }
}