
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseResourceConfigBuildMachineType
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
    public static class UpdateProjectResponseResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseResourceConfigBuildMachineType value)
        {
            return value switch
            {
                UpdateProjectResponseResourceConfigBuildMachineType.Enhanced => "enhanced",
                UpdateProjectResponseResourceConfigBuildMachineType.Standard => "standard",
                UpdateProjectResponseResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UpdateProjectResponseResourceConfigBuildMachineType.Enhanced,
                "standard" => UpdateProjectResponseResourceConfigBuildMachineType.Standard,
                "turbo" => UpdateProjectResponseResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}