
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant4Label
    {
        /// <summary>
        ///
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant4LabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant4Label value)
        {
            return value switch
            {
                AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant4Label.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant4Label? ToEnum(string value)
        {
            return value switch
            {
                "turbo" => AutoSDKSharedbbf450e6ecd4e724ElasticBuildMachineVariant4Label.Turbo,
                _ => null,
            };
        }
    }
}