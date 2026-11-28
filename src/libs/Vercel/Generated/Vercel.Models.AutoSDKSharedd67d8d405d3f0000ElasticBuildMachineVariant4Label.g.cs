
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant4Label
    {
        /// <summary>
        ///
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant4LabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant4Label value)
        {
            return value switch
            {
                AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant4Label.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant4Label? ToEnum(string value)
        {
            return value switch
            {
                "turbo" => AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant4Label.Turbo,
                _ => null,
            };
        }
    }
}