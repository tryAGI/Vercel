
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759ResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharedd9ba619caaa0a759ResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759ResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759ResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharedd9ba619caaa0a759ResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759ResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharedd9ba619caaa0a759ResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharedd9ba619caaa0a759ResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}