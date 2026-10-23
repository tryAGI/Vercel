
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda8d456fca5d8a771ResourceConfigBuildMachineSelection
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
    public static class AutoSDKShareda8d456fca5d8a771ResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda8d456fca5d8a771ResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShareda8d456fca5d8a771ResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShareda8d456fca5d8a771ResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda8d456fca5d8a771ResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShareda8d456fca5d8a771ResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShareda8d456fca5d8a771ResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}