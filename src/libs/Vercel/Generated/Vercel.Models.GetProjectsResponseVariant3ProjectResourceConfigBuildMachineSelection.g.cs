
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectResourceConfigBuildMachineSelection
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
    public static class GetProjectsResponseVariant3ProjectResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineSelection.Elastic => "elastic",
                GetProjectsResponseVariant3ProjectResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineSelection.Elastic,
                "fixed" => GetProjectsResponseVariant3ProjectResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}