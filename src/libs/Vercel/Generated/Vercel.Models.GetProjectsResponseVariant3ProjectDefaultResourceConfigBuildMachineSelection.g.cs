
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineSelection
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
    public static class GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => GetProjectsResponseVariant3ProjectDefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}