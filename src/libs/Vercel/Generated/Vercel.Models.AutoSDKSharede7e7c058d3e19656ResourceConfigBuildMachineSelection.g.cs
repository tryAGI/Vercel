
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}