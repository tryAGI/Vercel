
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseDefaultResourceConfigBuildMachineType
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
    public static class CreateProjectResponseDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                CreateProjectResponseDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                CreateProjectResponseDefaultResourceConfigBuildMachineType.Standard => "standard",
                CreateProjectResponseDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => CreateProjectResponseDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => CreateProjectResponseDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => CreateProjectResponseDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}