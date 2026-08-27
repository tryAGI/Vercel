
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseTargetsChecksConclusion
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Failed,
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
    public static class UploadProjectAvatarResponseTargetsChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTargetsChecksConclusion value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTargetsChecksConclusion.Canceled => "canceled",
                UploadProjectAvatarResponseTargetsChecksConclusion.Failed => "failed",
                UploadProjectAvatarResponseTargetsChecksConclusion.Skipped => "skipped",
                UploadProjectAvatarResponseTargetsChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTargetsChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UploadProjectAvatarResponseTargetsChecksConclusion.Canceled,
                "failed" => UploadProjectAvatarResponseTargetsChecksConclusion.Failed,
                "skipped" => UploadProjectAvatarResponseTargetsChecksConclusion.Skipped,
                "succeeded" => UploadProjectAvatarResponseTargetsChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}