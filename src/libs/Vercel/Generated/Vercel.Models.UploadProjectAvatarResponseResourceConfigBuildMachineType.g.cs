
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseResourceConfigBuildMachineType
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
    public static class UploadProjectAvatarResponseResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseResourceConfigBuildMachineType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseResourceConfigBuildMachineType.Basic => "basic",
                UploadProjectAvatarResponseResourceConfigBuildMachineType.Enhanced => "enhanced",
                UploadProjectAvatarResponseResourceConfigBuildMachineType.Standard => "standard",
                UploadProjectAvatarResponseResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => UploadProjectAvatarResponseResourceConfigBuildMachineType.Basic,
                "enhanced" => UploadProjectAvatarResponseResourceConfigBuildMachineType.Enhanced,
                "standard" => UploadProjectAvatarResponseResourceConfigBuildMachineType.Standard,
                "turbo" => UploadProjectAvatarResponseResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}