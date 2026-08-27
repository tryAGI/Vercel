
#nullable enable

namespace Vercel
{
    /// <summary>
    /// What to do when the gate trips: pause the rollout, or roll it back.
    /// </summary>
    public enum UploadProjectAvatarResponseRollingReleaseGateAction
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
    public static class UploadProjectAvatarResponseRollingReleaseGateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseRollingReleaseGateAction value)
        {
            return value switch
            {
                UploadProjectAvatarResponseRollingReleaseGateAction.Pause => "pause",
                UploadProjectAvatarResponseRollingReleaseGateAction.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseRollingReleaseGateAction? ToEnum(string value)
        {
            return value switch
            {
                "pause" => UploadProjectAvatarResponseRollingReleaseGateAction.Pause,
                "rollback" => UploadProjectAvatarResponseRollingReleaseGateAction.Rollback,
                _ => null,
            };
        }
    }
}