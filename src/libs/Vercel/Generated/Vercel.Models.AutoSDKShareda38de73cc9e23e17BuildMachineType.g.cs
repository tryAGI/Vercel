
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda38de73cc9e23e17BuildMachineType
    {
        /// <summary>
        ///
        /// </summary>
        Basic,
        /// <summary>
        ///
        /// </summary>
        Enhanced,
        /// <summary>
        ///
        /// </summary>
        Standard,
        /// <summary>
        ///
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda38de73cc9e23e17BuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda38de73cc9e23e17BuildMachineType value)
        {
            return value switch
            {
                AutoSDKShareda38de73cc9e23e17BuildMachineType.Basic => "basic",
                AutoSDKShareda38de73cc9e23e17BuildMachineType.Enhanced => "enhanced",
                AutoSDKShareda38de73cc9e23e17BuildMachineType.Standard => "standard",
                AutoSDKShareda38de73cc9e23e17BuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda38de73cc9e23e17BuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShareda38de73cc9e23e17BuildMachineType.Basic,
                "enhanced" => AutoSDKShareda38de73cc9e23e17BuildMachineType.Enhanced,
                "standard" => AutoSDKShareda38de73cc9e23e17BuildMachineType.Standard,
                "turbo" => AutoSDKShareda38de73cc9e23e17BuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}