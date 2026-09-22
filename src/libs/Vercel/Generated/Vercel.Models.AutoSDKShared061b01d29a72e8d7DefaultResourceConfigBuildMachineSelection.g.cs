
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}