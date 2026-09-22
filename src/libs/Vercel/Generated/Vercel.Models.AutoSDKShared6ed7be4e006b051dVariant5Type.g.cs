
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed7be4e006b051dVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        CursorOrigin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6ed7be4e006b051dVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed7be4e006b051dVariant5Type value)
        {
            return value switch
            {
                AutoSDKShared6ed7be4e006b051dVariant5Type.CursorOrigin => "cursor-origin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed7be4e006b051dVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "cursor-origin" => AutoSDKShared6ed7be4e006b051dVariant5Type.CursorOrigin,
                _ => null,
            };
        }
    }
}