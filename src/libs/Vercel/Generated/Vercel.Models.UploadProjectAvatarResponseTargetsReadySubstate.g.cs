
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseTargetsReadySubstate
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
    public static class UploadProjectAvatarResponseTargetsReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTargetsReadySubstate value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTargetsReadySubstate.Promoted => "PROMOTED",
                UploadProjectAvatarResponseTargetsReadySubstate.Rolling => "ROLLING",
                UploadProjectAvatarResponseTargetsReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTargetsReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => UploadProjectAvatarResponseTargetsReadySubstate.Promoted,
                "ROLLING" => UploadProjectAvatarResponseTargetsReadySubstate.Rolling,
                "STAGED" => UploadProjectAvatarResponseTargetsReadySubstate.Staged,
                _ => null,
            };
        }
    }
}