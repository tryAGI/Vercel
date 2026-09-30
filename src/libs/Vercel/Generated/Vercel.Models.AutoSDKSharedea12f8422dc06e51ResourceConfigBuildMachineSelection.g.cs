
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}