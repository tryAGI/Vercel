
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKSharedd9ba619caaa0a759DefaultResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}