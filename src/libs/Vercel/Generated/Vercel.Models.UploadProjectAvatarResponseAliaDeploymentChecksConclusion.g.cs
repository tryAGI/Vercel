
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseAliaDeploymentChecksConclusion
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
    public static class UploadProjectAvatarResponseAliaDeploymentChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseAliaDeploymentChecksConclusion value)
        {
            return value switch
            {
                UploadProjectAvatarResponseAliaDeploymentChecksConclusion.Canceled => "canceled",
                UploadProjectAvatarResponseAliaDeploymentChecksConclusion.Failed => "failed",
                UploadProjectAvatarResponseAliaDeploymentChecksConclusion.Skipped => "skipped",
                UploadProjectAvatarResponseAliaDeploymentChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseAliaDeploymentChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => UploadProjectAvatarResponseAliaDeploymentChecksConclusion.Canceled,
                "failed" => UploadProjectAvatarResponseAliaDeploymentChecksConclusion.Failed,
                "skipped" => UploadProjectAvatarResponseAliaDeploymentChecksConclusion.Skipped,
                "succeeded" => UploadProjectAvatarResponseAliaDeploymentChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}