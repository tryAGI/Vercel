
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}