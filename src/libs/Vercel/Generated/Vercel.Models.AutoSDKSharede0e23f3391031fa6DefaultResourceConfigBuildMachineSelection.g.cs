
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineSelection
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
    public static class AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineSelection.Elastic => "elastic",
                AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineSelection.Elastic,
                "fixed" => AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}