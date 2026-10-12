
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbResourceConfigElasticBuildMachineLabel
    {
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
    public static class AutoSDKSharedba7c6b12ca723bfbResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKSharedba7c6b12ca723bfbResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKSharedba7c6b12ca723bfbResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKSharedba7c6b12ca723bfbResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}