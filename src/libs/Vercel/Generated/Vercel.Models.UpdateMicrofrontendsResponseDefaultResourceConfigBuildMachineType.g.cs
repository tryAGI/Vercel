
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineType
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
    public static class UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineType.Standard => "standard",
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}