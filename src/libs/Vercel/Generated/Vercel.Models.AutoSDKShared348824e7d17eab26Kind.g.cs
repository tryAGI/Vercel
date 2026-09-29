
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared348824e7d17eab26Kind
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
    public static class AutoSDKShared348824e7d17eab26KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared348824e7d17eab26Kind value)
        {
            return value switch
            {
                AutoSDKShared348824e7d17eab26Kind.Boolean => "boolean",
                AutoSDKShared348824e7d17eab26Kind.Json => "json",
                AutoSDKShared348824e7d17eab26Kind.Number => "number",
                AutoSDKShared348824e7d17eab26Kind.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared348824e7d17eab26Kind? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AutoSDKShared348824e7d17eab26Kind.Boolean,
                "json" => AutoSDKShared348824e7d17eab26Kind.Json,
                "number" => AutoSDKShared348824e7d17eab26Kind.Number,
                "string" => AutoSDKShared348824e7d17eab26Kind.String,
                _ => null,
            };
        }
    }
}