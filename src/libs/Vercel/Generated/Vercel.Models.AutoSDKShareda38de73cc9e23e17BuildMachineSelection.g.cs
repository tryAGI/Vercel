
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda38de73cc9e23e17BuildMachineSelection
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
    public static class AutoSDKShareda38de73cc9e23e17BuildMachineSelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda38de73cc9e23e17BuildMachineSelection value)
        {
            return value switch
            {
                AutoSDKShareda38de73cc9e23e17BuildMachineSelection.Elastic => "elastic",
                AutoSDKShareda38de73cc9e23e17BuildMachineSelection.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda38de73cc9e23e17BuildMachineSelection? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShareda38de73cc9e23e17BuildMachineSelection.Elastic,
                "fixed" => AutoSDKShareda38de73cc9e23e17BuildMachineSelection.Fixed,
                _ => null,
            };
        }
    }
}