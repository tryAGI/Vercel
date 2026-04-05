
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseDefaultResourceConfigBuildMachineType
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
    public static class GetProjectResponseDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                GetProjectResponseDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                GetProjectResponseDefaultResourceConfigBuildMachineType.Standard => "standard",
                GetProjectResponseDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetProjectResponseDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => GetProjectResponseDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => GetProjectResponseDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}