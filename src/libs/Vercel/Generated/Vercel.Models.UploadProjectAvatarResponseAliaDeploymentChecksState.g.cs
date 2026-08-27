
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseAliaDeploymentChecksState
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Registered,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseAliaDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseAliaDeploymentChecksState value)
        {
            return value switch
            {
                UploadProjectAvatarResponseAliaDeploymentChecksState.Completed => "completed",
                UploadProjectAvatarResponseAliaDeploymentChecksState.Registered => "registered",
                UploadProjectAvatarResponseAliaDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseAliaDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UploadProjectAvatarResponseAliaDeploymentChecksState.Completed,
                "registered" => UploadProjectAvatarResponseAliaDeploymentChecksState.Registered,
                "running" => UploadProjectAvatarResponseAliaDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}