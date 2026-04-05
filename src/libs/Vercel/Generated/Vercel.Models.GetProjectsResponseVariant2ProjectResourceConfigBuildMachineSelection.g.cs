
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectResourceConfigBuildMachineSelection
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
    public static class GetProjectsResponseVariant2ProjectResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineSelection.Elastic => "elastic",
                GetProjectsResponseVariant2ProjectResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineSelection.Elastic,
                "fixed" => GetProjectsResponseVariant2ProjectResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}