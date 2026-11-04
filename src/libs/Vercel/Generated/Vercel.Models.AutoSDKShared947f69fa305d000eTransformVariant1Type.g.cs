
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared947f69fa305d000eTransformVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        RequestHeaders,
        /// <summary>
        ///
        /// </summary>
        RequestQuery,
        /// <summary>
        ///
        /// </summary>
        ResponseHeaders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared947f69fa305d000eTransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared947f69fa305d000eTransformVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared947f69fa305d000eTransformVariant1Type.RequestHeaders => "request.headers",
                AutoSDKShared947f69fa305d000eTransformVariant1Type.RequestQuery => "request.query",
                AutoSDKShared947f69fa305d000eTransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared947f69fa305d000eTransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => AutoSDKShared947f69fa305d000eTransformVariant1Type.RequestHeaders,
                "request.query" => AutoSDKShared947f69fa305d000eTransformVariant1Type.RequestQuery,
                "response.headers" => AutoSDKShared947f69fa305d000eTransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}