
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}