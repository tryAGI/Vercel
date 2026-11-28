
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared477368a6d087a9cdKind
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
    public static class AutoSDKShared477368a6d087a9cdKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared477368a6d087a9cdKind value)
        {
            return value switch
            {
                AutoSDKShared477368a6d087a9cdKind.Boolean => "boolean",
                AutoSDKShared477368a6d087a9cdKind.Json => "json",
                AutoSDKShared477368a6d087a9cdKind.Number => "number",
                AutoSDKShared477368a6d087a9cdKind.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared477368a6d087a9cdKind? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AutoSDKShared477368a6d087a9cdKind.Boolean,
                "json" => AutoSDKShared477368a6d087a9cdKind.Json,
                "number" => AutoSDKShared477368a6d087a9cdKind.Number,
                "string" => AutoSDKShared477368a6d087a9cdKind.String,
                _ => null,
            };
        }
    }
}