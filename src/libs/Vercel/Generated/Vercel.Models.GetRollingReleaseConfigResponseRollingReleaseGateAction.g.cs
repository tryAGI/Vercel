
#nullable enable

namespace Vercel
{
    /// <summary>
    /// What to do when the gate trips: pause the rollout, or roll it back.
    /// </summary>
    public enum GetRollingReleaseConfigResponseRollingReleaseGateAction
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
    public static class GetRollingReleaseConfigResponseRollingReleaseGateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseConfigResponseRollingReleaseGateAction value)
        {
            return value switch
            {
                GetRollingReleaseConfigResponseRollingReleaseGateAction.Pause => "pause",
                GetRollingReleaseConfigResponseRollingReleaseGateAction.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseConfigResponseRollingReleaseGateAction? ToEnum(string value)
        {
            return value switch
            {
                "pause" => GetRollingReleaseConfigResponseRollingReleaseGateAction.Pause,
                "rollback" => GetRollingReleaseConfigResponseRollingReleaseGateAction.Rollback,
                _ => null,
            };
        }
    }
}