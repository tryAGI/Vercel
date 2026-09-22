
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf1f589ae3ca84945Variant1Type
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedf1f589ae3ca84945Variant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf1f589ae3ca84945Variant1Type value)
        {
            return value switch
            {
                AutoSDKSharedf1f589ae3ca84945Variant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf1f589ae3ca84945Variant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => AutoSDKSharedf1f589ae3ca84945Variant1Type.User,
                _ => null,
            };
        }
    }
}