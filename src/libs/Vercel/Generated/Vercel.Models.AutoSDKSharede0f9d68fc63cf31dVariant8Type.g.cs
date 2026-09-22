
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0f9d68fc63cf31dVariant8Type
    {
        /// <summary>
        ///
        /// </summary>
        CursorOrigin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede0f9d68fc63cf31dVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0f9d68fc63cf31dVariant8Type value)
        {
            return value switch
            {
                AutoSDKSharede0f9d68fc63cf31dVariant8Type.CursorOrigin => "cursor-origin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0f9d68fc63cf31dVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "cursor-origin" => AutoSDKSharede0f9d68fc63cf31dVariant8Type.CursorOrigin,
                _ => null,
            };
        }
    }
}