
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharedc9c79e81839bbccdResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}