
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineSelection
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
    public static class AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKShareda223f19b9c37327fResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}