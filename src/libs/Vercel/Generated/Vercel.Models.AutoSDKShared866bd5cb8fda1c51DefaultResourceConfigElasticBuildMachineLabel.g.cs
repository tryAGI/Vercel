
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
    /// </summary>
    public enum AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabel
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
    public static class AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabel value)
        {
            return value switch
            {
                AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabel.Enhanced => "enhanced",
                AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabel.Standard => "standard",
                AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabel.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabel? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabel.Enhanced,
                "standard" => AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabel.Standard,
                "turbo" => AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabel.Turbo,
                _ => null,
            };
        }
    }
}