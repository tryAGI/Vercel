
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseResourceConfigBuildMachineType
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
    public static class UpdateMicrofrontendsResponseResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseResourceConfigBuildMachineType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseResourceConfigBuildMachineType.Enhanced => "enhanced",
                UpdateMicrofrontendsResponseResourceConfigBuildMachineType.Standard => "standard",
                UpdateMicrofrontendsResponseResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UpdateMicrofrontendsResponseResourceConfigBuildMachineType.Enhanced,
                "standard" => UpdateMicrofrontendsResponseResourceConfigBuildMachineType.Standard,
                "turbo" => UpdateMicrofrontendsResponseResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}