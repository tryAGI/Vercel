
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant3Label
    {
        /// <summary>
        ///
        /// </summary>
        x14cpu28gb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant3LabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant3Label value)
        {
            return value switch
            {
                AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant3Label.x14cpu28gb => "14cpu-28gb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant3Label? ToEnum(string value)
        {
            return value switch
            {
                "14cpu-28gb" => AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant3Label.x14cpu28gb,
                _ => null,
            };
        }
    }
}