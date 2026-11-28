
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant3Label
    {
        /// <summary>
        ///
        /// </summary>
        x14cpu28gb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant3LabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant3Label value)
        {
            return value switch
            {
                AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant3Label.x14cpu28gb => "14cpu-28gb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant3Label? ToEnum(string value)
        {
            return value switch
            {
                "14cpu-28gb" => AutoSDKSharedd67d8d405d3f0000ElasticBuildMachineVariant3Label.x14cpu28gb,
                _ => null,
            };
        }
    }
}