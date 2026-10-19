
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineSelection
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
    public static class AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared94b26a5607c7a373ResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}