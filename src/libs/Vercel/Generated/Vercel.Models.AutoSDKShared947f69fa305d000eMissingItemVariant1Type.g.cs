
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared947f69fa305d000eMissingItemVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared947f69fa305d000eMissingItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared947f69fa305d000eMissingItemVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared947f69fa305d000eMissingItemVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared947f69fa305d000eMissingItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => AutoSDKShared947f69fa305d000eMissingItemVariant1Type.Host,
                _ => null,
            };
        }
    }
}