
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemResourceConfigBuildMachineType
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
    public static class GetProjectsResponseVariant1ItemResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemResourceConfigBuildMachineType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineType.Enhanced => "enhanced",
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineType.Standard => "standard",
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineType.Enhanced,
                "standard" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineType.Standard,
                "turbo" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}