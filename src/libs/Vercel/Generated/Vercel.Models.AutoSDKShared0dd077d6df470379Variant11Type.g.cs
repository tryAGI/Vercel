
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0dd077d6df470379Variant11Type
    {
        /// <summary>
        ///
        /// </summary>
        CursorOrigin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0dd077d6df470379Variant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0dd077d6df470379Variant11Type value)
        {
            return value switch
            {
                AutoSDKShared0dd077d6df470379Variant11Type.CursorOrigin => "cursor-origin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0dd077d6df470379Variant11Type? ToEnum(string value)
        {
            return value switch
            {
                "cursor-origin" => AutoSDKShared0dd077d6df470379Variant11Type.CursorOrigin,
                _ => null,
            };
        }
    }
}