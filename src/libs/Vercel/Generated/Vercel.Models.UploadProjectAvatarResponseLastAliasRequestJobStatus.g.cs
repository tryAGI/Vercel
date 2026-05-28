
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseLastAliasRequestJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseLastAliasRequestJobStatus value)
        {
            return value switch
            {
                UploadProjectAvatarResponseLastAliasRequestJobStatus.Failed => "failed",
                UploadProjectAvatarResponseLastAliasRequestJobStatus.InProgress => "in-progress",
                UploadProjectAvatarResponseLastAliasRequestJobStatus.Pending => "pending",
                UploadProjectAvatarResponseLastAliasRequestJobStatus.Skipped => "skipped",
                UploadProjectAvatarResponseLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => UploadProjectAvatarResponseLastAliasRequestJobStatus.Failed,
                "in-progress" => UploadProjectAvatarResponseLastAliasRequestJobStatus.InProgress,
                "pending" => UploadProjectAvatarResponseLastAliasRequestJobStatus.Pending,
                "skipped" => UploadProjectAvatarResponseLastAliasRequestJobStatus.Skipped,
                "succeeded" => UploadProjectAvatarResponseLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}