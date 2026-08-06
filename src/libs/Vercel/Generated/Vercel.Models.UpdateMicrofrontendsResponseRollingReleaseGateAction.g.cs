
#nullable enable

namespace Vercel
{
    /// <summary>
    /// What to do when the gate trips: pause the rollout, or roll it back.
    /// </summary>
    public enum UpdateMicrofrontendsResponseRollingReleaseGateAction
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
    public static class UpdateMicrofrontendsResponseRollingReleaseGateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseRollingReleaseGateAction value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseRollingReleaseGateAction.Pause => "pause",
                UpdateMicrofrontendsResponseRollingReleaseGateAction.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseRollingReleaseGateAction? ToEnum(string value)
        {
            return value switch
            {
                "pause" => UpdateMicrofrontendsResponseRollingReleaseGateAction.Pause,
                "rollback" => UpdateMicrofrontendsResponseRollingReleaseGateAction.Rollback,
                _ => null,
            };
        }
    }
}