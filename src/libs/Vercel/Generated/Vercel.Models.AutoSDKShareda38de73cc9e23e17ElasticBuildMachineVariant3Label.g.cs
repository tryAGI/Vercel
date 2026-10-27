
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant3Label
    {
        /// <summary>
        ///
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant3LabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant3Label value)
        {
            return value switch
            {
                AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant3Label.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant3Label? ToEnum(string value)
        {
            return value switch
            {
                "turbo" => AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant3Label.Turbo,
                _ => null,
            };
        }
    }
}