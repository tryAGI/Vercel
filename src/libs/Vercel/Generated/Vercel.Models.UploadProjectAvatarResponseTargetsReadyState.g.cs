
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseTargetsReadyState
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
    public static class UploadProjectAvatarResponseTargetsReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTargetsReadyState value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTargetsReadyState.Blocked => "BLOCKED",
                UploadProjectAvatarResponseTargetsReadyState.Building => "BUILDING",
                UploadProjectAvatarResponseTargetsReadyState.Canceled => "CANCELED",
                UploadProjectAvatarResponseTargetsReadyState.Error => "ERROR",
                UploadProjectAvatarResponseTargetsReadyState.Initializing => "INITIALIZING",
                UploadProjectAvatarResponseTargetsReadyState.Queued => "QUEUED",
                UploadProjectAvatarResponseTargetsReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTargetsReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => UploadProjectAvatarResponseTargetsReadyState.Blocked,
                "BUILDING" => UploadProjectAvatarResponseTargetsReadyState.Building,
                "CANCELED" => UploadProjectAvatarResponseTargetsReadyState.Canceled,
                "ERROR" => UploadProjectAvatarResponseTargetsReadyState.Error,
                "INITIALIZING" => UploadProjectAvatarResponseTargetsReadyState.Initializing,
                "QUEUED" => UploadProjectAvatarResponseTargetsReadyState.Queued,
                "READY" => UploadProjectAvatarResponseTargetsReadyState.Ready,
                _ => null,
            };
        }
    }
}