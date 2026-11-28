
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd67d8d405d3f0000BuildMachineType
    {
        /// <summary>
        ///
        /// </summary>
        Basic,
        /// <summary>
        ///
        /// </summary>
        Elastic,
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
    public static class AutoSDKSharedd67d8d405d3f0000BuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd67d8d405d3f0000BuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedd67d8d405d3f0000BuildMachineType.Basic => "basic",
                AutoSDKSharedd67d8d405d3f0000BuildMachineType.Elastic => "elastic",
                AutoSDKSharedd67d8d405d3f0000BuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedd67d8d405d3f0000BuildMachineType.Standard => "standard",
                AutoSDKSharedd67d8d405d3f0000BuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd67d8d405d3f0000BuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedd67d8d405d3f0000BuildMachineType.Basic,
                "elastic" => AutoSDKSharedd67d8d405d3f0000BuildMachineType.Elastic,
                "enhanced" => AutoSDKSharedd67d8d405d3f0000BuildMachineType.Enhanced,
                "standard" => AutoSDKSharedd67d8d405d3f0000BuildMachineType.Standard,
                "turbo" => AutoSDKSharedd67d8d405d3f0000BuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}