
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant1Label
    {
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant1LabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant1Label value)
        {
            return value switch
            {
                AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant1Label.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant1Label? ToEnum(string value)
        {
            return value switch
            {
                "standard" => AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant1Label.Standard,
                _ => null,
            };
        }
    }
}