
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant2Label
    {
        /// <summary>
        ///
        /// </summary>
        Enhanced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant2LabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant2Label value)
        {
            return value switch
            {
                AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant2Label.Enhanced => "enhanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant2Label? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant2Label.Enhanced,
                _ => null,
            };
        }
    }
}