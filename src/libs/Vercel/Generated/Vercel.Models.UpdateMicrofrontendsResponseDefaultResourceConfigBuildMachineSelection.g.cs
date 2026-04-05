
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineSelection
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
    public static class UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => UpdateMicrofrontendsResponseDefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}