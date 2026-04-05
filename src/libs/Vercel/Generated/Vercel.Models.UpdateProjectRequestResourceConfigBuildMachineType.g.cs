
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestResourceConfigBuildMachineType
    {
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
    public static class UpdateProjectRequestResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestResourceConfigBuildMachineType value)
        {
            return value switch
            {
                UpdateProjectRequestResourceConfigBuildMachineType.Elastic => "elastic",
                UpdateProjectRequestResourceConfigBuildMachineType.Enhanced => "enhanced",
                UpdateProjectRequestResourceConfigBuildMachineType.Standard => "standard",
                UpdateProjectRequestResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UpdateProjectRequestResourceConfigBuildMachineType.Elastic,
                "enhanced" => UpdateProjectRequestResourceConfigBuildMachineType.Enhanced,
                "standard" => UpdateProjectRequestResourceConfigBuildMachineType.Standard,
                "turbo" => UpdateProjectRequestResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}