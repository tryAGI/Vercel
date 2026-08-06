
#nullable enable

namespace Vercel
{
    /// <summary>
    /// What to do when the gate trips: pause the rollout, or roll it back.
    /// </summary>
    public enum GetProjectResponseRollingReleaseGateAction
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
    public static class GetProjectResponseRollingReleaseGateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseRollingReleaseGateAction value)
        {
            return value switch
            {
                GetProjectResponseRollingReleaseGateAction.Pause => "pause",
                GetProjectResponseRollingReleaseGateAction.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseRollingReleaseGateAction? ToEnum(string value)
        {
            return value switch
            {
                "pause" => GetProjectResponseRollingReleaseGateAction.Pause,
                "rollback" => GetProjectResponseRollingReleaseGateAction.Rollback,
                _ => null,
            };
        }
    }
}