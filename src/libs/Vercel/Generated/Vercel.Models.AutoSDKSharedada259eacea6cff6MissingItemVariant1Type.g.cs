
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedada259eacea6cff6MissingItemVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedada259eacea6cff6MissingItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedada259eacea6cff6MissingItemVariant1Type value)
        {
            return value switch
            {
                AutoSDKSharedada259eacea6cff6MissingItemVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedada259eacea6cff6MissingItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => AutoSDKSharedada259eacea6cff6MissingItemVariant1Type.Host,
                _ => null,
            };
        }
    }
}