
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseDefaultResourceConfigBuildMachineType
    {
        /// <summary>
        ///
        /// </summary>
        Basic,
        /// <summary>
        ///
        /// </summary>
        Enhanced,
        /// <summary>
        ///
        /// </summary>
        Standard,
        /// <summary>
        ///
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineType.Basic => "basic",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineType.Standard => "standard",
                UploadProjectAvatarResponseDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => UploadProjectAvatarResponseDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}