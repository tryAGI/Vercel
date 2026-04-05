
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseDefaultResourceConfigBuildMachineSelection
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
    public static class UpdateProjectResponseDefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                UpdateProjectResponseDefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                UpdateProjectResponseDefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UpdateProjectResponseDefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => UpdateProjectResponseDefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}