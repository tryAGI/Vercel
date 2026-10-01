
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}