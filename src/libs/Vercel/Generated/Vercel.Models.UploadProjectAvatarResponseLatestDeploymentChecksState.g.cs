
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseLatestDeploymentChecksState
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
    public static class UploadProjectAvatarResponseLatestDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseLatestDeploymentChecksState value)
        {
            return value switch
            {
                UploadProjectAvatarResponseLatestDeploymentChecksState.Completed => "completed",
                UploadProjectAvatarResponseLatestDeploymentChecksState.Registered => "registered",
                UploadProjectAvatarResponseLatestDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseLatestDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UploadProjectAvatarResponseLatestDeploymentChecksState.Completed,
                "registered" => UploadProjectAvatarResponseLatestDeploymentChecksState.Registered,
                "running" => UploadProjectAvatarResponseLatestDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}