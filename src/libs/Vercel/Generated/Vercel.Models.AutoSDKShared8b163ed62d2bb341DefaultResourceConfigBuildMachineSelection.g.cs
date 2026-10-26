
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared8b163ed62d2bb341DefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}