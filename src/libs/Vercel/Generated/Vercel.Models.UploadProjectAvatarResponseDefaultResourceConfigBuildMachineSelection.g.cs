
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseDefaultResourceConfigBuildMachineSelection
    {
        /// <summary>
        ///
        /// </summary>
        Elastic,
        /// <summary>
        ///
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseDefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}