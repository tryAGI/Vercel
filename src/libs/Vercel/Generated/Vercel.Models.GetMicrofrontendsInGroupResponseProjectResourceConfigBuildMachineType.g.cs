
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineType
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
    public static class GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineType.Enhanced => "enhanced",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineType.Standard => "standard",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineType.Enhanced,
                "standard" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineType.Standard,
                "turbo" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}