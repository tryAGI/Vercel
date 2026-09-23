
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharedd5e5cf9c62b8ab7fResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}