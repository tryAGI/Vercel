
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharedfe1f84289679c6c4ResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}