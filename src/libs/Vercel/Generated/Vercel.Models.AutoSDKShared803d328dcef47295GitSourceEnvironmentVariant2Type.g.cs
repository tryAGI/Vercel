
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared803d328dcef47295GitSourceEnvironmentVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared803d328dcef47295GitSourceEnvironmentVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared803d328dcef47295GitSourceEnvironmentVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared803d328dcef47295GitSourceEnvironmentVariant2Type.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared803d328dcef47295GitSourceEnvironmentVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "custom" => AutoSDKShared803d328dcef47295GitSourceEnvironmentVariant2Type.Custom,
                _ => null,
            };
        }
    }
}