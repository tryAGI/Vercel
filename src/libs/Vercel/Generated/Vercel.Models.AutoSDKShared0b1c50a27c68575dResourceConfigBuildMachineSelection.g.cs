
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineSelection
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
    public static class AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared0b1c50a27c68575dResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}