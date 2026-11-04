
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedada259eacea6cff6TransformVariant1Type
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
    public static class AutoSDKSharedada259eacea6cff6TransformVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedada259eacea6cff6TransformVariant1Type value)
        {
            return value switch
            {
                AutoSDKSharedada259eacea6cff6TransformVariant1Type.RequestHeaders => "request.headers",
                AutoSDKSharedada259eacea6cff6TransformVariant1Type.RequestQuery => "request.query",
                AutoSDKSharedada259eacea6cff6TransformVariant1Type.ResponseHeaders => "response.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedada259eacea6cff6TransformVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => AutoSDKSharedada259eacea6cff6TransformVariant1Type.RequestHeaders,
                "request.query" => AutoSDKSharedada259eacea6cff6TransformVariant1Type.RequestQuery,
                "response.headers" => AutoSDKSharedada259eacea6cff6TransformVariant1Type.ResponseHeaders,
                _ => null,
            };
        }
    }
}