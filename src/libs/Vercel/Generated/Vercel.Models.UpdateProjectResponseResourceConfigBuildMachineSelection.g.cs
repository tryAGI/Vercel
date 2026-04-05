
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseResourceConfigBuildMachineSelection
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
    public static class UpdateProjectResponseResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                UpdateProjectResponseResourceConfigBuildMachineSelection.Elastic => "elastic",
                UpdateProjectResponseResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UpdateProjectResponseResourceConfigBuildMachineSelection.Elastic,
                "fixed" => UpdateProjectResponseResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}