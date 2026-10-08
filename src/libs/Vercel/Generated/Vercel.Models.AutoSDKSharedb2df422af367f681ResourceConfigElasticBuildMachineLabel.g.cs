
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKSharedb2df422af367f681ResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKSharedb2df422af367f681ResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb2df422af367f681ResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKSharedb2df422af367f681ResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKSharedb2df422af367f681ResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKSharedb2df422af367f681ResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb2df422af367f681ResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKSharedb2df422af367f681ResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKSharedb2df422af367f681ResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKSharedb2df422af367f681ResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}