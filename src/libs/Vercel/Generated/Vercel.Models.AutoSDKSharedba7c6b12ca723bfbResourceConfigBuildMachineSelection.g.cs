
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}