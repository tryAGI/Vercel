
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseResourceConfigBuildMachineType
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
    public static class CreateProjectResponseResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseResourceConfigBuildMachineType value)
        {
            return value switch
            {
                CreateProjectResponseResourceConfigBuildMachineType.Basic => "basic",
                CreateProjectResponseResourceConfigBuildMachineType.Enhanced => "enhanced",
                CreateProjectResponseResourceConfigBuildMachineType.Standard => "standard",
                CreateProjectResponseResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateProjectResponseResourceConfigBuildMachineType.Basic,
                "enhanced" => CreateProjectResponseResourceConfigBuildMachineType.Enhanced,
                "standard" => CreateProjectResponseResourceConfigBuildMachineType.Standard,
                "turbo" => CreateProjectResponseResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}