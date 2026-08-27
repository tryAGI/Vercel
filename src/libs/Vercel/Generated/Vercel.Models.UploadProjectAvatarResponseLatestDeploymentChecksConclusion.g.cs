
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseLatestDeploymentChecksConclusion
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
    public static class UploadProjectAvatarResponseLatestDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseLatestDeploymentChecksConclusion value)
        {
            return value switch
            {
                UploadProjectAvatarResponseLatestDeploymentChecksConclusion.Canceled => "canceled",
                UploadProjectAvatarResponseLatestDeploymentChecksConclusion.Failed => "failed",
                UploadProjectAvatarResponseLatestDeploymentChecksConclusion.Skipped => "skipped",
                UploadProjectAvatarResponseLatestDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseLatestDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UploadProjectAvatarResponseLatestDeploymentChecksConclusion.Canceled,
                "failed" => UploadProjectAvatarResponseLatestDeploymentChecksConclusion.Failed,
                "skipped" => UploadProjectAvatarResponseLatestDeploymentChecksConclusion.Skipped,
                "succeeded" => UploadProjectAvatarResponseLatestDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}