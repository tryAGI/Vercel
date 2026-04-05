
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineType
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
    public static class GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineType.Standard => "standard",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineType.Standard,
                "turbo" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}