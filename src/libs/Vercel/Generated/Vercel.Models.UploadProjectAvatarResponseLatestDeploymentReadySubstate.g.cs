
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseLatestDeploymentReadySubstate
    {
        /// <summary>
        /// 
        /// </summary>
        Promoted,
        /// <summary>
        /// 
        /// </summary>
        Rolling,
        /// <summary>
        /// 
        /// </summary>
        Staged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseLatestDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseLatestDeploymentReadySubstate value)
        {
            return value switch
            {
                UploadProjectAvatarResponseLatestDeploymentReadySubstate.Promoted => "PROMOTED",
                UploadProjectAvatarResponseLatestDeploymentReadySubstate.Rolling => "ROLLING",
                UploadProjectAvatarResponseLatestDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseLatestDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => UploadProjectAvatarResponseLatestDeploymentReadySubstate.Promoted,
                "ROLLING" => UploadProjectAvatarResponseLatestDeploymentReadySubstate.Rolling,
                "STAGED" => UploadProjectAvatarResponseLatestDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}