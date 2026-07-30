
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectRequestResourceConfigBuildMachineType
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
        Elastic,
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
    public static class CreateProjectRequestResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestResourceConfigBuildMachineType value)
        {
            return value switch
            {
                CreateProjectRequestResourceConfigBuildMachineType.Basic => "basic",
                CreateProjectRequestResourceConfigBuildMachineType.Elastic => "elastic",
                CreateProjectRequestResourceConfigBuildMachineType.Enhanced => "enhanced",
                CreateProjectRequestResourceConfigBuildMachineType.Standard => "standard",
                CreateProjectRequestResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateProjectRequestResourceConfigBuildMachineType.Basic,
                "elastic" => CreateProjectRequestResourceConfigBuildMachineType.Elastic,
                "enhanced" => CreateProjectRequestResourceConfigBuildMachineType.Enhanced,
                "standard" => CreateProjectRequestResourceConfigBuildMachineType.Standard,
                "turbo" => CreateProjectRequestResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}