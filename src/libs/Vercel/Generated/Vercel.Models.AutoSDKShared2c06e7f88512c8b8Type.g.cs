
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2c06e7f88512c8b8Type
    {
        /// <summary>
        ///
        /// </summary>
        Array,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2c06e7f88512c8b8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2c06e7f88512c8b8Type value)
        {
            return value switch
            {
                AutoSDKShared2c06e7f88512c8b8Type.Array => "array",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2c06e7f88512c8b8Type? ToEnum(string value)
        {
            return value switch
            {
                "array" => AutoSDKShared2c06e7f88512c8b8Type.Array,
                _ => null,
            };
        }
    }
}