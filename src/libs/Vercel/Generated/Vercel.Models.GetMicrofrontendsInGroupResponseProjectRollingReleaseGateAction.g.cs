
#nullable enable

namespace Vercel
{
    /// <summary>
    /// What to do when the gate trips: pause the rollout, or roll it back.
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectRollingReleaseGateAction
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
    public static class GetMicrofrontendsInGroupResponseProjectRollingReleaseGateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectRollingReleaseGateAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectRollingReleaseGateAction.Pause => "pause",
                GetMicrofrontendsInGroupResponseProjectRollingReleaseGateAction.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectRollingReleaseGateAction? ToEnum(string value)
        {
            return value switch
            {
                "pause" => GetMicrofrontendsInGroupResponseProjectRollingReleaseGateAction.Pause,
                "rollback" => GetMicrofrontendsInGroupResponseProjectRollingReleaseGateAction.Rollback,
                _ => null,
            };
        }
    }
}