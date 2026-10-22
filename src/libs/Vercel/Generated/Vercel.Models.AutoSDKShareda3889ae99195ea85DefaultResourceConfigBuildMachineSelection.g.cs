
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}