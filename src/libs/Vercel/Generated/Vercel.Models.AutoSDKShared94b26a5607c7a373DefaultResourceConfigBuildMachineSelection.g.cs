
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared94b26a5607c7a373DefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}