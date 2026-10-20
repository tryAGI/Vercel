
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineType
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
    public static class AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineType value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineType.Basic => "basic",
                AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineType.Enhanced => "enhanced",
                AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineType.Standard => "standard",
                AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineType.Basic,
                "enhanced" => AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineType.Enhanced,
                "standard" => AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineType.Standard,
                "turbo" => AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigBuildMachineType.Turbo,
                _ => null,
            };
        }
    }
}