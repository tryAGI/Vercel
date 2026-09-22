
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9554e4a81de92250MissingItemVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Host,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9554e4a81de92250MissingItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9554e4a81de92250MissingItemVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared9554e4a81de92250MissingItemVariant1Type.Host => "host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9554e4a81de92250MissingItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "host" => AutoSDKShared9554e4a81de92250MissingItemVariant1Type.Host,
                _ => null,
            };
        }
    }
}