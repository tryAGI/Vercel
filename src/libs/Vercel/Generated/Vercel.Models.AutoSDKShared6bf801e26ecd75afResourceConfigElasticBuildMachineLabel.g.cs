
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared6bf801e26ecd75afResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared6bf801e26ecd75afResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared6bf801e26ecd75afResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared6bf801e26ecd75afResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared6bf801e26ecd75afResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared6bf801e26ecd75afResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}