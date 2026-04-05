
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineSelection
    {
        /// <summary>
        /// 
        /// </summary>
        Elastic,
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}