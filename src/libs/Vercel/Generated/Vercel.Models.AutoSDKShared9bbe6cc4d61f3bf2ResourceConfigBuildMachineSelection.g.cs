
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineSelection
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared9bbe6cc4d61f3bf2ResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}