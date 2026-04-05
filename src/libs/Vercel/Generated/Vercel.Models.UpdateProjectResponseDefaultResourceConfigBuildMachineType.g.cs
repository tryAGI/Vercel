
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseDefaultResourceConfigBuildMachineType
    {
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
    public static class UpdateProjectResponseDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                UpdateProjectResponseDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                UpdateProjectResponseDefaultResourceConfigBuildMachineType.Standard => "standard",
                UpdateProjectResponseDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UpdateProjectResponseDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => UpdateProjectResponseDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => UpdateProjectResponseDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}