
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseLatestDeploymentReadyState
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        Building,
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Initializing,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseLatestDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseLatestDeploymentReadyState value)
        {
            return value switch
            {
                UploadProjectAvatarResponseLatestDeploymentReadyState.Blocked => "BLOCKED",
                UploadProjectAvatarResponseLatestDeploymentReadyState.Building => "BUILDING",
                UploadProjectAvatarResponseLatestDeploymentReadyState.Canceled => "CANCELED",
                UploadProjectAvatarResponseLatestDeploymentReadyState.Error => "ERROR",
                UploadProjectAvatarResponseLatestDeploymentReadyState.Initializing => "INITIALIZING",
                UploadProjectAvatarResponseLatestDeploymentReadyState.Queued => "QUEUED",
                UploadProjectAvatarResponseLatestDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseLatestDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => UploadProjectAvatarResponseLatestDeploymentReadyState.Blocked,
                "BUILDING" => UploadProjectAvatarResponseLatestDeploymentReadyState.Building,
                "CANCELED" => UploadProjectAvatarResponseLatestDeploymentReadyState.Canceled,
                "ERROR" => UploadProjectAvatarResponseLatestDeploymentReadyState.Error,
                "INITIALIZING" => UploadProjectAvatarResponseLatestDeploymentReadyState.Initializing,
                "QUEUED" => UploadProjectAvatarResponseLatestDeploymentReadyState.Queued,
                "READY" => UploadProjectAvatarResponseLatestDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}