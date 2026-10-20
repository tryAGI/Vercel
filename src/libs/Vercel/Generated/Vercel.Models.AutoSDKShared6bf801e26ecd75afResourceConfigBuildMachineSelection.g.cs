
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineSelection
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
    public static class AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShared6bf801e26ecd75afResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}