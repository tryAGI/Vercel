
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedec1121c0746f62d9HaVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedec1121c0746f62d9HaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedec1121c0746f62d9HaVariant1Type value)
        {
            return value switch
            {
                AutoSDKSharedec1121c0746f62d9HaVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedec1121c0746f62d9HaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => AutoSDKSharedec1121c0746f62d9HaVariant1Type.Host,
                _ => null,
            };
        }
    }
}