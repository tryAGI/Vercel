
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared52fb994527107e75ResourceConfigBuildMachineSelection
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
    public static class AutoSDKShared52fb994527107e75ResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared52fb994527107e75ResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared52fb994527107e75ResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared52fb994527107e75ResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared52fb994527107e75ResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared52fb994527107e75ResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared52fb994527107e75ResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}