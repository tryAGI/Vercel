
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1e1af2b60dfcf13aFallthroughVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Split,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared1e1af2b60dfcf13aFallthroughVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1e1af2b60dfcf13aFallthroughVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared1e1af2b60dfcf13aFallthroughVariant2Type.Split => "split",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1e1af2b60dfcf13aFallthroughVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "split" => AutoSDKShared1e1af2b60dfcf13aFallthroughVariant2Type.Split,
                _ => null,
            };
        }
    }
}