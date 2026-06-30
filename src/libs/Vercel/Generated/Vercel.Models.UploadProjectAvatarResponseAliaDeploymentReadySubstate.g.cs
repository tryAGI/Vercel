
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseAliaDeploymentReadySubstate
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
    public static class UploadProjectAvatarResponseAliaDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseAliaDeploymentReadySubstate value)
        {
            return value switch
            {
                UploadProjectAvatarResponseAliaDeploymentReadySubstate.Promoted => "PROMOTED",
                UploadProjectAvatarResponseAliaDeploymentReadySubstate.Rolling => "ROLLING",
                UploadProjectAvatarResponseAliaDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseAliaDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => UploadProjectAvatarResponseAliaDeploymentReadySubstate.Promoted,
                "ROLLING" => UploadProjectAvatarResponseAliaDeploymentReadySubstate.Rolling,
                "STAGED" => UploadProjectAvatarResponseAliaDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}