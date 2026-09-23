
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineSelection
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
    public static class AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared100e7eb80f0eb492ResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}