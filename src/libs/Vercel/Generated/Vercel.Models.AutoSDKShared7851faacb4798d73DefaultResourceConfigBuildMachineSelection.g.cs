
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared7851faacb4798d73DefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}