
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759ResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKSharedd9ba619caaa0a759ResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759ResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759ResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKSharedd9ba619caaa0a759ResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKSharedd9ba619caaa0a759ResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759ResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKSharedd9ba619caaa0a759ResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKSharedd9ba619caaa0a759ResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKSharedd9ba619caaa0a759ResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}