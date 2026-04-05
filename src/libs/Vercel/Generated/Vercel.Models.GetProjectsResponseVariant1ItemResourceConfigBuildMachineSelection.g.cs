
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemResourceConfigBuildMachineSelection
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
    public static class GetProjectsResponseVariant1ItemResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineSelection.Elastic => "elastic",
                GetProjectsResponseVariant1ItemResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineSelection.Elastic,
                "fixed" => GetProjectsResponseVariant1ItemResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}