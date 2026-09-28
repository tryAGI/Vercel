
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}