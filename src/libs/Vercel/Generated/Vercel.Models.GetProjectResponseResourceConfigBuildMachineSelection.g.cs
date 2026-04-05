
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseResourceConfigBuildMachineSelection
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
    public static class GetProjectResponseResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                GetProjectResponseResourceConfigBuildMachineSelection.Elastic => "elastic",
                GetProjectResponseResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => GetProjectResponseResourceConfigBuildMachineSelection.Elastic,
                "fixed" => GetProjectResponseResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}