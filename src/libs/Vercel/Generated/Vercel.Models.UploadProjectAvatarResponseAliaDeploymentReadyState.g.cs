
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseAliaDeploymentReadyState
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
    public static class UploadProjectAvatarResponseAliaDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseAliaDeploymentReadyState value)
        {
            return value switch
            {
                UploadProjectAvatarResponseAliaDeploymentReadyState.Blocked => "BLOCKED",
                UploadProjectAvatarResponseAliaDeploymentReadyState.Building => "BUILDING",
                UploadProjectAvatarResponseAliaDeploymentReadyState.Canceled => "CANCELED",
                UploadProjectAvatarResponseAliaDeploymentReadyState.Error => "ERROR",
                UploadProjectAvatarResponseAliaDeploymentReadyState.Initializing => "INITIALIZING",
                UploadProjectAvatarResponseAliaDeploymentReadyState.Queued => "QUEUED",
                UploadProjectAvatarResponseAliaDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseAliaDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => UploadProjectAvatarResponseAliaDeploymentReadyState.Blocked,
                "BUILDING" => UploadProjectAvatarResponseAliaDeploymentReadyState.Building,
                "CANCELED" => UploadProjectAvatarResponseAliaDeploymentReadyState.Canceled,
                "ERROR" => UploadProjectAvatarResponseAliaDeploymentReadyState.Error,
                "INITIALIZING" => UploadProjectAvatarResponseAliaDeploymentReadyState.Initializing,
                "QUEUED" => UploadProjectAvatarResponseAliaDeploymentReadyState.Queued,
                "READY" => UploadProjectAvatarResponseAliaDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}