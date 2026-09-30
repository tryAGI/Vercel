
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}