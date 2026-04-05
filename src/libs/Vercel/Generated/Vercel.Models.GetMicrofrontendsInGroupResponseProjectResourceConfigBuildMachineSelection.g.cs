
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineSelection
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
    public static class GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineSelection.Elastic => "elastic",
                GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineSelection.Elastic,
                "fixed" => GetMicrofrontendsInGroupResponseProjectResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}