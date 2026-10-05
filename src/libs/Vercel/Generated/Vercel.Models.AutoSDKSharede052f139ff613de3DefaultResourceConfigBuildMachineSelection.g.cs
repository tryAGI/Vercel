
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharede052f139ff613de3DefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}