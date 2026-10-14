
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2f24cdccbdde3d24Kind
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Json,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2f24cdccbdde3d24KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2f24cdccbdde3d24Kind value)
        {
            return value switch
            {
                AutoSDKShared2f24cdccbdde3d24Kind.Boolean => "boolean",
                AutoSDKShared2f24cdccbdde3d24Kind.Json => "json",
                AutoSDKShared2f24cdccbdde3d24Kind.Number => "number",
                AutoSDKShared2f24cdccbdde3d24Kind.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2f24cdccbdde3d24Kind? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AutoSDKShared2f24cdccbdde3d24Kind.Boolean,
                "json" => AutoSDKShared2f24cdccbdde3d24Kind.Json,
                "number" => AutoSDKShared2f24cdccbdde3d24Kind.Number,
                "string" => AutoSDKShared2f24cdccbdde3d24Kind.String,
                _ => null,
            };
        }
    }
}